using System;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            //var input = Console.ReadLine();

            //if (input == "salam")
            //{
            //    Console.WriteLine("Aleykum salam!");
            //}
            //else if(input == "sag ol")
            //{
            //    Console.WriteLine("Sen de sag ol!");
            //}
            //else
            //{
            //    Console.WriteLine("Rusca danismayin!");
            //}


            //Verilmis ededin cut olub olmamasini tapan proqram
            Console.WriteLine("Yoxlamaq isteiyiniz ededi daxil edin:");
            var numberStr = Console.ReadLine();


            var number = Convert.ToInt32(numberStr);

            if (number % 2 == 0)
                Console.WriteLine("cutdur");
            else
                Console.WriteLine("tekdir");


            var num1 = 45;

            //num1++;
            //++num1;


            var num2 = 10 + ++num1;


            Console.WriteLine(num2);
            Console.WriteLine(num1);

            //Daxil edilmis yazida a herfinin olub olmamasini tapan proqram

            Console.WriteLine("Adinizi daxil edin:");
            string name = Console.ReadLine();

            var firstLetter = name[0];

            Console.WriteLine(firstLetter);

            Console.WriteLine("Herfler:");
            bool hasA = false;
            for(int i = 0; i < name.Length; i++)
            {
                //if(name[i]=='a' || name[i] == 'A')
                //{
                //    hasA = true;
                //    break;
                //}

                if(name[i]!='a' && name[i] != 'A')
                {
                    continue;
                }

                hasA = true;
                break;
            }


            //Daxil edilmis yazida a herfinin olub olmamasini tapan proqram

            hasA = false;
            int j = 0;
            while (j < name.Length)
            {
                if(name[j]=='a' || name[j] == 'A')
                {
                    hasA = true;
                    break;
                }
                j++;
            }


            if (hasA)
            {
                Console.WriteLine("Yazida A var");
            }
            else
            {
                Console.WriteLine("Yazida A yoxdur");
            }


            Console.WriteLine("\n=====================================================\n");

            string inputName;

            do
            {
                Console.WriteLine("Adinizi daxil edin:");
                inputName = Console.ReadLine();
            }
            while (inputName.Length < 3 || inputName.Length > 15);
          

            Console.WriteLine("Adiniz: "+inputName);


            Console.WriteLine("Yaz:");
            string word = Console.ReadLine();

            if (word == "salam")
            {
                Console.WriteLine("Aleykum salam");
            }
            else if(word == "sag ol")
            {
                Console.WriteLine("Sen de sag ol!");
            }
            else
            {
                Console.WriteLine("Ya niznayu poruski");
            }


            //Verilmis deyerin heftenin hansi gunu oldugunu gosteren proqram

            Console.WriteLine("Heftenin gununu  daxil edin:");
            var dayOfWeek = Console.ReadLine();
            var dayNum = Convert.ToInt32(dayOfWeek);


            //if(dayOfWeek == "1")
            //{
            //    Console.WriteLine("Bazar ertesi");
            //}
            //else if(dayOfWeek == "2")
            //{
            //    Console.WriteLine("Cersenbe axsami");
            //}
            //else if(dayOfWeek == "3")
            //{
            //    Console.WriteLine("Cersenbe");
            //}
            //else if (dayOfWeek == "4")
            //{
            //    Console.WriteLine("Cume axsami");
            //}
            //else if (dayOfWeek == "5")
            //{
            //    Console.WriteLine("Cume");
            //}
            //else if (dayOfWeek == "6")
            //{
            //    Console.WriteLine("Senbe");
            //}
            //else if(dayOfWeek == "7")
            //{
            //    Console.WriteLine("Bazar");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlisdir");
            //}

            if (dayNum == 1)
            {
                Console.WriteLine("Bazar ertesi");
            }
            else if (dayNum == 2)
            {
                Console.WriteLine("Cersenbe axsami");
            }
            else if (dayNum == 3)
            {
                Console.WriteLine("Cersenbe");
            }
            else if (dayNum == 4)
            {
                Console.WriteLine("Cume axsami");
            }
            else if (dayNum == 5)
            {
                Console.WriteLine("Cume");
            }
            else if (dayNum ==6 || dayNum==7)
            {
                Console.WriteLine("Heftesonu");
            }
            else
            {
                Console.WriteLine("Yanlisdir");
            }




        }
    }
}
