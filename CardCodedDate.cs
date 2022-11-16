using System;

namespace CardCodedDate
{
    class Program
    {
        static string[] ZStr = new string[] { "Козерог", "Водолей", "Рыбы", "Овен", "Телец", "Близнецы", "Рак", "Лев", "Дева", "Весы", "Скорпион", "Стрелец" };
        static char[] MChar = new char[] { '♥', '♠', '♦', '♣' };
        static string[] CChar = new string[] { "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        static int[,] zodiac = new int[12, 2]; // 12 зодиаков, месяц и дата начала. Например [0,0]=12; [0,1]=22

        static int[] ZHowLong = new int[] { 29, 30, 30, 31, 31, 31, 31, 30, 33, 30, 30, 30 };
        static int[] MaxDayInMounth = new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        static void Main(string[] args)
        {
            Inic();
        }

        static void Inic()
        {
            for (int q = 0; q < 13; q++)
            {
                switch (q)
                {
                    case 0:         //Козерог
                        zodiac[q, 0] = 12;
                        zodiac[q, 1] = 23;
                        break;
                    case 1:         //Водолей
                        zodiac[q, 0] = 1;
                        zodiac[q, 1] = 21;
                        break;
                    case 2:         //Рыбы
                        zodiac[q, 0] = 2;
                        zodiac[q, 1] = 20;
                        break;
                    case 3:         //Овен
                        zodiac[q, 0] = 3;
                        zodiac[q, 1] = 21;
                        break;
                    case 4:         //Телец
                        zodiac[q, 0] = 4;
                        zodiac[q, 1] = 21;
                        break;
                    case 5:         //Близнецы
                        zodiac[q, 0] = 5;
                        zodiac[q, 1] = 22;
                        break;
                    case 6:         //Рак
                        zodiac[q, 0] = 6;
                        zodiac[q, 1] = 22;
                        break;
                    case 7:         //Лев
                        zodiac[q, 0] = 7;
                        zodiac[q, 1] = 23;
                        break;
                    case 8:         //Дева
                        zodiac[q, 0] = 8;
                        zodiac[q, 1] = 22;
                        break;
                    case 9:         //Весы
                        zodiac[q, 0] = 9;
                        zodiac[q, 1] = 24;
                        break;
                    case 10:        //Скорпион
                        zodiac[q, 0] = 10;
                        zodiac[q, 1] = 24;
                        break;
                    case 11:        //Стрелец
                        zodiac[q, 0] = 11;
                        zodiac[q, 1] = 23;
                        break;
                }
            }
            //Console.WriteLine("Весы стартуют: " + zodiac[9, 1] + "." + zodiac[9, 0]);
        }
    }
}
