using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalNumsLib
{
    public static class NaturalNumbers
    {
        /// <summary>
        /// Вычисляет четное ли число
        /// </summary>
        /// <param name="number">Число для проверки</param>
        /// <returns>Возвращает true или false</returns>   
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        /// <summary>
        /// Вычисляет НОД для двух целых положительных чисел
        /// </summary>
        /// <param name="A">Первое число</param>
        /// <param name="B">Второе число</param>
        /// <returns>Возвращает значение НОД</returns>
        public static int GCD(int A, int B) 
        {
            if(A<0||B<0)
            {
                throw new Exception("Нельзя отрицательные числа");
            }
            int nod = 0;
            if (A != 0 && B != 0)
            {
                if (A > B)
                {
                    for (int i = 1; i <= B; i++)
                    {
                        if (A % i == 0 && B % i == 0)
                            nod = i;
                    }
                    return nod;
                }
                else
                {
                    for (int i = 1; i <= A; i++)
                    {
                        if (A % i == 0 && B % i == 0)
                            nod = i;
                    }
                    return nod;
                }
            }
            else
            {
                return A + B;
            }
        }

        /// <summary>
        /// Вычисляет простое ли число
        /// </summary>
        /// <param name="number">Число для проверки</param>
        /// <returns>Возвращает true или false</returns>   

        public static bool IsPrime(int number)
        {
            bool temp = true;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    temp = false;

                }


            }
            return temp;

        }

        /// <summary>
        /// Вычисляет НОК для двух целых положительных чисел
        /// </summary>
        /// <param name="A">Первое число</param>
        /// <param name="B">Второе число</param>
        /// <returns>Возвращает значение НОК</returns>
        public static int LCM(int A, int B)
        {
            if (A == 0 || B == 0)
            {
                throw new Exception("Числа не могут быть равны 0");
            }
            if (A < 0 || B < 0)
            {
                throw new Exception("Нельзя отрицательные числа");
            }
            return Math.Abs(A * B) / GCD(A, B);
        }
    }
    
}
