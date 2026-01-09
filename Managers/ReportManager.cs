using Inventory_System_with_POS_for_UMVC_Canteen.Interfaces;
using Inventory_System_with_POS_for_UMVC_Canteen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Managers
{
    public class ReportManager
    {
        private readonly IReportRepository reportRepo;

        public ReportManager(IReportRepository reportRepo)
        {
            this.reportRepo = reportRepo;
        }

        public List<TransactionItem> GetSalesByProductDaily(DateTime date)
        {
            return reportRepo.GetSalesByProduct(date, date);
        }

        public List<TransactionItem> GetSalesByProductWeekly(DateTime startOfWeek)
        {
            return reportRepo.GetSalesByProduct(startOfWeek, startOfWeek.AddDays(6));
        }

        public List<TransactionItem> GetSalesByProductYearly(int year)
        {
            return reportRepo.GetSalesByProduct(new DateTime(year, 1, 1), new DateTime(year, 12, 31));
        }

        public List<TransactionItem> GetSalesByProductAllTime()
        {
            return reportRepo.GetSalesByProduct();
        }
        public List<TransactionItem> GetSalesByProductByDateRange(DateTime startDate, DateTime endDate)
        {
            return reportRepo.GetSalesByProduct(startDate, endDate);
        }
    }
}
