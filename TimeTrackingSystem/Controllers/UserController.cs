using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTrackingSystem.Common;
using TimeTrackingSystem.Models;

namespace TimeTrackingSystem.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult GetUsers()
        {
            List<Users> userList = new List<Users>() {
                new Users() { Id = 1 , Email = "abc.xys@organisation.com" , Name = "abc" , UserRole = UserRoles.SystemAdmin } ,
                new Users() { Id = 2 , Email = "abc.xys@organisation.com" , Name = "Raj", UserRole = UserRoles.Finance } ,
                new Users() { Id = 3 , Email = "abc.xys@organisation.com" , Name = "Taj", UserRole = UserRoles.TeamMember } ,
                new Users() { Id = 4 , Email = "abc.xys@organisation.com" , Name = "Ram", UserRole = UserRoles.ProjectAdmin } ,
                new Users() { Id = 5 , Email = "abc.xys@organisation.com" , Name = "shyam", UserRole = UserRoles.SystemAdmin } ,
                new Users() { Id = 5 , Email = "abc.xys@organisation.com" , Name = "shyam", UserRole = UserRoles.SystemAdmin } ,
                new Users() { Id = 5 , Email = "abc.xys@organisation.com" , Name = "shyam", UserRole = UserRoles.SystemAdmin } ,
                new Users() { Id = 5 , Email = "abc.xys@organisation.com" , Name = "shyam", UserRole = UserRoles.SystemAdmin } ,
                new Users() { Id = 5 , Email = "abc.xys@organisation.com" , Name = "shyam", UserRole = UserRoles.SystemAdmin } ,
                new Users() { Id = 5 , Email = "abc.xys@organisation.com" , Name = "shyam", UserRole = UserRoles.SystemAdmin } ,
                new Users() { Id = 5 , Email = "abc.xys@organisation.com" , Name = "shyam", UserRole = UserRoles.SystemAdmin } ,
                new Users() { Id = 5 , Email = "abc.xys@organisation.com" , Name = "shyam", UserRole = UserRoles.SystemAdmin } ,
                new Users() { Id = 5 , Email = "abc.xys@organisation.com" , Name = "shyam", UserRole = UserRoles.SystemAdmin } ,
                new Users() { Id = 5 , Email = "abc.xys@organisation.com" , Name = "shyam", UserRole = UserRoles.SystemAdmin } ,
                new Users() { Id = 5 , Email = "abc.xys@organisation.com" , Name = "shyam", UserRole = UserRoles.SystemAdmin } ,
                new Users() { Id = 5 , Email = "abc.xys@organisation.com" , Name = "shyam", UserRole = UserRoles.SystemAdmin } ,
                new Users() { Id = 5 , Email = "abc.xys@organisation.com" , Name = "shyam", UserRole = UserRoles.SystemAdmin } ,
                new Users() { Id = 6 , Email = "abc.xys@organisation.com" , Name = "kumar", UserRole = UserRoles.TeamMember } ,
            };
            return Json(new { data = userList });
        }
    }
}
