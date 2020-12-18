using HomeTask8.SystemCard.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask8
{
    public class Atm 
        
    {
        public decimal Withdraw(ICashWihdrawal card)
        {
            return card.AtmWithdraw();
        }
    }
}
