﻿using HomeTask8.SystemCard.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask8.SystemCard.Specific
{
    public class PlatinumCard : CommonCard, ICashWihdrawal, ICashDeposit
    {
        public PlatinumCard(string number, CardSecurity security, DateTime expirationDate, Customer owner, Bank emittent)
            : base(number, security, expirationDate, owner, emittent)
        {
        }

        public decimal AtmWithdraw()
        {
            throw new NotImplementedException();
        }

        public override decimal DepositCommission(decimal amount)
        {
            if (amount > 10_000)
            {
                return base.DepositCommission(amount) / 2;
            }
            else
            {
                return base.DepositCommission(amount) + 15;
            }
        }

        public override decimal WithdrawCommission(decimal amount)
        {
            return 20;
        }
    }
}
