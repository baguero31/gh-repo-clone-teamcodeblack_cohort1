using System;

namespace PNPDoggyEmporium.Models
{
    #region Base Classes
    /// <summary>
    /// Base Classes
    /// </summary>
    public class Customers
    {
        public DateTime TransactionDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal TransactionPoints { get; set; }
    }

    public class LoyaltyRanges
    {
        public long LoyaltyID { get; set; }
        public int LowRange { get; set; }
        public int HiRange { get; set; }
    }
    #endregion

    #region Query Models

    /// <summary>
    /// Total points per customer with the ranges
    /// </summary>
    public class TPPCustomers
    {
        public string LoyaltyType { get; set; }
        public int TotalPoints { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }

    public class APPCustomers
    {
        public int AvgPoints { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }

    public class DupCustomers 
    {
        public int CountNum { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }

    #endregion
}
