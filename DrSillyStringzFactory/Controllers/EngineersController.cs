using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DrSillyStringzFactory.Models;
namespace DrSillyStringzFactory.Controllers
{
    public class EngineersController : Controller
    {
    private readonly EngineerMachineContext _db;
    public EngineersController(EngineerMachineContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Engineer> model = _db.Engineers.OrderBy(x => x.Name).ToList();
      return View(model);
    }
    }
}