using CoffeeShopMangement.Models;
using CoffeeShopMangement.ModelViews;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopMangement.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        private readonly CoffeeShopManagementContext _context;

        public HomeController(CoffeeShopManagementContext context)
        {
            _context = context;
        }
        [Area("Admin")]
        public async Task<IActionResult> Index()
        {
            // đơn hàng gần đây
            var dataRecentOrder = await _context.Orders.AsNoTracking()
                .Include(c => c.Customer)
                .Include(t => t.TransactStatus)
                .OrderByDescending(t => t.OrderDate)
                .Take(6)
                .ToListAsync();
            // các mặt hàng bán chạy
            var topProductsQuery = _context.OrderDetails
                .GroupBy(od => od.ProductId)
                .Select(g => new
                {
                    ProductId = g.Key,
                    CountOrders = g.Count()
                })
                .OrderByDescending(x => x.CountOrders)
                .Take(5);

            var dataBestSeller = _context.Products
                .Join(topProductsQuery,
                    product => product.ProductId,
                    topProduct => topProduct.ProductId,
                    (product, topProduct) => new DashboardBestSeller
                    {
                        Count = topProduct.CountOrders,
                        Product = product
                    })
                .ToList();
            // doanh số theo hôm nay, tháng này, năm nay, tất cả
            var todayRevenue = await _context.Orders
                .Where(x => x.OrderDate.Value.Date == DateTime.Now.Date)
                .SumAsync(x => x.TotalMoney);
            var yesterDayRevenue = await _context.Orders
                .Where(x => x.OrderDate.Value.Date == DateTime.Now.AddDays(-1).Date)
                .SumAsync(x => x.TotalMoney);
            float percentToday = yesterDayRevenue == 0 ? 1 : (todayRevenue - yesterDayRevenue) / (float)yesterDayRevenue;
            double revPercentTodayDay = Math.Round(percentToday * 100, 2);
            var monthRevenue = await _context.Orders
                .Where(x => x.OrderDate.Value.Month == DateTime.Now.Month)
                .SumAsync(x => x.TotalMoney);
            var previousMonthRevenue = await _context.Orders
                .Where(x => x.OrderDate.Value.Month == DateTime.Now.AddMonths(-1).Month
                && x.OrderDate.Value.Year == DateTime.Now.AddMonths(-1).Year)
                .SumAsync(x => x.TotalMoney);
            float percentMonth = previousMonthRevenue == 0 ? 1 : (monthRevenue - previousMonthRevenue) / (float)previousMonthRevenue;
            double revPercentMonth = Math.Round(percentMonth * 100, 2);
            var yearRevenue = await _context.Orders
                .Where(x => x.OrderDate.Value.Year == DateTime.Now.Year)
                .SumAsync(x => x.TotalMoney);
            var previousYearRevenue = await _context.Orders
                .Where(x => x.OrderDate.Value.Year == DateTime.Now.Year - 1)
                .SumAsync(x => x.TotalMoney);
            float percentYear = previousYearRevenue == 0 ? 1 : (yearRevenue - previousYearRevenue) / (float)previousYearRevenue;
            double revPercentYear = Math.Round(percentYear * 100, 2);
            var totalRevenue = await _context.Orders
                .SumAsync(x => x.TotalMoney);

            var resultRevenueDayMonthYear = new DashboardRevenueDayMonthYear()
            {
                Month = monthRevenue,
                PreviousMonth = previousMonthRevenue,
                PreviousYear = previousYearRevenue,
                Year = yearRevenue,
                Today = todayRevenue,
                Yesterday = yesterDayRevenue,
                Total = totalRevenue,
                PercentMonth = revPercentMonth,
                PercentYear = revPercentYear,
                PercentToday = revPercentTodayDay
            };
            //số đơn hàng trong 6 ngày gần đây
            var dataCountOrders = new List<(DateTime, int)>();
            for (int i = 0; i < 6; i++)
            {
                var date = DateTime.Now.AddDays(-i).Date;
                var count = await _context.Orders.Where(x => x.OrderDate.Value.Date == date).CountAsync();
                dataCountOrders.Add((date, count));
            }
            // doanh số trong 6 ngày gần đây
            var dataSumOrders = new List<(DateTime, int)>();
            for (int i = 0; i < 6; i++)
            {
                var date = DateTime.Now.AddDays(-i).Date;
                var sum = await _context.Orders.Where(x => x.OrderDate.Value.Date == date).Select(x => x.TotalMoney).SumAsync();
                dataSumOrders.Add((date, sum));
            }

            // các mặt hàng bán trong hôm nay
            var dataProductsOrderToday = _context.OrderDetails.Where(x => x.Order.OrderDate.Value.Date == DateTime.Now.Date)
                .Include(o => o.Order)
                .Include(p => p.Product)
                .GroupBy(x => x.ProductId)
                .Select(x => new { ProductId = x.Key, Count = x.Count() });

            var listProductOrderToday = await _context.Products
                .Join(dataProductsOrderToday,
                    product => product.ProductId,
                    topProduct => topProduct.ProductId,
                    (product, topProduct) => new DashboardBestSeller
                    {
                        Count = topProduct.Count,
                        Product = product
                    })
                .AsNoTracking()
                .OrderByDescending(x => x.Count)
                .Take(10)
                .ToListAsync();
            //model
            var data = new Dashboard()
            {
                RecentOrder = dataRecentOrder,
                BestSeller = dataBestSeller,
                DayMonthYear = resultRevenueDayMonthYear,
                CountOrders = dataCountOrders.OrderBy(x => x.Item1).ToList(),
                SumOrders = dataSumOrders.OrderBy(x => x.Item1).ToList(),
                ProductsOrderToday = listProductOrderToday,
                ListColor = new string[]{
                    "#9cacff"
                , "#9cfff2"
                , "#51ff47"
                , "#f3ff47"
                , "#ffaf47"
                , "#ff4747"
                , "#af47ff"
                , "#a08db5"
                , "#b5aa8d"
                , "#d9ffdb"
                }
            };

            return View(data);
        }
    }
}
