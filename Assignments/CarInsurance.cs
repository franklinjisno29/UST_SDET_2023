using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class CarInsurance : Insurance_Policy
    {
        public CarInsurance(string? policyName, int policyId, double premiumAmount,string? type) : base(policyName,policyId,premiumAmount)
        {
            Type = type;
        }

        public string? Type { get; set; }
        public override double CalculatePremium()
        {
            if (Type == "petrol")
                return PremiumAmount += (PremiumAmount * .02);
            else if (Type == "diesel")
                return PremiumAmount += (PremiumAmount * .04);
            else return PremiumAmount += (PremiumAmount * .06);

        }
    }
}
