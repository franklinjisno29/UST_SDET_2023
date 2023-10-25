using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class LifeInsurance : Insurance_Policy
    {
        public LifeInsurance(string? policyName, int policyId, double premiumAmount,int age) : base(policyName, policyId, premiumAmount)
        {
            Age = age;
        }

        public int Age { get; set; }

        public override double CalculatePremium()
        {
            if (Age > 60)
                return PremiumAmount += (PremiumAmount * .2);
            else if (Age < 60 && Age > 40)
                return PremiumAmount += (PremiumAmount * .1);
            else return PremiumAmount += (PremiumAmount * .05);
        }
    }
}
