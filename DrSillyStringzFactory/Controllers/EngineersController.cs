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
    private readonly FactoryContext _db;
    public EngineersController(FactoryContext db)
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
    public ActionResult AddLicense(int id)
    {
      Engineer thisEngineer = _db.Engineers.FirstOrDefault(s => s.EngineerId == id);
      ViewBag.LicenseId = new SelectList(_db.Licenses, "LicenseId", "LicenseType");
      return View(thisEngineer);
    }
    [HttpPost]
    public ActionResult AddLicense(EngineerLicense engineerLicense)
    {
      if (engineerLicense.LicenseId != 0)
      {
        if (_db.EngineerLicenses.Where(x => x.EngineerId == engineerLicense.EngineerId && x.LicenseId == engineerLicense.LicenseId).ToHashSet().Count == 0)
        {
          _db.EngineerLicenses.Add(engineerLicense);
        }
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Delete(int id)
    {
      var thisEngineer = _db.Engineers.FirstOrDefault(x => x.EngineerId == id);
      return View(thisEngineer);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisEngineer = _db.Engineers.FirstOrDefault(x => x.EngineerId == id);
      _db.Engineers.Remove(thisEngineer);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    
  }
}