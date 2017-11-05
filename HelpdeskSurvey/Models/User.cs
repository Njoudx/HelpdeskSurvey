using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelpdeskSurvey.Models
{
    public class User
    {
        public int Id { get; set; }
        public string AljUser { get; set; }
        public int ComputerType { get; set; }
        public string Comment { get; set; }
    }
}