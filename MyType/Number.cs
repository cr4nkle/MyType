using System;
using System.Collections.Generic;

namespace LogicClass
{

    public class Number
    {
        Dictionary<int, string> mapTable = new Dictionary<int, string>{
            [0] = "0",
            [1] = "1",
            [2] = "2",
            [3] = "3",
            [4] = "4",
            [5] = "5",
            [6] = "6",
            [7] = "7",
            [8] = "8",
            [9] = "9",
            [10] = "A",
            [11] = "B",
            [12] = "C",
            [13] = "D",
            [14] = "E",
            [15] = "F",


        };
        Dictionary<char, int> mapTableRev = new Dictionary<char, int>
        {
            ['0'] = 0,
            ['1'] = 1,
            ['2'] = 2,
            ['3'] = 3,
            ['4'] = 4,
            ['5'] = 5,
            ['6'] = 6,
            ['7'] = 7,
            ['8'] = 8,
            ['9'] = 9,
            ['A'] = 10,
            ['B'] = 11,
            ['C'] = 12,
            ['D'] = 13,
            ['E'] = 14,
            ['F'] = 15,


        };
        private string number = "";
        private int footing;
        public Number(string number, int footing)
        { 
            this.number = number;           
            this.footing = footing;
        }
        public Number()
        {
            this.number = "";
            this.footing = 1;
        }

       


        private Number Revers()
        {
            Number revers = new Number();
            revers.footing = footing;
            int length = number.Length-1;
            for (int i = length; i >= 0; i--)
            {
                revers.number += number[i];
            }
            return revers;
        }
        public override string ToString()
        {
            return number;
        }
        public Number Convert(int footing)
         {  
            Number result = new Number();
            result.footing = footing;                       
            int whole = int.Parse(this.ConversionToDemical().number);
             while(whole >= 1)
             {
                 int remainder = whole % footing;
                 result.number += mapTable[remainder];
                 whole /= footing;

             }
            result = result.Revers();
             return result;
         }
        public Number ConversionToDemical()
        {
            Number result = new Number();
            result.footing = 10;
           
            int length = number.Length - 1;
            char[] symbol = number.ToCharArray();
            
            int pows = length;
            int sum = 0;
            for (int i = 0; i <= length; i++)
            {
                int temp = mapTableRev[symbol[i]];                
                sum += (int)Math.Pow(footing,pows)*temp;                
                pows--;
            }
            result.number = sum.ToString();
            
            return result;
        }

        public static Number operator -(Number numb1, Number numb2)
        {
            numb1.number = numb1.ConversionToDemical().number;
            numb2 = numb2.ConversionToDemical();
            int temp = int.Parse(numb1.number) - int.Parse(numb2.number);


            return new Number(temp.ToString(), 10);
        }
        public static Number operator *(Number numb1, Number numb2)
        {
            numb1.number = numb1.ConversionToDemical().number;
            numb2 = numb2.ConversionToDemical();
            int temp = int.Parse(numb1.number) * int.Parse(numb2.number);


            return new Number(temp.ToString(), 10);
        }
        public static Number operator +(Number numb1, Number numb2)
        {
            numb1.number = numb1.ConversionToDemical().number;
            numb2 = numb2.ConversionToDemical();
            int temp = int.Parse(numb1.number) + int.Parse(numb2.number);


            return new Number(temp.ToString(), 10);
        }
        
        public string Compare(Number numb)
        {
            string result = "";
            int temp1 = int.Parse(this.ConversionToDemical().number);
            int temp2 = int.Parse(numb.ConversionToDemical().number);
            
            if (temp1 == temp2)
            {
                result = this.number + " = " + numb.number;
            }else
            if (temp1 < temp2)
            {
                result = this.number + " < " + numb.number;
            }
            else
            if (temp1 > temp2)
            {
                result = this.number + " > " + numb.number;
            }
            return result;
        }


    }
}
