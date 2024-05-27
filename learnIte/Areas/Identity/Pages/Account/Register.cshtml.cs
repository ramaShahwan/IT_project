using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using MyTables.Entities;
using MyTables.Entity.NewFolder;

namespace learnIte.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<UserEntity> _signInManager;
        private readonly UserManager<UserEntity> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly RoleManager<IdentityRole<int>> _rolemanger;
        public RegisterModel(
            UserManager<UserEntity> userManager,
            SignInManager<UserEntity> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            RoleManager<IdentityRole<int>> rolemanger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _rolemanger = rolemanger;
        }
        
        [BindProperty]
        public InputModel Input { get; set; }
        
        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            [Required(ErrorMessage = "type is required")]
            [Display(Name = "university Or student")]
            public Type_Of Type { get; set; }

            //one to one relation
            public UniversityEntity university { get; set; }
            public StudentEntity student { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ViewData["MyNumber"] ="University";
            ReturnUrl = returnUrl;
            //Input.Type = Type_Of.Student;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new UserEntity {
                    UserName =new MailAddress(Input.Email).User,
                    Email = Input.Email,
                    Type=Input.Type,
                    university=Input.university,
                    student = Input.student
                };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    if(! await _rolemanger.RoleExistsAsync(SD.AdmainUser))
                    {
                        await _rolemanger.CreateAsync(new IdentityRole<int>(SD.AdmainUser));
                    }
                    if (!await _rolemanger.RoleExistsAsync(SD.StudentUser))
                    {
                        await _rolemanger.CreateAsync(new IdentityRole<int>(SD.StudentUser));
                    }
                    if (!await _rolemanger.RoleExistsAsync(SD.UniversityUser))
                    {
                        await _rolemanger.CreateAsync(new IdentityRole<int>(SD.UniversityUser));
                    }
                    string role = HttpContext.Request.Form["userrole"].ToString();
                    if (string.IsNullOrEmpty(role) && user.Type == Type_Of.University)
                    {
                        await _userManager.AddToRoleAsync(user, SD.UniversityUser);
                    }
                    else if (string.IsNullOrEmpty(role) && user.Type == Type_Of.Student)
                    {
                        await _userManager.AddToRoleAsync(user, SD.StudentUser);
                    }else
                    {
                        await _userManager.AddToRoleAsync(user, role);
                        return RedirectToAction("Index", "", new { Area = "Admain" });
                    }
                 

                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                  
                }
                foreach (var error in result.Errors)
                { 
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
