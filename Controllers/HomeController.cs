using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //public async Task<List<UserModel>> GetUsers()
        //{
        //    var response = await UserRepo.GetUsers();
        //    return response;
        //}


        //public async Task<IActionResult> AddPerson(UserModel data)
        //{
        //    try
        //    {
        //        var response = await UserRepo.AddPerson(data);
        //        var result = "Person Added Successfully!";
        //        return Json(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(new { error = true, message = ex.Message });
        //    }
        //}

        //public async Task<UserModel> GetSingleUsers(int id)
        //{
        //    var response = await UserRepo.GetSingleUsers(id);
        //    return response;
        //}
        //public async Task<IActionResult> UpdatePerson(UserModel data)
        //{
        //    try
        //    {
        //        var response = await UserRepo.UpdatePerson(data);
        //        var result = "Person Updated Successfully!";
        //        return Json(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(new { error = true, message = ex.Message });
        //    }
        //}
        //public async Task<IActionResult> UpdatePerson(int id, string name, string email)
        //{


        //    var response = await UserRepo.UpdatePerson(id, name, email);
        //    var result = response == "Success" ? "Person Updated Successfully!" : "Failed to update the task.";
        //    return Json(result);
        //}
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var response = await UserRepo.Delete(id);
        //    var result = "Employee Deleted Successfully...!";
        //    return Json(result);
        //}


       

        //public async Task<List<UserModel>>GetUsers()
        //{
        //    var response = await UserRepo.GetUsers();
        //    return response;
        //}






        //public  async Task<List<Credentials>>Get()
        // {
        //    var response = await UserRepo.Get();
        // return response;
        //    }


        //public async Task<IActionResult> Save(Credentials data)
        //{
            
            
        //        var response = await UserRepo.Save(data);
        //        var result = "Person Added Successfully!";
        //        return Json(result);
            
            
        //}



    }
}

