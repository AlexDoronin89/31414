using Pattern.Model.FinanceEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Model
{
    public class FinanceData
    {
        private List<Income> _inComes;
        private List<OutCome> _outComes;
        private List<IncomeCategory> _incomeCategories;
        private List<OutcomeCategory> _outcomeCategories;

        public FinanceData()
        {
            _inComes = new List<Income>();
            _outComes = new List<OutCome>();
            _incomeCategories = new List<IncomeCategory>();
            _outcomeCategories = new List<OutcomeCategory>();
        }

        #region Income CRUD
        public bool AddIncome(int summ, int categoryId, DateTime dateTime)
        {
            Category category = GetCategory(categoryId);

            if (category != null)
                _inComes.Add(new Income(summ, category, dateTime));
            else
                return false;

            return true;
        }

        public bool RemoveIncome(int incomeId)
        {
            int index = FindIncomeIndexByID(incomeId);
            if (index != -1)
            {
                _inComes.RemoveAt(index);
                return true;
            }
            return false;
        }

        public bool UpdateIncome(int incomeID, int summ = -1, int categoryId = -1)
        {
            int index = FindIncomeIndexByID(incomeID);
            if (index != -1)
            {
                Category category = categoryId == -1 ? null : GetCategory(categoryId);
                
                _inComes[index].Update(summ, category);
                return true;
            }
            return true;
        }

        public Income GetIncomeById(int id)
        {
            int index = FindIncomeIndexByID(id);
            if (index != -1)
                return _inComes[index];
            else
                return null;
        }

        public IReadOnlyList<Income> GetIncomes()
        {
            return _inComes;
        }

        private int FindIncomeIndexByID(int incomeId)
        {
            for (int i = 0; i < _inComes.Count; i++)
            {
                if (_inComes[i].ID == incomeId)
                {
                }
            }
            return -1;
        }
        #endregion

        #region Outcome CRUD

        public bool AddOutcome(int summ, int categoryId, DateTime dateTime)
        {
            Category category = GetCategory(categoryId);

            if (category != null)
                _outComes.Add(new OutCome(summ, category, dateTime));
            else
                return false;

            return true;
        }

        public bool RemoveOutcome(int outcomeId)
        {
            int index = FindOutcomeIndexByID(outcomeId);
            if (index != -1)
            {
                _outComes.RemoveAt(index);
                return true;
            }
            return false;
        }

        public bool UpdateOutcome(int outcomeID, int summ = -1, int categoryId = -1)
        {
            int index = FindOutcomeIndexByID(outcomeID);
            if (index != -1)
            {
                Category category = categoryId == -1 ? null : GetCategory(categoryId);

                _outComes[index].Update(summ, category);
                return true;
            }
            return true;
        }

        public OutCome GetOutcomeById(int id)
        {
            int index = FindOutcomeIndexByID(id);
            if (index != -1)
                return _outComes[index];
            else
                return null;
        }

        public IReadOnlyList<OutCome> GetOutcomes()
        {
            return _outComes;
        }

        private int FindOutcomeIndexByID(int incomeId)
        {
            for (int i = 0; i < _outComes.Count; i++)
            {
                if (_outComes[i].ID == incomeId)
                {
                }
            }
            return -1;
        }

        #endregion

        #region IncomeCategory CRUD
        public Category GetCategory(int categoryTitle)
        {
            foreach (var category in _incomeCategories)
                if (category.ID == categoryTitle)
                    return category;

            return null;
        }
        #endregion

        #region OutcomeCategory CRUD
        #endregion
    }

}
