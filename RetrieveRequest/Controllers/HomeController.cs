using System;
using System.Web.Mvc;
using RetrieveRequest.Models;

namespace RetrieveRequest.Controllers
{
    public class HomeController : Controller
    {
        // GET
        //[HttpPost]
        //By default it is HttpGet Request
        //Since it is HttpGet therefore the Else block will be executed which takes to  Index.cshtml file
        //If the request is HttpPost then if block statement will be executed which will take to RegistrationView.cshtml file
        //By Default the request is [HttpGet]
        //To the request POST we have to explicitly mention [HttpPost]
        /*public ActionResult Index()
        {
            if (Request.HttpMethod != "GET")
            {
                return View("RegistrationView");
            }
            else
            {
                //return Content("Hello World");
                return View();
            }
        }*/
        
        //The View Page is Required to make a request
        public ActionResult Index(string email1)
        {
            //This will take to the Registration View in the RegistrationView.cshtml
            return View("RegistrationView");
        }

        //______Using Request_______
        /*[HttpPost]
        //The Registration Form method is POST. This will work since this Request is HttpPost
        //However if the form method is GET, then after submitting the form it will return to the same View Page.
        //If this request were HttpGet(also the form method is GET) then it will not work. It will show a blank Page
        public ActionResult Index()
        {
            //It will print the text found in the input field of Email from the Index.cshtml file
            return Content(Request["email1"]);
        }*/

        /*//______Using Parameter_______
        [HttpPost]
        //The method must contain parameters in order to display the information
        public ActionResult Index(string email1, string name1)
        {
            return Content("Name: \n" + name1+ " Email: " + email1);
        }*/
        
        //_______Using FormCollection_______
        [HttpPost]
        public ActionResult Index(FormCollection formCollection)
        {
            return Content("Name: " + formCollection["name1"] + ", Email: " + formCollection["email1"]);
        }
        
        //____Using Model Binding____
        /*[HttpPost]
        //The method must contain parameter of object-Type
        //Without parameter, If In the method block the object type is created, It will Not work!
        public ActionResult Index(Person person)
        {
            //Person person = new Person(); If we avoid parameter and create an object inside the block, this will not work
            //Therefore Object Must be in the parameter List
            return Content("Name: "+person.Name1+", Email: "+person.Email1);
        }*/
        
        /*[HttpGet]
        public ActionResult Index(string name1, string email1)
        {
            return Content(name1+", "+email1);
        }*/
    }
}