using System;
using System.Dynamic;

namespace ctask1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //1. Verilmiş 3 ədəddən hansının ən böyük olduğunu tapan proqram
            Console.Write("Birinci ededi daxil edin:");
            string eded1 = Console.ReadLine();
            int bir = Convert.ToInt32(eded1);
            
            Console.Write("Ikinci ededi daxil edin:");
            string eded2 = Console.ReadLine();
            int iki = Convert.ToInt32(eded2); 
            
            Console.Write("Ucuncu ededi daxil edin:");
            string eded3 = Console.ReadLine();
            int uc = Convert.ToInt32(eded3);


            int enboyuk;
            if(bir>iki)
            {
                if (bir > uc)
                    enboyuk = bir;
                else enboyuk = uc;
            }
            else if(iki>uc)
                enboyuk = iki;
            else enboyuk = uc;

            Console.WriteLine($"{enboyuk} en boyuk ededdir");

            #endregion

            #region Task2
            //Verilmiş yazının içində verilmis herfin olub olmadığını tapan proqram

            Console.WriteLine("Metn daxil edin:");
            string metn = Console.ReadLine();

            Console.WriteLine("Axtarilan herfi daxil edin:");
            string herfStr = Console.ReadLine();
            char herf = Convert.ToChar( herfStr );

            bool varA = false;

            for(int i = 0; i < metn.Length; i++)
            {
                if (metn[i] == herf)
                {
                    varA = true;    
                break;
                }
                  
            }

            if (varA == true) Console.WriteLine($"{herf} bu metnin icinde movcuddur");
            else Console.WriteLine("Axtardiginiz herf daxil etdiyiniz metnde movcud deyil!");

            #endregion

            #region Task3
            //Verilmiş yazıda neçə A hərfinin olduğunu tapan proqram

            Console.WriteLine("Yazi daxil edin:");
            string yazi = Console.ReadLine();

            int count = 0;

            for (int i = 0; i < yazi.Length; i++)
            {
                if (yazi[i] == 'a')    
                    count++;
            }

            Console.WriteLine($"Yazida {count} a herfi var");

            #endregion

            #region Task 4
            //Verilmiş müsbət cüt ədədi kradtarına yüksəldən proqram.
            //Daxil edilən ədə musbət və cüt olmadıqca yenidən daxil edilməlidir

            int num;
            do
            {
                Console.WriteLine("Musbet ve cut ededi daxil edin:");
                string numStr = Console.ReadLine();
                num = Convert.ToInt32(numStr);
            }
            while (num <= 0 || num % 2 != 0);


            int result = num * num;
            Console.WriteLine(result);

            #endregion

            #region Task 5
            //Verilmiş ədədlər siyahısındaki ədədlərin cəmini tapan proqram
            Console.WriteLine("Verilmis ededler siyahisinda ededlerin sayini daxil edin:");
            string numscountstr = Console.ReadLine();
            int numscount = Convert.ToInt32(numscountstr);

            int[] nums = new int[numscount];

            string netice = "";
            for (int i = 0; i < nums.Length; i++) 
            {
                Console.Write($"Eded{i + 1} - ");

                string numberstr = Console.ReadLine();
                int number = Convert.ToInt32(numberstr);
                nums[i] = number;


                if (i != 0 && number >= 0)
                    netice += "+";
                netice += numberstr;
            }

            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum = sum + nums[i];
            }

            netice += $"={sum}";
            Console.WriteLine(netice);
            #endregion

            #region Task6

            //Verilmiş təhsil növü dəyərinə əsasən o təhsilin saatını göstərən
            //proqram.Əgər verilmiş dəyər "programming"dirsə console-da
            //400 saat, "design"dırsa 250 saat, "system"dirsə 200 saat,
            //heç biri deyilsə "təhsil novu yanlisdir" yazılmalıdır console-da ve yeniden daxil edilmelidir.

            bool checkInput;
            do
            {
                Console.WriteLine("Maraqlandiginiz tehsil novunu daxil edin(programming,design,system):");
                string tehsilnovu = Console.ReadLine();
                checkInput = true;


                switch(tehsilnovu)
                {
                    case "programming":
                        Console.WriteLine("400 saat");
                        break;

                    case "design":
                        Console.WriteLine("250 saat");
                        break;

                    case "system":
                        Console.WriteLine("200 saat");
                        break;

                    default :
                        checkInput = false;
                        Console.WriteLine("Tehsil novu movcud deyil!");
                        break;
                }
            } while (!checkInput);
           
      

            #endregion
        }
    }
}
