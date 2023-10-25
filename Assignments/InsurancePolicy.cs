using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class InsurancePolicy
    {
        public InsurancePolicy(string? policyName, int policyId, double premiumAmount)
        {
            PolicyName = policyName;
            PolicyId = policyId;
            PremiumAmount = premiumAmount;
        }

        public string? PolicyName { get; set; }
        public int PolicyId { get; set; }
        public double PremiumAmount { get; set; }
        public void RenewPolicy(double newPremium)
        {
            PremiumAmount = newPremium;
            Console.WriteLine("new premium: {0}", PremiumAmount);
            Console.WriteLine("Premium amount updated");
        }
        public void RenewPolicy()
        {
            PremiumAmount += (PremiumAmount * .1);
            Console.WriteLine("new premium: {0}", PremiumAmount);
            Console.WriteLine("Premium amount increased 10%");

        }
    }
}
