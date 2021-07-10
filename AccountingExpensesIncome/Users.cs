using System.Collections.Generic;

namespace AccountingExpensesIncome
{
     public class Users
     {
        public int Id { get; set; }
        public string Login { get; set; }
        public string FullName { get; set; }
        public bool Administrator { get; set; }
        public double Balance { get; set; }
        public List<Data> Data { get; set; }

        public bool UpdateBalance(double amount)
        {
            if ((Balance + amount) >= 0)
            {
                Balance += amount;
                return true;
            }
            else
                return false;
        }
    }
}
