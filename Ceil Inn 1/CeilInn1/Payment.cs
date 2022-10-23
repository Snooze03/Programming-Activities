using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CeilInn1
{
    [Serializable]
    public class Payment
    {
        public int ReceiptNumber { get; set; }
        public string EmployeeNumber { get; set; }
        public DateTime PaymentDate { get; set; }
        public string AccountNumber { get; set; }
        public DateTime FirstDayOccupied { get; set; }
        public DateTime LastDayOccupied { get; set; }
        public int TotalNights { get; set; }
        public double AmountCharged { get; set; }
        public double PhoneUse { get; set; }
        public double SubTotal { get; set; }
        public double TaxRate { get; set; }
        public double TaxAmount { get; set; }
        public double TotalAmountPaid { get; set; }
    }
}
