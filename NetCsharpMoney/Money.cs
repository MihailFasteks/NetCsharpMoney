using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCsharpMoney
{
    internal class Money
    {
        public double Sum {  get; set; }
        public Money()
        {
            Sum = 0;
        }
        public Money(double sum)
        {
            Sum = sum;
        }
        public static Money operator +(Money op1, Money op2)
        {
            Money result = new()
            {
                Sum = op1.Sum + op2.Sum
            };
            return result;
        }
        public static Money operator ++(Money opl)
        {
            Money result = new()
            {
                Sum = opl.Sum + 0.01
            };
            return result;
        }
        public static Money operator -(Money op1, Money op2)
        {
            Money result = new()
            {
                Sum = op1.Sum - op2.Sum
            }; return result;
        }
        public static Money operator -(Money op1, int op2)
        {
            Money result = new()
            {
                Sum = op1.Sum - op2
            }; return result;
        }  
        public static Money operator +(Money opl, int op2)
        {
            Money result = new()
            {
                Sum = opl.Sum + op2
            };
            return result;
        }
        
        public static Money operator +(int opl, Money op2)
        {
            Money result = new()
            {
                Sum = op2.Sum + opl
            };
            return result;
        }
       
        public static bool operator <(Money op1, Money op2)
        {
            if (op1.Sum < op2.Sum)
                return true;
            else
                return false;
        }
        public static bool operator >(Money op1, Money op2)
        {
            if (op1.Sum > op2.Sum) return true;
            else return false;
        }
        public static bool operator ==(Money op1, Money op2)
        {
            if (op1.Sum == op2.Sum)
                return true;
            else
                return false;
        }
        public static bool operator !=(Money op1, Money op2)
        {
            if (op1.Sum != op2.Sum)
                return true;
            else
                return false;
        }
    }
}
