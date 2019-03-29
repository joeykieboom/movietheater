using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_core_theater.Models;
namespace dotnet_core_theater.ViewModels
{
    public class TicketViewModel
    {
        public OrderModel OrderModel { get; set; }

        public double Total { get; set; }
    }
}
