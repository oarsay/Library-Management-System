﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace LibraryData.Models
{
    public class BranchHours
    {
        public int Id { get; set; }
        public LibraryBranch Branch { get; set; }
        [Range(0,6)]
        public int DayOfWeek { get; set; } //0 to 6
        [Range(0,23)]
        public int OpenTime { get; set; } //0 to 23
        [Range(0,23)]
        public int CloseTime { get; set; } //0 to 23
    }
}
