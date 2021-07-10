using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;

namespace AccountingExpensesIncome
{
    // класс для работы с Active Directory
    class ActiveDirectory
    {
        // метод получения списка пользователей из Active Directory 
        public static List<string> GetUsersActiveDirectory() 
        {
            var users = new List<string>();
            // "domain" - доменное имя текущего домена
            using (var context = new PrincipalContext(ContextType.Domain, "domain"))
            {
                using (var searcher = new PrincipalSearcher(new UserPrincipal(context)))
                {
                    foreach (var result in searcher.FindAll())
                        users.Add((result.GetUnderlyingObject() as DirectoryEntry).Properties["userPrincipalName"].Value.ToString());
                }
            }
            return users;
        }
    }
}
