using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._6._20
{
    class Carrier
    {
        public Vehice[] arr;
        public override string ToString()
        {
            string str="Vehice element: \n";
            for (int i = 0; i < arr.Length; i++)
            {
                str +=  $"{arr[i].ToString()} \n";
            
            }
            return str;
        }
    }
}
