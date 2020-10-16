using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DrSillyStringzFactory.Models;
namespace DrSillyStringzFactory.Controllers
{
    public class LicensesController : Controller
  {
    private readonly FactoryContext _db;
    public LicensesController(FactoryContext db)
    {
      _db = db;
    } 

    public ActionResult Index()
    {
      List<License> model = _db.Licenses.OrderBy(x => x.LicenseType).ToList();
      return View(model);
    }
    public ActionResult Create() 
    {
      return View();
    }
    [HttpPost]
    public ActionResult Create(License license)
    {
      _db.Licenses.Add(license);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult details(int id)
    {
        License model = _db.Licenses.FirstOrDefault(x => x.LicenseId == id);
        return View(model);
    }
      public ActionResult Delete(int id)
    {
      var thisLicense = _db.Licenses.FirstOrDefault(x => x.LicenseId == id);
      return View(thisLicense);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisLicense = _db.Licenses.FirstOrDefault(x => x.LicenseId == id);
      _db.Licenses.Remove(thisLicense);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}