﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloMVC.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public String Firstname { get; set; }

        public String Lastname { get; set; }

        public DateTime DOB { get; set; }
    }
}