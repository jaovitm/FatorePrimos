using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace FatoresPrimos.Services
{
    public class MathService
    {
        public List<int> Decompor(int number)
        {

            List<int> divisores = new List<int>();

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    divisores.Add(i);
                }
            }

            return divisores;

        }

        public List<int> Primos(List<int> numbers)
        {
            List<int> primos = new List<int>();

            foreach (int number in numbers)
            {
                int divisores = 0;

                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        divisores++;
                        if (divisores > 2)
                            break;
                    }
                }

                if (divisores == 2)
                    primos.Add(number);
                
            }


            return primos;
        }

    }
}

