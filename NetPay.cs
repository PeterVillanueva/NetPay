using System;

namespace NetPay
{
    class NetPay
    {
        static void Main(string[] args)
        {
            string name, sNumberHrsWork, sDailyRate;
            double daily = 8, tax = 0.25, dNumberHrsWork, dDailyRate, NetPay, tDailyRate, tNumberHrsWork;

            Console.Write("What is your name? ");
            name = Console.ReadLine();

            Console.Write("Number of Hours Work? ");
            sNumberHrsWork = Console.ReadLine();
            dNumberHrsWork = Convert.ToDouble(sNumberHrsWork);

            Console.Write("Your Daily Rate? ");
            sDailyRate = Console.ReadLine();
            dDailyRate = Convert.ToDouble(sDailyRate);



            //Salamat
            tNumberHrsWork = dNumberHrsWork / daily;


            //sa
            dDailyRate = dDailyRate / daily;
            tDailyRate = dDailyRate * daily;


            //Code
            NetPay = tDailyRate * tax;
            NetPay = NetPay - tDailyRate;

            //Credits: Fel Galarpe
            NetPay = Math.Abs(NetPay);

            Console.WriteLine("Your Number of Hours Worked is " + dNumberHrsWork + ", your Daily Rate is " + tDailyRate + " and the tax is 25% so your Net Pay is = " + NetPay);

        }
    }
}
// sea shark C#