using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Model.FinanceEntities
{
    public class FinanceEntities
    {
        private static int _id;

        public int ID { get; private set; }
        public int Summ { get; private set; }
        public Category Category { get; set; }
        public DateTime DateTime { get; private set; }
        
        static FinanceEntities()
        {
            _id = 0;
        }

        public FinanceEntities(int summ, Category category, DateTime dateTime)
        {
            ID = ++_id;
            Summ = summ;
            Category = category;
            DateTime = dateTime;
        }

        public void Update(int summ = -1, Category category = null, DateTime dateTime = default)
        {
            if (summ != -1)
                Summ = summ;
            if(Category != null)
                Category = category;
        }
    }
}
