using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountLibrary
{
    [Serializable]
     public class AccountMult : Account
    {
        public int Currency {  get; set; } 

        public override string printString()
        {
            string s = Name + " " + Number + " " + Balnace;
            if (Currency == 0)
                s = s + "€";
            else s = s + "$";
            return s;
        }
        public AccountMult() { }
        public AccountMult(string name,string number,double balance,int currency)
        {
            Name = name;
            Number = number;
            Balnace = balance;
            Currency = currency;
        }
        public AccountMult(string name,string number) 
        {
            Name = name;
            Number = number;
            Balnace = 0;
            Currency = 0;
            
        }
    }
}
