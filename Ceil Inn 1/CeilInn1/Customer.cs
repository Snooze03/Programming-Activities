using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CeilInn1
{
    [Serializable]
    public class Customer
    {
        public string AccountNumber  { get; set; }
        public string FirstName      { get; set; }
        public string LastName       { get; set; }
        public string PhoneNumber    { get; set; }
        public string EmergencyName  { get; set; }
        public string EmergencyPhone { get; set; }

        public override bool Equals(object obj)
        {
            Customer client = (Customer)obj;

            if (client.AccountNumber.Equals(this.AccountNumber))
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
