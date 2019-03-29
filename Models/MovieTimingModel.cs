using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace dotnet_core_theater.Models
{
    public class MovieTimingModel
    {
        public int MovieTimingID { get; set; }
        public int MovieID { get; set; }
        public int TheaterID { get; set; }
        public DateTime Timing { get; set; }
    }
}