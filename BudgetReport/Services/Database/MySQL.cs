﻿//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

namespace BudgetReport.Services.Database
{
    internal class MySQL : IDatabase
    {
        string path = "../../../Assets/mysql.txt";
        List<string> lines;
        public MySQL()
        {
            this.CheckExist();
            lines = new List<string>();
        }

        public void Delete(int lineNumber)
        {
            this.lines = this.Read();
            lines.RemoveAt(lineNumber - 1);
            this.Write();
        }

        public void Insert(string data)
        {
            File.AppendAllText(path, data + "\n");
        }

        public void Update(int lineNumber, string newData)
        {
            this.lines = this.Read();
            lines[lineNumber - 1] = newData;
            this.Write();
        }

        public List<string> Read()
        {
            return File.ReadLines(path).ToList();
        }

        void Write()
        {
            File.WriteAllLines(path, lines);
        }

        public int Count()
        {
            return lines.Count;
        }

        void CheckExist()
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
        }
    }
}