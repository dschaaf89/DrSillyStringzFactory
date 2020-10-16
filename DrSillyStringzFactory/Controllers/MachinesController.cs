using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DrSillyStringzFactory.Models;

namespace DrSillyStringzFactory.Controllers
{
    public class MachinesController : Controller
    {
    private readonly FactoryContext _db;
    public MachinesController(FactoryContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Machine> model = _db.Machines.OrderBy(x => x.Name).ToList();
      return View(model);
    }
     public ActionResult Create()
    {
      return View();
    }
    [HttpPost]
    public ActionResult Create(Machine machine)
    {
      _db.Machines.Add(machine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Delete(int id)
    {
      var thisMachine = _db.Machines.FirstOrDefault(x => x.MachineId == id);
      return View(thisMachine);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisMachine = _db.Machines.FirstOrDefault(x => x.MachineId == id);
      _db.Machines.Remove(thisMachine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
     public ActionResult Details(int id)
    {
      Machine model = _db.Machines.FirstOrDefault(machine => machine.MachineId == id);
      return View(model);
    }
    public ActionResult AddEngineer(int id)
    {
      Machine thisMachine = _db.Machines.FirstOrDefault(s => s.MachineId == id);
      ViewBag.EngineerID = new SelectList(_db.Engineers, "EngineerId", "Name");
      return View(thisMachine);
    }
    [HttpPost]
    public ActionResult AddEngineer(EngineerMachine engineerMachine)
    {
      if (engineerMachine.EngineerId != 0)
      {
        if (_db.EngineerMachines.Where(x => x.MachineId == engineerMachine.MachineId && x.EngineerId == engineerMachine.EngineerId).ToHashSet().Count == 0)
        {
          _db.EngineerMachines.Add(engineerMachine);
        }
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
        
    }
}