﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class OnlineCourse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TrainingInstitiution { get; set; }
        public string Details { get; set; }
    }
}