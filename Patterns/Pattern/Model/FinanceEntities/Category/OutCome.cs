using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Model.FinanceEntities
{
    public class OutCome : FinanceEntities
    {
        public OutCome(int summ, Category category, DateTime dateTime) : base(summ, category, dateTime)
        {
        }
    }
}
