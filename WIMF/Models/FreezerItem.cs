﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIMF.Models
{
    internal class FreezerItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime? DateAdded { get; set; } = DateTime.Now;
        public DateTime? BestBeforeDate { get; set; }
    }
}
