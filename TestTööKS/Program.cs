﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace TestTööKS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kerttu lahendatud ülesanded!");

            //1.Trükkida välja kõik kolmega jagunevad arvud vahemikus 1..100

            //for (int i = 1; i < 1000; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine("Jagub 3-ga: " + i);
            //    }
            //    //else
            //    //{
            //    //    Console.WriteLine("Ei jagu 3-ga " + i);
            //    //}
            //}

            Function1();
            //Function2();
            //Function3();
            //Function4();



        }
        public static void Function1()
        {
            // 2.Lase kasutajal sisestada arve kuni tühi string vastuseks tuleb(ehk ENTER ilma midagi kirjutamata).Arvuta nende arvude summa ning min ja max väärtused. Trüki saadud tulemused ekraanile

            var arrayOfInputs = new List<int>();

            bool isNotEmpty = true;
            Console.WriteLine("Sisesta numbrid: ");

            while (isNotEmpty)
            {

                var input = Console.ReadLine();


                if (string.IsNullOrWhiteSpace(input))
                {
                    isNotEmpty = false;
                    break;

                }
                else
                {
                    arrayOfInputs.Add(Convert.ToInt32(input));
                }

            }


            Console.WriteLine("Sisestatud numbrite summa on: " + arrayOfInputs.Sum() + " ja  " + "Max väärtus: " + arrayOfInputs.Max() + " ja Min väärtus: " + arrayOfInputs.Min());

            Console.ReadLine();
        }

        public static void Function2()
        {
            // 3.Loome pisikese mängu, kus kas vastane või arvuti paneb esmalt kirja numbri vahemikus 1..50 ja seejärel püüame pakutud arvu ära arvata.Vastusena igale pakkumisele peame ütlema, kas tegu on pakutud arvuga, on see väiksem kui pakutu või suurem kui pakutu.Kui tühi string pannakse, katkestatakse mäng.Lõpuks teavitatakse mitu katset on tehtud ja kas õige tulemus leiti või mitte


            bool doContinue = true;

            var generatedNumber = new Random().Next(50);
            //Console.WriteLine("Genereeritud number on: " + generatedNumber);
            Console.WriteLine("Arva ära, mis numbri valis arvuti: ");
            var count = 0;
            while (doContinue)
            {
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Väljusid mängust aga ei arvanud numbrit ära, proovisid täpselt: " + count + "korda");
                    break;
                    
                }
                if (Convert.ToInt32(input) == generatedNumber)
                {
                    doContinue = false;
                    Console.WriteLine("Arvasid numbri õigesti, proovisid täpselt: " + count + "korda");
                }
                else
                {
                    if (Convert.ToInt32(input) < generatedNumber)
                    {
                        Console.WriteLine("Ei ole õige, Sinu pakutud arv oli väiksem. Proovi veel");
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("Ei ole õige, Sinu pakutud arv oli suurem. Proovi veel");
                        count++;
                    }
                }
            }

            Console.ReadLine();
        }


        public static void Function3()
        {
            //N elemendiga massiiv, trükkige välja, siis muutke järjekorda:
            

            int[] numbers = new int[5] {3, 13, 10, 12, 5 };


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Numbrid: " + numbers[i]);
            }

            int[] numberRev = new int[5];

            for (int i = 0; i < 5; i++)
            {
                numberRev[i] = numbers[4 - i];

            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Tagurpidi: " + numberRev[i]);
            }

        }

        public static  void Function4()
        {
            // 2 mõõõtmeline maatriks, väärtustage ja printige välja.

            var maatriks2 = new int[3, 2]
            {
                { 1, 3 }, // i
                { 2, 4 }, // i
                { 3, 6}   // i 
            };


            var rowCount = maatriks2.GetLength(0);
            var colCount = maatriks2.GetLength(1);
            String arrayString = "";
            for (int i = 0; i < rowCount; i++)
            {

                for (int j = 0; j < colCount; j++)
                {
                    //Console.WriteLine(String.Format("{0}\t", maatriks2[i, j]));
                    arrayString += string.Format("{0} ", maatriks2[i, j]);
                }
                arrayString += System.Environment.NewLine + System.Environment.NewLine;
            }

            Console.WriteLine(arrayString);
        }



            
    } 
}
