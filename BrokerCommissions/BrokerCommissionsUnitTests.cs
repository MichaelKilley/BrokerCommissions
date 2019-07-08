using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerCommissions
{
    // Base Commissions £125 per Case
    //BrokerName	CaseId	CaseValue		 bonus1 				 bonus2 				 bonus3 
    // David          2     £607,947.84       £500                    £70                      £40

    [TestFixture]
    class BrokerCommissionsUnitTests
    {
        [TestCase] // Bonus 1
        public void BonusTest1()
        {
            Broker Bonus1 = new Broker();
            Assert.AreEqual(500m, Bonus1.BonusCalculation("607,947.84", 10000, 100000));
        }

        [TestCase] // Bonus 2
        public void BonusTest2()
        {
            Broker Bonus1 = new Broker();
            Assert.AreEqual(70, Bonus1.BonusCalculation("607,947.84", 50000, 250000));
        }

        [TestCase] // Bonus 3
        public void BonusTest3()
        {
            Broker Bonus1 = new Broker();
            Assert.AreEqual(40, Bonus1.BonusCalculation("607,947.84", 75000, 250000));
        }

        [TestCase] // Total Commission  (base + Bonus1 + Bonus2 + Bonus3)
        public void TotalCommission()
        {
            Broker TotalCommission = new Broker();
            Assert.AreEqual(735, TotalCommission.TotalCommissionCalculation(500, 70, 40));
        }


    }
}
