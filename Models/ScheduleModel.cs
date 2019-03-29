using dotnet_core_theater.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace dotnet_core_theater.Models
{
    public class ScheduleModel
    {
        [Key]
        public int ScheduleID { get; set; }
        public int MovieID { get; set; }
        public DateTime Starttime { get; set; }
        public DateTime EndTime { get; set; }
        public string SeatsTaken { get; set; }
        public int HallID { get; set; }
        public HallModel Hall { get; set; }

        public List<int[]> GetSeats()
        {
            if (string.IsNullOrEmpty(SeatsTaken))
            {
                return new List<int[]>();
            }
            return JsonConvert.DeserializeObject<List<int[]>>(SeatsTaken);
        }

        public void SetSeats(int[] seat)
        {
            List<int[]> seats = GetSeats();
            seats.Add(seat);
            seats = seats.OrderBy(x => x[0]).ThenBy(x => x[1]).ToList();
            SeatsTaken = JsonConvert.SerializeObject(seats);
        }

        public Dictionary<int, List<int>> CheckSeats()
        {
            Dictionary<int,List<int>> totalSeats = HallModel.GetSeats(this.Hall);

            foreach (KeyValuePair<int,List<int>> row in totalSeats)
            {
                foreach (int[] item in GetSeats())
                {
                    if (row.Key == item[0])
                    {
                        row.Value.Remove(item[1]);
                    }
                }
            }

            return totalSeats;    
        }

        public Dictionary<int,List<Tuple<int,bool>>> ViewSeats()
        {
            Dictionary<int, List<Tuple<int, bool>>> availableSeats = new Dictionary<int, List<Tuple<int, bool>>>();
            Dictionary<int, List<int>> sTaken = CheckSeats();
            foreach (KeyValuePair<int,List<int>> s in CheckSeats())
            {
                availableSeats.Add(s.Key, new List<Tuple<int, bool>>());
                foreach (int _s in s.Value)
                {
                    availableSeats[s.Key].Add(new Tuple<int, bool>(_s, true));
                }
            }

            Dictionary<int, List<Tuple<int, bool>>> seats = new Dictionary<int, List<Tuple<int, bool>>>();

            for (int i = 0; i < Hall.RowCap; i++)
            {
                seats.Add(i + 1, new List<Tuple<int, bool>>());
                for (int j = 0; j < Hall.SeatCap; j++)
                {
                    if (availableSeats[i+1].Contains(new Tuple<int, bool>(j + 1, true)))
                    {
                        seats[i + 1].Add(new Tuple<int, bool>(j + 1, true));
                    }
                    else
                    {
                        seats[i + 1].Add(new Tuple<int, bool>(j + 1, false));
                    }
                }
            }
            return seats;
        }

        //public ScheduleModel(int scheduleID)
        //{
        //    ScheduleID = scheduleID;

        //    //Retrieve Data from database and init the model
        //}

        //public ScheduleModel(MovieModel movie, HallModel hall, DateTime starttime, DateTime endTime)
        //{
        //    Movie = movie;

        //    Hall = hall;
        //    Starttime = starttime;
        //    EndTime = endTime;
        //    //Build Model and ready to save in database. 
        //}

        //public static bool IsScheduleConflicted(ScheduleModel potentialSchedule)
        //{
        //    //Checks If the scheduled movie is conflicted with another film in the same hall at the same time. 
        //    //If not return false; if conflicted return true;

        //    return false;
        //}
    }
}