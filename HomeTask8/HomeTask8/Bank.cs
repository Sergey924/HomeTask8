using HomeTask8.SystemCard;
using HomeTask8.SystemCard.Specific;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask8
{
    public class Bank
    {
        public string Name { get; set; }
        public long CardsEmitted { get; set; }
        public decimal Funds { get; set; }

        public Bank(string name, decimal funds)
        {
            Name = name;
            Funds = funds;
        }

        public void ReceiveFunds(decimal commission)
        {
            Funds += commission;
        }

        public CommonCard EmitCard(string cardType, Customer customer)
        {
            CommonCard card;
            switch (cardType)
            {
                case "sav":
                    card = new SavingsCard(Guid.NewGuid().ToString(), new CardSecurity(), DateTime.Now.AddYears(5), customer, this);
                    break;
                case "univ":
                    card = new UniversalCard(Guid.NewGuid().ToString(), new CardSecurity(), DateTime.Now.AddYears(5), customer, this);
                    break;
                case "plat":
                    card = new PlatinumCard(Guid.NewGuid().ToString(), new CardSecurity(), DateTime.Now.AddYears(5), customer, this);
                    break;
                default: throw new ArgumentException("Wrong card type");
            }
            CardsEmitted++;
            return card;
        }
    }
}
