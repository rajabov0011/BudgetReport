//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using BudgetReport.Services.Database;

namespace BudgetReport.Services.Report
{
    internal class BudgetReporT : IReport
    {
        private IDatabase database;
        public BudgetReporT()
        {
            this.database = new MySQL();
        }

        public List<string> Open(string data)
        {
            return this.database.Read();
        }

        public void Save(string data)
        {
            this.database.Insert(data);
        }
    }
}