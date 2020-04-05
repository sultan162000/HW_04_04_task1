using System;

namespace HW_04_04_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter con = new Converter(1000);
            
        }
    }

    class Converter{
        CurrensSomoni cursmn = new CurrensSomoni();

        public Converter(double somoni){
            
            cursmn.smn = somoni;
            startTheProject();
        }


        

        public void startTheProject(){
            bool check = true;
            while (check)
            {
                System.Console.WriteLine("1.Конверть валют\n2.Выход");
                int x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                    System.Console.WriteLine("1.USD\n2.EURO\n3.RU");
                    int n = int.Parse(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                        CurrensUsd curusd = new CurrensUsd(){usd = cursmn.smn/10.23};
                        System.Console.WriteLine(curusd.usd);
                        break;
                        
                    }
                    break;

                    case 2:
                    check = false;
                    break;
                    
                }
            }
        }


        


    }

    class CurrensSomoni{
        public double smn{get;set;}
        public string smnOfLatin = "Сомони";
    
    }
    class CurrensUsd{
        public double usd{get;set;}
        public string usdOfLatin = "Доллар";
    }

    
}

