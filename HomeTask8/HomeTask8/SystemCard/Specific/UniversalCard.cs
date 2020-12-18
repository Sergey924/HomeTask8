using HomeTask8.SystemCard.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask8.SystemCard.Specific
{
    public class UniversalCard : CommonCard, ICashWihdrawal
    {
        public UniversalCard(string number, CardSecurity security, DateTime expirationDate, Customer owner, Bank emittent)
            : base(number, security, expirationDate, owner, emittent)
        {
        }

        public decimal AtmWithdraw()
        {
            throw new NotImplementedException();
        }

        public override decimal DepositCommission(decimal amount)
        {
            return base.DepositCommission(amount);
        }

        public override decimal WithdrawCommission(decimal amount)
        {
            return amount * 0.005m;
        }
    }
}
