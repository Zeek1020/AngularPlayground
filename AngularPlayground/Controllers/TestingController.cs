using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace AngularPlayground.Controllers
{
    public class TestingController : Controller
    {

        public bool show = false;

        public TestingController() {
            Debug.WriteLine("Constructor has fired");
        }

        public void toggleShow() {

            Debug.WriteLine("Toggling");
            this.show = !this.show;
        }

        public IActionResult Index( int parm )
        {
            Debug.WriteLine("Testing");
            Debug.WriteLine(parm);
            return View();
        }
    }
}
