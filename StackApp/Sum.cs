using System.Collections.Generic;

namespace StackApp
{
    public class Sum
    {
        private List<int> _sumList = new List<int>();
        private int _total;

        public int Total
        {
            get => _total;
        }

        public void AddToList(int num)
        {
            _sumList.Add(num);
            Calculate();
        }

        private void Calculate()
        {
            _total = 0;
            foreach (var n in _sumList)
            {
                _total = _total + n;
            }
        }

    }
}