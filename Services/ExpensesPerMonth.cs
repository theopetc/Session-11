using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServiceCenterLibrary;

namespace Services
{
    internal class ExpensesPerMonth
    {
        public decimal SalaryExpenses()
        {
            var storageService = new StorageService();
            var serviceCenter = storageService.GetSeviceCenter();

            Manager manager = new Manager();
            Engineer engineer = new Engineer();
            var engineers = serviceCenter.Engineers;

            decimal expensesPerMonth = manager.SallaryPerMonth + engineers.Count * engineer.SallaryPerMonth;
            return expensesPerMonth;
        }
        public void IncomePerMonth() {
            var storageService = new StorageService();
            var serviceCenter = storageService.GetSeviceCenter();

            decimal incomeList = 0.0m;
            foreach (var transaction in serviceCenter.Transactions)
            {
                incomeList += transaction.TotalPrice;
            }            
        }
        public void MonthlyIncome()
        {
            var monthsToDate = Enumerable.Range(1, 12)
                                .Select(m => new DateTime(DateTime.Today.Year, m, 1))
                                .ToList();
        }


    }
}
