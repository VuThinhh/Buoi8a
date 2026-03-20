using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi8a
{
    public abstract class MoneyHandler
    {
        protected MoneyHandler _nextHandler;

        public void SetNext(MoneyHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public abstract void Handle(int amount);
    }
}
