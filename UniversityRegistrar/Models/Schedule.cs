using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityRegistrar.Models
{
    public class Schedule
    {
        public int ScheduleId { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
    }
}