using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using FitnessTrack.Common.Types;

namespace FitnessTrack.Core.Models
{
    public class User : IdentityUser
    {
        
        public string Address { get; set; }
        public Name Name { get; set; }
        
    }
    public class Role : IdentityRole
    {
        public Role() : base()
        {

        }
        public Role(string roleName)
        {
            Name = roleName;
        }
    }
}
