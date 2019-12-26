using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetAppCore.Models
{
    public enum BillStatus
    {
        Paid,
        PastDue,
        DueToday,
        DueTomorrow,
        DueWithinTwoWeeks,
        DueWithinOneMonth,
        DueInOverOneMonth,
        AutoPayUpcoming,
        AutoPayPast,
        NoneDue,
    }
}
