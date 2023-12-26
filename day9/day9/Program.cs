using System;
using System.Collections.Generic;

namespace day9;

class Program
{
    static void Main(string[] args)
    {
        #region Task
        // verilmiş yazının sonundaki boşluları silinmiş yeni bir yazı düzəldən proqram yazırsınız
        Console.WriteLine("yazi daxil edin: ");
        string metn = Console.ReadLine();
        string newMetn = "";
        int finalIndex = -1;
        for (int i = metn.Length - 1; i >= 0; i--)
        {

            if (metn[i] != ' ')
            {
                finalIndex = i;
                break;

            }
        }
        for (int i = 0; i <= finalIndex; i++)
        {
            newMetn += metn[i];
        }
        Console.WriteLine("sonundaki bosluqlar silinmis metn:" + newMetn);

        #endregion



        #region calc

        bool check = true;
        double a, b;
        do
        {
            Console.WriteLine("1. Topla");
            Console.WriteLine("2. Cix");
            Console.WriteLine("3. Vur");
            Console.WriteLine("4. Bol");
            Console.WriteLine("0. Proqrami bitir");


            string opt = Console.ReadLine();

            switch (opt)
            {
                case "1":
                    Console.WriteLine("toplama prosesi!");
                    Console.Write("1 ci ededi daxil edin: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2 ci ededi daxil edin: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"ededlerin cemi: {a + b}");


                    break;
                case "2":
                    Console.WriteLine("cixma prosesi!");
                    Console.Write("1 ci ededi daxil edin: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2 ci ededi daxil edin: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"ededlerin ferqi: {a - b}");


                    break;
                case "3":
                    Console.WriteLine("vurma prosesi prosesi!");
                    Console.Write("1 ci ededi daxil edin: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2 ci ededi daxil edin: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"ededlerin hasili: {a * b}");

                    break;
                case "4":

                    do
                    {
                     Console.WriteLine("bolme prosesi!");
                     Console.Write("1 ci ededi daxil edin: ");
                     a = Convert.ToInt32(Console.ReadLine());
                     Console.Write("2 ci ededi daxil edin: ");
                     b = Convert.ToInt32(Console.ReadLine());
                     if (b != 0)
                        {
                            Console.WriteLine($"ededlerin nisbeti: {a / b}");

                        }
                     else
                        {
                            Console.WriteLine("0 a bolmek olmaz!");
                        }

                    } while (b == 0);


                    break;
                case "0":
                    Console.WriteLine("Proqram bitdi");
                    check = false;
                    break;
                default:
                    Console.WriteLine("yanlis emeliyyat");
                    break;
            }

        } while (check);

        #endregion

        #region beforeTask1
        // Verilmiş yazıdan içində boşluqlar olmayan yeni bir yazı düzəltmək
        //Console.WriteLine("metn daxil edin; ");
        //string Str = Console.ReadLine();
        //string netice = "";
        //for (int i = 0; i < Str.Length; i++)
        //{

        //    if (Str[i] != ' ')
        //    {
        //        netice += Str[i];
        //    }
        //}
        //Console.WriteLine("netice: " + netice);

        #endregion
        #region beforeTask2

        ////Verilmiş ədədlər siyahısındaki verilmiş n ədədinin yerləşdiyi indexi tapan proqram
        //Console.WriteLine("uzunlugu daxil edin: ");
        //int n = Convert.ToInt32(Console.ReadLine());
        //int[] nums = new int[n];
        //for (int i = 0; i < nums.Length; i++)
        //{
        //    Console.WriteLine($"#{i + 1} ededi daxil edin:");
        //    nums[i] = Convert.ToInt32(Console.ReadLine());

        //}
        //Console.WriteLine("axtarardiginiz ededi daxil edin: ");
        //int axt = Convert.ToInt32(Console.ReadLine());

        //int indexx = -1;
        //for (int i = 0; i < nums.Length; i++)
        //{
        //    if (nums[i] == axt)
        //    {
        //        indexx = i;
        //        break;

        //    }

        //}
        //Console.WriteLine(indexx);

        #endregion
        #region beforeTask3

        //// Verilmiş yazılar siyahısında verilmiş hərfdən neçə ədəd olduğunu tapan proqram
        //Console.WriteLine("yazi siyahisinin uzunlugunu daxil edin: ");
        //int length = Convert.ToInt32(Console.ReadLine());
        //string[] arr1 = new string[length];
        //for (int i = 0; i < arr1.Length; i++)
        //{
        //    Console.WriteLine($"{i + 1} ci metni daxil edin: ");
        //    arr1[i] = Console.ReadLine();

        //}
        //Console.WriteLine("axtardiginiz herfi daxil edin: ");

        //char search = Convert.ToChar(Console.ReadLine());

        //int count = 0;
        //for (int i = 0; i < arr1.Length; i++)
        //{
        //    for (int j = 0; j < arr1[i].Length; j++)
        //    {
        //        if (arr1[i][j] == search)
        //        {
        //            count++;
        //        }

        //    }

        //}
        //Console.WriteLine("axtardiniz herf sayi: " + count);
        #endregion
        #region beforeTask4

        //// Verilmiş yazının əvvəlindəki boşluqlar silinmiş bir string düzəldən proqram(Misalçün verilmiş yazı "  " +
        //// " salam necesen?   " - dirsə yeni düzələcək string "salam necəsən?   " olmalıdır.
        //Console.WriteLine("yazi daxil edin: ");
        //string Metn = Console.ReadLine();
        //string newMetnn = "";
        //int startIndexx = -1;
        //for (int i = 0; i <Metn.Length; i++)
        //{

        //    if (Metn[i] != ' ')
        //    {
        //        startIndexx = i;
        //        break;

        //    }
        //}
        //for (int i = startIndexx; i <Metn.Length; i++)
        //{
        //    newMetnn += Metn[i];
        //}
        //Console.WriteLine("evvelindeki bosluqlar silinmis metn:"+newMetnn);




        #endregion

        #region beforeTask5
        //// Verilmiş 2 ədəd üzərində verilmiş simvola uyğun əməliyyat edən proqram. Simvol +,-,*və ya / olmalıdır,
        ////   əks halda simvolu yenidən daxil edilməsi istənilməlidir.(Misaçün simvol * olarsa verilmiş 2 ədəd vurulacaq və nəticəsi göstəriləcək)

        //Console.WriteLine("1 ci ededi daxil edin: ");
        //double num1 = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("2 ci ededi daxil edin: ");
        //double num2 = Convert.ToDouble(Console.ReadLine());
        //bool check;

        //do
        //{
        //    Console.Write("simvolu daxil et: ");
        //    char simvol = Convert.ToChar(Console.ReadLine());
        //    check = true;
        //    switch (simvol)
        //    {
        //        case '+': Console.WriteLine($"ededlerin cemi:{num1 + num2}"); break;
        //        case '-': Console.WriteLine($"ededlerin ferqi:{num1 - num2}"); break;
        //        case '*': Console.WriteLine($"ededlerin hasili:{num1 * num2}"); break;
        //        case '/':
        //            if (num2 != 0)
        //            {
        //                Console.WriteLine($"nisbet: {num1 / num2}");
        //            }
        //            else
        //            {
        //                Console.WriteLine(" 0 a bole bilmirik ");
        //            }
        //            break;

        //        default:
        //            check = false;
        //            Console.WriteLine("simvolu duzgun daxil edin!");
        //            break;
        //    }

        //} while (!check);
        #endregion

        #region beforetask1
        //// Verilmiş 3 ədəddən hansının ən böyük olduğunu tapan proqram
        //  Console.WriteLine("1 ci ededi daxil edin:");
        // int first = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("2 ci ededi daxil edin:");
        // int sec = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("3 ci ededi daxil edin:");
        // int third = Convert.ToInt32(Console.ReadLine());

        // int big;
        // if (first > sec)
        // {
        //     if (first > sec)
        //     {
        //         big = first;
        //     }
        //     else
        //     {
        //         big = third;
        //     }
        // }
        // else if (sec > third)
        // {
        //     big = sec;
        // }
        // else
        // {
        //     big = third;
        // }
        // Console.WriteLine("en boyuk eded: "+big);


        #endregion
        #region beforetask2

        ////Verilmiş yazının içində A hərfinin olub olmadığını tapan proqram
        //Console.WriteLine("yazini daxil edin: ");
        //string str = Console.ReadLine();
        //bool check = false;
        //for (int i = 0; i < str.Length; i++)
        //{

        //    if (str[i]=='A')
        //    {
        //        check = true;
        //        break;

        //    }
        //}
        //if (check)
        //{
        //    Console.WriteLine("yazinin icinde A hervi var!");

        //}
        //else
        //{
        //    Console.WriteLine("yazinin icinde A herfi yoxdur!");
        //}

        #endregion
        #region beforetask3

        ////Verilmiş yazıda neçə A hərfinin olduğunu tapan proqram
        //Console.WriteLine("Yazi daxil edin:");
        //string yazi = Console.ReadLine();

        //int count = 0;

        //for (int i = 0; i < yazi.Length; i++)
        //{
        //    if (yazi[i] == 'A')
        //    {
        //        count++;
        //    }

        //}

        //Console.WriteLine("Yazida A herfinin sayi:"+count);

        #endregion
        #region beforetask4

        //// Verilmiş müsbət cüt ədədi kradtarına yüksəldən proqram.
        ////  Daxil edilən ədə musbət və cüt olmadıqca yenidən daxil edilməlidir

        //int eded;
        //do
        //{
        //    Console.WriteLine("Ededi daxil edin: ");

        //    eded = Convert.ToInt32(Console.ReadLine());
        //}
        //while (eded <= 0 || eded % 2 != 0);

        //Console.WriteLine($"Verilmis ededin kvadrati: {eded * eded}");

        #endregion

        #region beforetask5
        //  //Verilmiş 5 uzunluqlu ədədlər siyahısındaki ədədlərin cəmini tapan proqram

        //int[] numbers = new int[5];
        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    Console.WriteLine($"#{i + 1} ededi daxil edin:");
        //    numbers[i] = Convert.ToInt32(Console.ReadLine());
        //}
        //int sum = 0;
        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    sum += numbers[i];
        //}
        //Console.WriteLine("arraydaki ededlerin cemi: " + sum);
        #endregion
        #region beforetask6

        ////Verilmiş təhsil növü dəyərinə əsasən o təhsilin saatını göstərən
        ////proqram.Əgər verilmiş dəyər "programming"dirsə console-da
        ////400 saat, "design"dırsa 250 saat, "system"dirsə 200 saat,
        ////heç biri deyilsə "təhsil novu yanlisdir" yazılmalıdır console-da.
        //bool check3;

        //    Console.WriteLine("Tehsil novunu daxil edin:");
        //    string tehsilNovu = Console.ReadLine();


        //    switch (tehsilNovu)
        //    {
        //        case "programming":
        //            Console.WriteLine("400 saat");
        //            break;
        //        case "design":
        //            Console.WriteLine("250 saat");
        //            break;
        //        case "system":
        //            Console.WriteLine("200 saat");
        //            break;
        //        default:
        //            Console.WriteLine("Tehsil novu sehvdir");
        //            break;
        //    }

        #endregion
        Console.ReadLine();
    }
}

