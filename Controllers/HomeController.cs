using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;

namespace JobBoard.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/jobboard")]
    public ActionResult JobBoard()
    {
      if (JobBoardVariable.GetAll() != null)
      {
        List<JobBoardVariable> allJobs = JobBoardVariable.GetAll();
        return View("JobBoard", allJobs);
      }
      return View();
    }
    [HttpGet("/addjob")]
    public ActionResult AddJob()
    {
      return View();
    }
    [HttpPost("/jobboard")]
    public ActionResult CreateAddJob()
    {
      JobBoardVariable myJobBoard = new JobBoardVariable(Request.Form["jobName"], Request.Form["jobDescription"]);
      myJobBoard.Save();
      List<JobBoardVariable> allJobs = JobBoardVariable.GetAll();
      return View("JobBoard", allJobs);

    }
    [HttpPost("/jobBoard/delete")]
          public ActionResult DeleteAll()
          {
              JobBoardVariable.ClearAll();
              return View();
          }
  }
}
