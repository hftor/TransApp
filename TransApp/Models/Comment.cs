﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TransApp.Models
{
    public class Comment
    {
        public int cID { get; set; }
        public int uID { get; set; }
        public int tID { get; set; }
        public string commentText { get; set; }
        public DateTime commentTime { get; set; }
    }
}