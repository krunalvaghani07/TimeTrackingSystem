using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTrackingSystem.Common
{
    public enum UserRoles
    {
        All = 1,
        SystemAdmin = 2,
        ProjectAdmin = 3,
        TeamMember = 4,
        Finance = 5
    }
}
