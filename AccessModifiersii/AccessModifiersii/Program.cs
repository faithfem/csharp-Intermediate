using Amazon;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersii
{
    /*public class GoldCustomer : Customer
    {

        public void OfferVoucher()
        {
            this.
        }
    }*/

    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(); //Need to move customer class to a separate assembly
            Amazon.RateCalculator calculator = new RateCalculator();

            System.Console.WriteLine();
        }
    }
}
