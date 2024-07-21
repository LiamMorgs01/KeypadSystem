using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class CompanyStats
    {
        public List<CompanyWeekGraphStats> companyWeekGraphStats {  get; set; }

        public List<CompanyDayGraphStats> companyDayGraphStats { get; set; }
        public CompanyDashStats companyDashStats { get; set; }
    }

    public class CompanyDashStats
    {
        public int LastHoursCustomers { get; set; }
        public int LastDaysCustomers { get; set; }
        public int LastWeeksCustomers { get; set; }
    }
    public class CompanyWeekGraphStats
    {
        public DateTime Date { get; set; }
        public int CustomerCount { get; set; }
    }

    public class CompanyDayGraphStats
    {
        public DateTime Hour { get; set; }
        public int CustomerCount { get; set; }
    }

}
