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
            var managers = serviceCenter.Managers;

            decimal expensesPerMonth = managers.Count*manager.SallaryPerMonth + engineers.Count * engineer.SallaryPerMonth;
            return expensesPerMonth;
        }
        public decimal IncomePerMonth() {
            var storageService = new StorageService();
            var serviceCenter = storageService.GetSeviceCenter();

            decimal incomeList = 0.0m;
            foreach (var transaction in serviceCenter.Transactions)
            {
                incomeList += transaction.TotalPrice;
            }
            return incomeList;
        }
        public decimal MonthlyIncome()
        {
            decimal monthlyLedger = IncomePerMonth() - SalaryExpenses();
            return monthlyLedger;
        }


    }
}
