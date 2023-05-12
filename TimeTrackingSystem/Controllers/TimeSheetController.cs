using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTrackingSystem.Models;

namespace TimeTrackingSystem.Controllers
{
    public class TimeSheetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult ViewTimeLogs()
        {
            return View();
        }
        public JsonResult GetTimeSheets()
        {
            List<Timesheet> timesheets = new List<Timesheet>() { 
                new Timesheet(){ Id = 1, ProjectId = 1 , ProjectName = "Project1" , RecordDate = DateTime.Today.AddDays(-10), Timespent = new TimeSpan(9, 0 , 0) },
                new Timesheet(){ Id = 1, ProjectId = 1 , ProjectName = "Project1" , RecordDate = DateTime.Today.AddDays(-11), Timespent = new TimeSpan(4, 0 , 0) },
                new Timesheet(){ Id = 1, ProjectId = 1 , ProjectName = "Project2" , RecordDate = DateTime.Today.AddDays(-1), Timespent = new TimeSpan(7, 0 , 0) },
                new Timesheet(){ Id = 1, ProjectId = 1 , ProjectName = "Project1" , RecordDate = DateTime.Today.AddDays(-8), Timespent = new TimeSpan(2, 0 , 0) },
                new Timesheet(){ Id = 1, ProjectId = 1 , ProjectName = "Project3" , RecordDate = DateTime.Today.AddDays(-4), Timespent = new TimeSpan(1, 30 , 0) },
                new Timesheet(){ Id = 1, ProjectId = 1 , ProjectName = "Project1" , RecordDate = DateTime.Today.AddDays(-5), Timespent = new TimeSpan(2, 30 , 0) },
                new Timesheet(){ Id = 1, ProjectId = 1 , ProjectName = "Project4" , RecordDate = DateTime.Today.AddDays(-4), Timespent = new TimeSpan(4, 0 , 0) },
                new Timesheet(){ Id = 1, ProjectId = 1 , ProjectName = "Project4" , RecordDate = DateTime.Today.AddDays(-1), Timespent = new TimeSpan(2, 0 , 0) },
                new Timesheet(){ Id = 1, ProjectId = 1 , ProjectName = "Project1" , RecordDate = DateTime.Today.AddDays(-2), Timespent = new TimeSpan(5, 0 , 0) },
                new Timesheet(){ Id = 1, ProjectId = 1 , ProjectName = "Project7" , RecordDate = DateTime.Today.AddDays(-1), Timespent = new TimeSpan(6, 0 , 0) },
                new Timesheet(){ Id = 1, ProjectId = 1 , ProjectName = "Project1" , RecordDate = DateTime.Today, Timespent = new TimeSpan(8, 0 , 0) },
                new Timesheet(){ Id = 1, ProjectId = 1 , ProjectName = "Project5" , RecordDate = DateTime.Today, Timespent = new TimeSpan(3, 0 , 0) },
                new Timesheet(){ Id = 1, ProjectId = 1 , ProjectName = "Project11" , RecordDate = DateTime.Today.AddDays(-4), Timespent = new TimeSpan(7, 0 , 0) },
                new Timesheet(){ Id = 1, ProjectId = 1 , ProjectName = "Project1" , RecordDate = DateTime.Today.AddDays(-15), Timespent = new TimeSpan(2, 0 , 0) },
            };
            return Json(new { data = timesheets.OrderByDescending(o => o.RecordDate).ToList() });
        }
    }
}
