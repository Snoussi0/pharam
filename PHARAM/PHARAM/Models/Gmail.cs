﻿    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PHARAM.Models
{
    public class Gmail
    {
        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}