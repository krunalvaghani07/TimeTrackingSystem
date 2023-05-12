using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTrackingSystem.Models
{
    public class Group
    {
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public int GroupLeaderId { get; set; }
        public string Name { get; set; }
        public string LeaderName { get; set; }
        public DateTime CreatedOn { get; set; }
        public List<GroupMember> GroupMembers { get; set; }
        public int MemberCount { get { if (this.GroupMembers != null) { return this.GroupMembers.Count; } else { return 0; } } }
    }
    public class GroupMember
    {
        public int GroupMemberId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
    }
}
