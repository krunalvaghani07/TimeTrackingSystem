using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTrackingSystem.Models;

namespace TimeTrackingSystem.Controllers
{
    public class GroupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult GetGroups()
        {
            List<Group> groups = new List<Group>() {
                new Group(){Id = 1 , Name = "UniversalDataManagementGroup" , CreatedBy = 1, CreatedOn=DateTime.Today ,
                    GroupMembers = new List<GroupMember>(){
                        new GroupMember() { UserId = 1 , GroupMemberId = 1 ,UserName = "Shan" , UserEmail = "Shan@Anbv.com"} ,
                        new GroupMember() { UserId = 2 , GroupMemberId = 1 ,UserName = "Ram" , UserEmail = "Shan@Anbv.com"} ,
                        new GroupMember() { UserId = 3 , GroupMemberId = 1 ,UserName = "Shyan" , UserEmail = "Shan@Anbv.com"} ,
                        new GroupMember() { UserId = 4, GroupMemberId = 1,  UserName = "Aan", UserEmail = "Shan@Anbv.com" }
                    } },
                new Group(){Id = 1 , Name = "AzureCloudManagementGroup" , CreatedBy = 1, CreatedOn=DateTime.Today },
                new Group(){Id = 1 , Name = "HumanResourceManagementGroup" , CreatedBy = 1, CreatedOn=DateTime.Today }
            };
            return Json(new { data = groups });
        }
    }
}
