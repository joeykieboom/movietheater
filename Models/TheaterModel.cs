using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_core_theater.Models
{
    public class TheaterModel
    {
        [Key]
        public int TheaterID { get; set; }
        public string TheaterName { get; set; }
        public string TheaterLocation { get; set; }
    }
}
