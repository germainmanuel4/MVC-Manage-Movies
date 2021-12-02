using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVCCRUDVisualStudio2022.Controllers
{
    public class HelloWorldController : Controller
    {
       //A Controller class is where the code is written that handles the incoming browser requests.

        //GET: /HelloWorld/
        /*public string Index() //THis index is converted to HelloWorld endpoint
        {
            return "This is my default action...";
        }*/

        //GET /HelloWorld/Welcome

        /*public string Welcome(string name, int ID = 1) 
        {
            //return HtmlEncoder.Default.Encode($"Hello {name}, Numtimes is: {numTimes}");
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }*/


        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Welcome(string name, int numTimes = 1)
        {
            //return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();

        }


    }
}
