//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

namespace BudgetReport.Services.Report
{
    internal interface IReport
    {
        List<string> Open(string data);
        void Save(string data);
    }
}