using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb8_waldemar_Engvall
{
    class Runtime
    {

        public delegate string MyStringDelegate(List<string> list);
        public delegate float MyFloatDelegate(List<float> list);



        public void Start()
        {
            List<string> MyStringList = new List<string>();
            {
                MyStringList.Add("string1");
                MyStringList.Add("string2");
                MyStringList.Add("string3");
                MyStringList.Add("string4");
            };

            List<float> MyNumberlist = new List<float>();
            {
                MyNumberlist.Add(11);
                MyNumberlist.Add(5);
                MyNumberlist.Add(2);
                MyNumberlist.Add(55);

            };


            MyStringDelegate concatinator = list =>
              {
                  string output="";

                  foreach (string word in list)
                  {
                      output += word + ",";
                  }
                  return output;
                 };
            
            Console.WriteLine(concatinator(MyStringList));



            MyFloatDelegate numberAddition = list =>
            {
                float output = 0;

                foreach (float number in list)
                {
                    output += number;
                }
                return output;
            };
           
            Console.WriteLine(numberAddition(MyNumberlist));

            MyFloatDelegate numberTimes = list =>
            {
                float output = 1;

                foreach (float number in list)
                {
                    output *= number;
                }
                return output;
            };

            Console.WriteLine(numberTimes(MyNumberlist));

        }
    }
}
