using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCsharpMoney
{
    internal class Money:IDisposable
    {
        FileStream fs;
        public double Sum {  get; set; }
        public Money()
        {
            
            Sum = 0;
           
        }
        public Money(double sum)
        {
           
            Sum = sum;
        }
    
        public void SaveFile(string str)
        {
            using (fs = new FileStream("Money.txt", FileMode.OpenOrCreate))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(str);
                Console.WriteLine("Сохранено в файл");
               
            }

        }

        public void Dispose()
        {
            
            fs.Close();
        }

        public static Money operator +(Money op1, Money op2)
        {
            Money result = new();
            try
            {


                result.Sum = op1.Sum + op2.Sum;
                
                if (result.Sum < 0)
                {
                    throw new InvalidOperationException("Банкрот");
                }
            }
            catch(Exception mes)
            {
            
                Console.WriteLine(mes);
            }

            return result;
        }
        public static Money operator ++(Money opl)
        {
            Money result = new();
            try
            {
                result.Sum = opl.Sum + 0.01;
                if (result.Sum < 0)
                {
                    throw new InvalidOperationException("Банкрот");
                }
            }
            catch (Exception mes)
            {

                Console.WriteLine(mes);
            }
         
            
            return result;
        }
        public static Money operator -(Money op1, Money op2)
        {
            Money result = new();
            try
            {
                result.Sum = op1.Sum - op2.Sum;
                if (result.Sum < 0)
                {
                    throw new InvalidOperationException("Банкрот");
                }
            }
            catch (Exception mes)
            {

                Console.WriteLine(mes);
            }
           
           return result;
        }
        public static Money operator -(Money op1, int op2)
        {
            Money result = new();
            try
            {
                result.Sum = op1.Sum - op2;
                if (result.Sum < 0)
                {
                    throw new InvalidOperationException("Банкрот");
                }
            }
            catch (Exception mes)
            {

                Console.WriteLine(mes);
            }

            return result;
        }  
        public static Money operator +(Money opl, int op2)
        {
            Money result = new();
            try
            {


                result.Sum = opl.Sum + op2;

                if (result.Sum < 0)
                {
                    throw new InvalidOperationException("Банкрот");
                }
            }
            catch (Exception mes)
            {

                Console.WriteLine(mes);
            }

            return result;
        }
        
        public static Money operator +(int opl, Money op2)
        {
            Money result = new();
            try
            {


                result.Sum = opl + op2.Sum;

                if (result.Sum < 0)
                {
                    throw new InvalidOperationException("Банкрот");
                }
            }
            catch (Exception mes)
            {

                Console.WriteLine(mes);
            }

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
