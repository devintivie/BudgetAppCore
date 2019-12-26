using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace BudgetAppCore.Models
{
    public class BillTracker : IComparable<BillTracker>
    {

        #region Properties
        public List<Bill> Bills { get; set; } 
        public string CompanyName { get; set; }
        public bool Autopay { get; set; }
        #endregion

        #region Constructors
        public BillTracker(string company, List<Bill> list, bool auto = false )
        {
            CompanyName = company;
            Autopay = auto;
            Bills = new List<Bill>(list);
        }

        public BillTracker() : this("No Name", new List<Bill>(), false) { }

        public BillTracker(string company, Bill firstBill) : this(company, new List<Bill> { firstBill} )
        {

        }
        #endregion


        #region IComparable
        public int CompareTo([AllowNull] BillTracker other)
        {
            if (other == null) return 1;
            else
                return CompanyName.CompareTo(other.CompanyName);
        }
        #endregion

    }
}
