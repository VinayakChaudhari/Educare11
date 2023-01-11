using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HighwayHelp.Models;
using BLL;
using BOL;
using System.Collections.Generic;

namespace Collegecare.Controllers;

public class AuthController : Controller
{
    private readonly ILogger<AuthController> _logger;

    public AuthController(ILogger<AuthController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // HelpManager hm=new HelpManager();
        // List<Hospital> allHospitals=hm.GetAllHospitals();
        // this.ViewData["hospitals"]=allHospitals;

        return View();
    }

    public IActionResult Login()
    {
        // HelpManager hm=new HelpManager();
        // List<Hospital> allHospitals=hm.GetAllHospitals();
        // this.ViewData["hospitals"]=allHospitals;

        return View();
    }
public IActionResult WelcomeAdmin(){
    return View();
}
   
    public IActionResult Validate(string username,string password){
        HelpManager hm=new HelpManager();
        if(hm.DoValidate(username,password)){
            return Redirect("WelcomeAdmin");
        }
        return view();
    }
   } 

   

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

