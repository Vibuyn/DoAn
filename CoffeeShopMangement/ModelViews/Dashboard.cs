using CoffeeShopMangement.Models;
using System;
using System.Collections.Generic;

namespace CoffeeShopMangement.ModelViews
{
    public class DashboardBestSeller
    {
        public int Count { get; set; }
        public Product Product { get; set; }
    }
    public class DashboardRevenueDayMonthYear
    {
        public int Month { get; set; }
        public int PreviousMonth { get; set; }
        public int Today { get; set; }
        public int Yesterday { get; set; }
        public int Year { get; set; }
        public int PreviousYear { get; set; }
        public int Total { get; set; }
        public double PercentToday { get; set; }
        public double PercentMonth { get; set; }
        public double PercentYear { get; set; }
    }
    public class Dashboard
    {
        public List<Order> RecentOrder { get; set; }
        public List<DashboardBestSeller> BestSeller { get; set; }
        public DashboardRevenueDayMonthYear DayMonthYear { get; set; }
        public List<(DateTime,int)> CountOrders { get; set; }
        public List<(DateTime, int)> SumOrders { get; set; }
        public List<DashboardBestSeller> ProductsOrderToday { get; set; }
        public string[] ListColor { get; set; }
    }
}
