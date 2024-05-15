﻿using System;
using System.Collections.Generic;

namespace ZH3_gyak.Models
{
    public partial class Employement
    {
        public Employement()
        {
            Instructors = new HashSet<Instructor>();
        }

        public string EmployementId { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<Instructor> Instructors { get; set; }
    }
}