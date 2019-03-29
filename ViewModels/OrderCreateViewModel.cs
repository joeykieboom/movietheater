using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_core_theater.Models;
namespace dotnet_core_theater.ViewModels
{
    public class OrderCreateViewModel
    {
        public MovieModel MovieModel { get; set; }

        public List<ScheduleModel> SchedulesModel { get; set; }

        public OrderModel OrderModel { get; set; }

    }
}
