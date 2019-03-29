using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;

using System.Web;

namespace dotnet_core_theater.Models
{
    public class TicketModel
    {
        [Key]
        public int TicketID { get; set; }
        public int TicketRow { get; set; }
        public int TicketSeat { get; set; }
        public int OrderID { get; set; }
        public int ScheduleID { get; set; }
        public double Price { get; set; }
        public Guid TrackingCode { get; set; }
        public ScheduleModel Schedule { get; set; }
        public OrderModel OrderModel { get; set; }

        public TicketModel(int ticketID)
        {
            TicketID = ticketID;
            Price = 9.00;
        }

        public TicketModel(int ticketRow, int ticketSeat, ScheduleModel schedule) 
        {
            TicketRow = ticketRow;
            TicketSeat = ticketSeat;
            Schedule = schedule;
            TrackingCode = Guid.NewGuid();
            Price = 9.00;
        }

        void GetTicket()
        {
            
        }

        void PrintTicket()
        {

        }
        

    
        public  static List<TicketModel> GetTicketsByOrderID(int OrderId)
        {
            return null;
        }
        public static List<TicketModel> GetTicketsByHallID(int OrderId)
        {
            return null;
        }
    }
}