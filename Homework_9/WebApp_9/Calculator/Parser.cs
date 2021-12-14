using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace WebApp_9.Calculator
{
    public class Parser
    {
        public static Expression ParseStr(string str)
        {
            var operators = 0;
            for (var i = 0; i < str.Length;i++)
            {
                if (str[i] != '(' || str[i] != ')')
                {
                    if (str[i] == '+' || str[i] == '-')
                    {
                        operators = i;
                        break;
                    }

                    if (str[i] == '*' || str[i] == '/')
                    {
                        operators = i;
                    }
                }
            }
            if (operators == 0)
            {
                
            }
            
        }
        

        public int Calculate(int var1, int var2,Operations operation)
        {
            var result = operation switch
            {
                Operations.Plus => var1 + var2,
                Operations.Minus => var1 - var2,
                Operations.Mult => var1 * var2,
                Operations.Divide => var1 / var2,
                _ => -1
            };
            return result;
        }
    }
}