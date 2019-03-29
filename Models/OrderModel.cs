using dotnet_core_theater.Models;
using System;
using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace dotnet_core_theater.Models
{
    public class OrderModel
    {
        [Key]
        public int OrderID { get; set; }
        public string BuyerID { get; set; }
        public string OrderTrackingID { get; set; }

        public ICollection<TicketModel> Tickets { get; set; }

        public OrderModel(int orderID)
        {

        }
        public OrderModel (string orderTrakingID)
        {

        }
        public OrderModel(string buyer, List<TicketModel> tickets)
        {
            BuyerID = buyer;
            Tickets = tickets;
            OrderTrackingID = Guid.NewGuid().ToString();
        }
    }
}