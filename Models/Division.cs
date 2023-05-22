﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeCademyCapstone.Models
{
    public class Division
    {
        public string ConferenceId { get; set; }
        public string DivisionId { get; set; }
        public string Name { get; set; }

        public Conference Conference { get; set; }
    }
}
