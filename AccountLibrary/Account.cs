using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountLibrary
{
    [Serializable]
    public class Account
    {
        
        
            static public int Count = 0;
            public string Name { get; set; }
            public string Number { get; set; }
            private double balnace;
            public double Balnace
            {
                get { return balnace; }

                set
                {

                    if (value >= 0)
                        balnace = value;
                    else balnace = 0;
                }
            }






            public virtual string printString()
            {
                string s = Name + " " + Number + " " + Balnace.ToString();
                return s;
            }
            public Account(string name, string number, double balnace)
            {
                Name = name;
                Number = number;
                Balnace = balnace;
            }
            public Account() { }

     }
    
}
