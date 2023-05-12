using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTrackingSystem.Common;

namespace TimeTrackingSystem.Models
{
    public class Users
    {
        public int Id { get; set; }
        public int UserRoleId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public UserRoles UserRole { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string RoleName { get { return this.UserRole.ToString(); } }
    }
}
