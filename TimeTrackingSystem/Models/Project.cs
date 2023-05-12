using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTrackingSystem.Models
{
    public class Project
    {
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public bool IsActive { get; set; }
        public List<ProjectMember> ProjectMembers { get; set; }
    }
    public class ProjectMember
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int GroupId { get; set; }
        public string UserName { get; set; }
        public string GroupName { get; set; }
        public string UserEmail { get; set; }
    }
}
