using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTrackingSystem.Models;

namespace TimeTrackingSystem.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult GetProject()
        {
            List<Project> projects = new List<Project>() {
                new Project(){Id = 1 , Name = "UniversalDataManagement" , CreatedBy = 1, CreatedOn=DateTime.Today, StartDate=DateTime.Now,EndDate = DateTime.Now.AddDays(30) , 
                    ProjectMembers = new List<ProjectMember>(){ 
                        new ProjectMember() { UserId = 1 , GroupId = 1 , GroupName = "Star 1 ?",Id = 1,UserName = "Shan" , UserEmail = "Shan@Anbv.com"} ,
                        new ProjectMember() { UserId = 2 , GroupId = 1 , GroupName = "Star 1 ?",Id = 1,UserName = "Ram" , UserEmail = "Shan@Anbv.com"} ,
                        new ProjectMember() { UserId = 3 , GroupId = 1 , GroupName = "Star 1 ?",Id = 1,UserName = "Shyan" , UserEmail = "Shan@Anbv.com"} ,
                        new ProjectMember() { UserId = 4, GroupId = 1, GroupName = "Star 1 ?", Id = 1, UserName = "Aan", UserEmail = "Shan@Anbv.com" } 
                    } },
                new Project(){Id = 1 , Name = "AzureCloudManagement" , CreatedBy = 1, CreatedOn=DateTime.Today, StartDate=DateTime.Now,EndDate = DateTime.Now.AddDays(30)},
                new Project(){Id = 1 , Name = "HumanResourceManagement" , CreatedBy = 1, CreatedOn=DateTime.Today, StartDate=DateTime.Now,EndDate = DateTime.Now.AddDays(30)},
            };
            return Json(new { data = projects });
        }
    }
}
