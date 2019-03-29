using dotnet_core_theater.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;

namespace dotnet_core_theater.Models
{
    public class HallModel
    {
        [Key]
        public int HallId { get; set; }
        public string HallNumber { get; set; }
        public int RowCap { get; set; }
        public int SeatCap { get; set; } //Per Row

        public List<ScheduleModel> ActualSchedule { get; set; }

        public HallModel(int hallID)
        {
            //Retreive data from database based on HallID

            HallModel hall = GetHallByID(hallID);
            HallId = hall.HallId;
            HallNumber = hall.HallNumber;
            RowCap = hall.RowCap;
            SeatCap = hall.SeatCap;
            // GetActualSchedule(HallId);
        }

        public HallModel(string hallNumber, int rowCap, int seatCap)
        {
            HallNumber = hallNumber;
            RowCap = rowCap;
            SeatCap = seatCap;
        }

        public static List<ScheduleModel> GetActualSchedule(int hallID)
        {
            List<ScheduleModel> actualSchedules = new List<ScheduleModel>();

            //Get latest schedule of this hall and ma


            return actualSchedules;
        }

        public static HallModel GetHallByID(int hallID)
        {
            ApplicationDbContext db = new ApplicationDbContext(new Microsoft.EntityFrameworkCore.DbContextOptions<ApplicationDbContext>());
            return db.Halls.Where(h => h.HallId == hallID).SingleOrDefault();
        }

        public static Dictionary<int, List<int>> GetSeats(HallModel hall)
        {
            Dictionary<int, List<int>> seats = new Dictionary<int, List<int>>();

            for (int i = 1; i < hall.RowCap + 1; i++)
            {
                seats.Add(i, new List<int>());
                for (int j = 1; j < hall.SeatCap + 1; j++)
                {
                    seats[i].Add(j);
                }
            }

            return seats;
        }
    }
}