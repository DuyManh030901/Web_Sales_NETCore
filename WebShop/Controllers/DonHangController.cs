using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebShop.Models;
using WebShop.ModelViews;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebShop.Controllers
{
    public class DonHangController : Controller
    {
        private readonly QLBHContext _context;
        public INotyfService _notyfService { get; }
        public DonHangController(QLBHContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }

        [Route("/chitiet/{id}.html", Name = ("chitiet"))]
        public IActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            try
            {
                //var taikhoanID = HttpContext.Session.GetString("CustomerId");
                //if (string.IsNullOrEmpty(taikhoanID)) return RedirectToAction("Login", "Accounts");
                //var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CustomerId == Convert.ToInt32(taikhoanID));
                //if (khachhang == null) return NotFound();
                var donhang = _context.Orders
                     .AsNoTracking()
                    .Include(x => x.TransactStatus)
                    .SingleOrDefault(m => m.OrderId == Convert.ToInt32(id));
                if (donhang == null)
                {
                    return NotFound();
                }
                var chitietdonhang = _context.OrderDetails
                    .AsNoTracking()
                    .Include(x => x.Product)
                    .Where(x => x.OrderId == donhang.OrderId)
                    .ToList();
                XemDonHang xemdonhang = new XemDonHang();
                xemdonhang.ChiTietDonHang = chitietdonhang;
                xemdonhang.DonHang = donhang;
                return View(xemdonhang);
                
            }
            catch 
            {
                return NotFound();
            }
        }
    }
}
