using CRUD_application_2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
 
namespace CRUD_application_2.Controllers
{
    public class UserController : Controller
    {
        public static List<User> userlist = new List<User>();

        // GET: User
         public ActionResult Index()
        {
            // Implement the Index method here
            return View(userlist); // Return the userlist to the view
        }
 
      // GET: User/Details/5
        public ActionResult Details(int id)
        {
            // Retrieve the user from the userlist based on the provided id
            User user = userlist.FirstOrDefault(u => u.Id == id);

            // Check if the user exists
            if (user == null)
            {
                // If no user is found with the provided id, return a HttpNotFoundResult
                return HttpNotFound();
            }

            // Pass the user to the View method to display the user details
            return View(user);
        }
 
        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(User user)
        {

            userlist.Add(user); // Add the user to the userlist
            return RedirectToAction("Index"); // Redirect to the Index action to display the updated list of users
        }

        // GET: User/Edit/5
        public ActionResult Edit(User user)

        {


            // Pass the user to the Edit view to display the user details for editing
            return View(user);
        }

        // GET: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id)
        {
            // Retrieve the user from the userlist based on the provided ID
            User user = userlist.FirstOrDefault(u => u.Id == id);

            // Check if the user exists
            if (user == null)
            {
                // If no user is found with the provided id, return a HttpNotFoundResult
                return HttpNotFound();
            }

            // Pass the user to the Edit view to display the user details for editing
            return RedirectToAction("Index");

        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            // Implement the Delete method here
            User user = userlist.FirstOrDefault(u => u.Id == id);

            // Check if the user exists
            if (user == null)
            {
                // If no user is found with the provided id, return a HttpNotFoundResult
                return HttpNotFound();
            }

            userlist.Remove(user); // Remove the user from the userlist

            return RedirectToAction("Index");
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            // Implement the Delete method (POST) here
            User user = userlist.FirstOrDefault(u => u.Id == id);

            // Check if the user exists
            if (user == null)
            {
                // If no user is found with the provided id, return a HttpNotFoundResult
                return HttpNotFound();
            }

            userlist.Remove(user); // Remove the user from the userlist

            return RedirectToAction("Index"); // Redirect to the Index action to display the updated list of users
        }
    }
}
