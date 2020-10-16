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
    public ActionResult Create()
    {
      return View();
    }
    [HttpPost]
    public ActionResult Create(Engineer engineer)
    {
      _db.Engineers.Add(engineer);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult details(int id)
    {
      Engineer model = _db.Engineers.FirstOrDefault(x => x.EngineerId == id);
      return View(model); 
    }
    public ActionResult AddDoctor(int id)
    {
      Engineer thisEngineer = _db.Engineers.FirstOrDefault(s => s.EngineerId == id);
      ViewBag.MachineId = new SelectList(_db.Machines, "MachineId", "Name");
      return View(thisEngineer);
    }
    [HttpPost]
    public ActionResult AddDoctor(EngineerMachine engineerMachine)
    {
      if (engineerMachine.MachineId != 0)
      {
        if (_db.EngineerMachines.Where(x => x.EngineerId == engineerMachine.EngineerId && x.MachineId == engineerMachine.MachineId).ToHashSet().Count == 0)
        {
          _db.EngineerMachines.Add(engineerMachine);
        }
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}