﻿using LareenCafe.Api.VerticalSlicing.Data.Entities;
using System.Data;

namespace Lareen_Cafe.VerticalSlicing.Data.Entities
{
    public class UserRole : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
