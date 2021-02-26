
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace BankAccount.Controller
{
    public class Operations
    {
        Dictionary<int  , int > users= new Dictionary<int, int>();      

        public void DeleteAccount(int index)
        {
            users.Remove(index);

        }
        public int ShowInventory(int id)
        {
            return users[id];
        }

        public void DepositMoneyToAccount(int index, int money)
        {          
            users[index] += money;
        }
        public int CheckAccountExist(int deposit)
        {
           
            int index = users.Where(x => x.Key == deposit).Select(x => x.Key).FirstOrDefault();         
            return index;
        }  
        
        public void CreateNewUser( int nationalCard , int inventory) {

            users.Add( nationalCard,  inventory);                   
        }
        public int GetUser(int index)
        {
            return users[index];
        }

        public bool CheckUserAge(int age)
        {
            bool result = true;
            if (age < 18)
            {
                result = false;
            }
            return result;
        }
    }
}
