using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using SpaDay.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        // GET: /user
        public IActionResult Index()
        {
            return View();
        }

        // GET: /user/add
        public IActionResult Add()
        {
            AddUserViewModel addUserViewModel = new AddUserViewModel();

            return View(addUserViewModel);
            
        }

        // POST: /user/add
        [HttpPost("/user/add")]
        public IActionResult Create(AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid)
            {

                if (addUserViewModel.Password == addUserViewModel.Verify)
                {
                    User user = new User 
                    {
                        Username = addUserViewModel.Username,
                        Password = addUserViewModel.Password,
                        Email = addUserViewModel.Email
                    };
                    return View("Index", user);
                }
                else
                {

                    ViewBag.error = "Passwords didn't match !";
                    return View("Add", addUserViewModel);
                }                
            }
            return View("Add", addUserViewModel);
        }
    }
}
