using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ThriveHavenMovies.Models;

public class PreferencesController : Controller
{
    private readonly IPaymentRepository _paymentRepository;
    private readonly UserManager<Users> _userManager;

    public PreferencesController(IPaymentRepository paymentRepository, UserManager<Users> userManager)
    {
        _paymentRepository = paymentRepository;
        _userManager = userManager;
    }

    public async Task<IActionResult> Preferences()
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null) return RedirectToAction("Login", "Account");

        var payments = _paymentRepository.GetPaymentsByUser(user.Id);

        var viewModel = new PreferencesViewModel
        {
            CurrentUser = user,
            Payments = payments
        };

        return View(viewModel);
    }
    [HttpPost]

    [HttpPost]
    public async Task<IActionResult> EditAccount(PreferencesViewModel model)
    {
        var user = await _userManager.GetUserAsync(User);

        if (user == null)
        {
            return NotFound();
        }

        user.FirstName = model.CurrentUser.FirstName;
        user.LastName = model.CurrentUser.LastName;
        user.Email = model.CurrentUser.Email;
        user.UserName = model.CurrentUser.UserName; 
        user.Street = model.CurrentUser.Street;
        user.City = model.CurrentUser.City;
        user.State = model.CurrentUser.State;
        user.ZipCode = model.CurrentUser.ZipCode;

        
        var result = await _userManager.UpdateAsync(user);

        if (result.Succeeded)
        {
            TempData["Message"] = "Account updated successfully!";
            return RedirectToAction("Preferences");
        }

       
        model.CurrentUser = user;

        return View("Preferences", model);
    }
    public async Task<IActionResult> SavePayment(Payment payment)
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null) return RedirectToAction("Login", "Account");

        payment.UserId = user.Id;

        if (payment.IsDefault)
        {
            var existingDefault = _paymentRepository.GetDefaultPayment(user.Id);
            if (existingDefault != null)
            {
                existingDefault.IsDefault = false;
                _paymentRepository.Update(existingDefault);
            }
        }

        _paymentRepository.Add(payment);
        return RedirectToAction("Preferences");
    }

    [HttpPost]

    public async Task<IActionResult> DeletePayment(Payment payment)
    {
        var user = await _userManager.GetUserAsync (User);
        if (user == null) return RedirectToAction("Login", "Account");

        _paymentRepository.Delete(payment);
        return RedirectToAction("Preferences");
    }

    [HttpPost]
    public async Task<IActionResult>EditPayment(Payment payment)
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null) return RedirectToAction("Login", "Account");

        _paymentRepository.Update(payment);
        return RedirectToAction("Preferences");
    }
}
