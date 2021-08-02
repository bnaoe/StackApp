using System;
using System.Collections.Generic;

namespace StackApp
{
    public class Stack
    {
        
        private List<object> _list = new List<object>();
        private object _popObject;

        public List<object> StackList{ get => _list;}
        

        public void Push(object obj)
        {
            if (obj != null) _list.Add(obj);
            else throw new Exception("Nothing to push here.");
        }

        public object Pop()
        {
            if (_list.Count != 0)
            {
                _popObject = _list[_list.Count - 1];
                _list.Remove(_popObject);

                return _popObject;
            }
            else
            {
                throw new Exception("No Stack to pop..");
            }
        }

        public void Clear()
        {
            if (_list.Count != 0) _list.Clear();
            else throw new Exception("Nothing to clear..");
        }
    }
}