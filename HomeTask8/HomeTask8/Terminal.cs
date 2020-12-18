using HomeTask8.SystemCard.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask8
{
   public class Terminal 
    {
        public decimal Balance(ITerminalWihdrawal card)
        {
            return card.TerminalWithdrawal();
        }

        public void Deposit(ICashDeposit card)
        {
          
        }

        public void Payment (IPayment card)
        {

        }
        
        
    }
}
