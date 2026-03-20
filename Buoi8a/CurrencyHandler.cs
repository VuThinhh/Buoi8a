using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi8a
{
    public class CurrencyHandler : MoneyHandler
    {
        private readonly int _denomination;

        public CurrencyHandler(int denomination)
        {
            _denomination = denomination;
        }

        public override void Handle(int amount)
        {
            if (amount >= _denomination)
            {
                int numNotes = amount / _denomination;
                int remainder = amount % _denomination;

                Console.WriteLine($"Mệnh giá {_denomination}: {numNotes} tờ");

                if (remainder > 0 && _nextHandler != null)
                {
                    _nextHandler.Handle(remainder);
                }
            }
            else if (_nextHandler != null)
            {
                _nextHandler.Handle(amount);
            }
        }
    }
}
