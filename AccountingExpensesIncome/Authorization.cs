using System.Linq;

namespace AccountingExpensesIncome
{
    // класс авторизации пользователя
    class Authorization
    {
       // метод возвращает пользователя из таблицы "Users" по полю Login. В противном случае null.
       public static Users IsAuthorization(string username) 
       {
            using (DataContext context = new DataContext()) 
                return context.Users.Where(x => x.Login.Trim().ToLower().Contains(username.Trim().ToLower())).FirstOrDefault(); 
       }
    }
}
