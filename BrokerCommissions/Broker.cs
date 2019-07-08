using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerCommissions
{
    public class Broker
    {
        public Int32? CaseId { get; set; }
        public string BrokerName { get; set; }
        public string CaseValue { get; set; }
        public decimal BaseBonus { get; set; } = 125m;
        public decimal TotalCommission { get; set; }

        //public Broker(Int32 caseid, string brokername, string casevalue)
        //{
        //    this.CaseId = caseid;
        //    this.BrokerName = brokername;
        //    this.CaseValue = casevalue;
        //}


        // Method to Calculate All the Bonuses
        public decimal BonusCalculation(string rowValue, decimal perAmount, decimal perOverAmount)
        {
            const decimal fixedBonus = 10;
            string temp = "";

            temp = rowValue;
            temp = temp.Replace("£", ""); // remove £ sign
            temp = temp.Replace("$", ""); // remove $ sign

            decimal Bonus = decimal.Parse(temp);
            Bonus = Bonus - perOverAmount; // presently £100,000 or £250,000
            Bonus = Bonus / perAmount; // presently 10,000 or 50,000 or 75,0000
            Bonus = Math.Floor(Bonus);


            Bonus = (Bonus * fixedBonus);
            if (Bonus < 0)
            {
                Bonus = 0;
            }
            return Bonus;
        }

        // Method to aggregate all the bonuses, including baseBonus (currentlt 125)
        public decimal TotalCommissionCalculation(decimal Tbonus1, decimal Tbonus2, decimal Tbonus3)
        {
            decimal TotCommission = 0;
            TotCommission = TotCommission + BaseBonus + Tbonus1 + Tbonus2 + Tbonus3;

            return TotCommission;
        }
    }
}
