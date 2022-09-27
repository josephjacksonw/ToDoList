using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    // [HttpGet("/items/new")]
    // public ActionResult CreateForm()
    // {
    //   return View();
    // }

    // [HttpPost("/items")]
    // public ActionResult Create(string description)
    // {
    //   Item myItem = new Item(description);
    //   return RedirectToAction("Index");
    // }
  }
}