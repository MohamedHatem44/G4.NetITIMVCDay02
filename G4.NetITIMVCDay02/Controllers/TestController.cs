using Microsoft.AspNetCore.Mvc;

namespace G4.NetITIMVCDay02.Controllers
{
    public class TestController : Controller
    {
        // Action
        // => Can't be private
        // => Can't be static
        // => Can't be overload



        // Action
        // Test/ShowHello
        public string ShowHello()
        {
            return "Hello from Test Controller";
        }

        public ContentResult ShowHello2()
        {
            // Declare Ob
            ContentResult contentResult = new ContentResult();
            // Set Return
            contentResult.Content = "Hello from Test Controller Show Hello 2";
            // return
            return contentResult;
        }

        public ViewResult ShowHello3() 
        { 
            // Declare Ob
            ViewResult viewResult = new ViewResult();
            //Set Data
            viewResult.ViewName = "Show";
            //return
            return viewResult;
        }

        public ViewResult ShowHello4()
        {
            return View();
        }

        public IActionResult ShowHello5()
        {
            return View();
        }

        // Type of Return of Action
        // 1- Content "String"    => ContentResult
        // 2- View "HTML"         => ViewResult
        // 3- JavaScript          => JavaScriptResult
        // 4- Json                => JsonResult
        // 5- NotFound            => NotFoundResult
        // 6- File                => FileResult

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
