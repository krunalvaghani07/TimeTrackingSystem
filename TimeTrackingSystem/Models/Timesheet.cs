using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTrackingSystem.Models
{
    public class Timesheet
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string UserName { get; set; }
        public string GroupName { get; set; }
        public DateTime RecordDate { get; set; }
        public TimeSpan Timespent { get; set; }

    }
}
