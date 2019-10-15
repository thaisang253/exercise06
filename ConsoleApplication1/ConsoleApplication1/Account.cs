using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Account
    {
        private int MONEY;
        
         public Account(int amount)
    {
        MONEY = amount;
    }
         public void Desposit(int amount)
         {
             MONEY += amount;
         }    
    public void WithDraw(int amount)
    {
            MONEY -= amount;
    }
    public int balance()
    {
    return MONEY;
    }
   
        }
    }

   