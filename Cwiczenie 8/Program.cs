using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Warsztat samochodowy
namespace Cwiczenie_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Aplication one = new Aplication();

            while (one.button != 'e')
            {
                one.ReadButton();
                one.action();
            }
        }
    }
}
