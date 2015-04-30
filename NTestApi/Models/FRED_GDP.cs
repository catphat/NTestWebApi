﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NTestApi.Controllers
{
    public class FRED_GDP
    {
        public Errors errors { get; set; }
        public int id { get; set; }
        public string source_name { get; set; }
        public string source_code { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string urlize_name { get; set; }
        public string display_url { get; set; }
        public string description { get; set; }
        public DateTime updated_at { get; set; }
        public string frequency { get; set; }
        public string from_date { get; set; }
        public string to_date { get; set; }
        public string[] column_names { get; set; }
        public bool _private { get; set; }
        public object type { get; set; }
        public bool premium { get; set; }
        public string data { get; set; }
    }

       public class Errors
    {
    }
}