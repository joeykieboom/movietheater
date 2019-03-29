using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using dotnet_core_theater.Data;
using dotnet_core_theater.Models;
using dotnet_core_theater.ViewModels;
using dotnet_core_theater.Classes;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using System.Collections.Specialized;
using Microsoft.Extensions.Primitives;

namespace dotnet_core_theater.Controllers
{
    public class OrderModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrderModelsController(ApplicationDbContext context)
        {
            _context = new ApplicationDbContext(new DbContextOptions<ApplicationDbContext>());
        }

        // GET: OrderModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.Orders.ToListAsync());
        }

        // GET: OrderModels/Details/5
        public async Task<IActionResult> Details()
        {
            return View();
        }

        public async Task<IActionResult> DetailsTicket(string trackingID)
        {
            ApplicationDbContext db = new ApplicationDbContext(new DbContextOptions<ApplicationDbContext>());
            if (trackingID == null)
            {
                return NotFound();
            }

            var orderModel = await db.Orders
                .FirstOrDefaultAsync(m => m.OrderTrackingID == trackingID);

            int x = db.Orders.Where(m => m.OrderTrackingID == trackingID).Select(t => t.OrderID).Single();

            orderModel.OrderID = x;
            if (orderModel == null)
            {
                return NotFound();
            }
            List<TicketModel> tickets = db.Tickets.Where(t => t.OrderID == orderModel.OrderID).ToListAsync().Result;

            double  total = 0.0;
            foreach (TicketModel ticket in tickets)
            {
                ticket.Schedule = db.Schedules.Where(s => s.ScheduleID == ticket.ScheduleID).Single();
                total += ticket.Price;
            }
            orderModel.Tickets = tickets;

            TicketViewModel ticketViewModel = new TicketViewModel() { OrderModel = orderModel, Total = total };

            return View("TicketView", ticketViewModel);
        }


        // GET: OrderModels/Create
        public IActionResult Create(int? movieID)
        {
            ApplicationDbContext db = new ApplicationDbContext(new DbContextOptions<ApplicationDbContext>());
            MovieModel movie = MovieModel.GetModelByID(Convert.ToInt32(movieID));
            List<ScheduleModel> schedule = db.Schedules.Where(s => s.MovieID == Convert.ToInt32(movieID)).Where(s => s.Starttime.Date == DateTime.Now.Date).Include(h => h.Hall).ToListAsync().Result;
            OrderCreateViewModel model = new OrderCreateViewModel() { MovieModel = movie, SchedulesModel = schedule};
            return View(model);
        }

        // POST: OrderModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromForm]int amount,[FromForm] int scheduleID)
         {
            ApplicationDbContext db = new ApplicationDbContext(new DbContextOptions<ApplicationDbContext>());
            List<TicketModel> tickets = new List<TicketModel>();
            double total = 0.0;
            ScheduleModel schedule = db.Schedules.Where(s => s.ScheduleID == scheduleID).Include(h=>h.Hall).Single();
            var nvc = Request.Form.Where(v=>v.Value == "on").ToList();

            foreach (var item in nvc)
            {
                string[] RowSeatArr = item.Key.Split('-');
                int row = Convert.ToInt32(RowSeatArr[0]);
                int seat = Convert.ToInt32(RowSeatArr[1]);

                TicketModel ticket = new TicketModel(row, seat, schedule);
                tickets.Add(ticket);
                schedule.SetSeats(new int[] { ticket.TicketRow, ticket.TicketSeat });
                total += ticket.Price;
            }

            Models.UserModel userModel = db.Users.Where(u => u.Id == User.FindFirst(ClaimTypes.NameIdentifier).Value).SingleOrDefault();
            
            OrderModel orderModel = new OrderModel(userModel.Id, tickets);

            if (orderModel != null)
            {
                db.Update(schedule);
                await db.AddAsync(orderModel);
                await db.SaveChangesAsync();
                
                TicketViewModel ticketViewModel = new TicketViewModel() { OrderModel = orderModel, Total = total };
            
                return View("TicketView", ticketViewModel);
            }
            return View("TicketView", orderModel);
        }

        // GET: OrderModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderModel = await _context.Orders.FindAsync(id);
            if (orderModel == null)
            {
                return NotFound();
            }
            return View(orderModel);
        }

        // POST: OrderModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderID,OrderTrackingID")] OrderModel orderModel)
        {
            if (id != orderModel.OrderID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderModelExists(orderModel.OrderID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(orderModel);
        }

        // GET: OrderModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderModel = await _context.Orders
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (orderModel == null)
            {
                return NotFound();
            }

            return View(orderModel);
        }

        // POST: OrderModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orderModel = await _context.Orders.FindAsync(id);
            _context.Orders.Remove(orderModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderModelExists(int id)
        {
            return _context.Orders.Any(e => e.OrderID == id);
        }

        public bool CheckAvailable(ScheduleModel scheduleModel, int amount)
        {
            return false;
        }

        private KeyValuePair<int,List<int>>? SelectSeat(int amount, Dictionary<int,List<int>> availableSeats)
        {
            List<int> selected = new List<int>();
            foreach (KeyValuePair<int,List<int>> row in availableSeats)
            {
                selected = ContainSequence(row.Value, amount);

                if (selected.Count == amount)
                {
                    return new KeyValuePair<int, List<int>>(row.Key, selected);
                }
            }
            return null; 
        }
        private List<int> ContainSequence(List<int> set, int minSequence)
        {
            set = set.Distinct().OrderBy(o => o).ToList();

            int match = 0;
            List<int> matches = new List<int>();
            if (set.Count >= minSequence)
                for (int x = 0; x < set.Count; x++)
                {
                    if (x + 1 <= set.Count - 1)
                        if (set[x] + 1 == set[x + 1])
                        {
                            matches.Add(set[match]);
                            match += 1;
                        }
                        else if (set[x] - 1 == set[x - 1])
                        {
                            match += 1;
                        }
                        else
                        {
                            matches.Clear();
                            match = 0;
                        }
                    else if (set[x] - 1 == set[x - 1])
                    { 
                        match += 1;
                    }
                    if (match >= minSequence)
                    {
                        return matches;
                    }
                }

            return matches;
        }
    }
}
