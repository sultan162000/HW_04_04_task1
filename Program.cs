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
        public double myBalance = 0;
        public string myCurrrens = " ";

        public double smn{get;set;}
        public string smnOfLatin = "Сомони";
        public double usd{get;set;}
        public string usdOfLatin = "Доллар";
        public double eur{get;set;}
        public string eurOfLatin = "Евро";
        public double rub{get;set;}
        public string rubOfLatin = "Рубль";


        public Converter(double somoni){
            smn = somoni;
            myBalance = smn;
            myCurrrens = smnOfLatin;
            startTheProject();
        }


        

        public void startTheProject(){
            bool check = true;
            while (check)
            {
                System.Console.WriteLine("1.Показать баланс\n2.Конвертировать\n3.Выход");
                int x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                    System.Console.WriteLine("Ваш баланс: "+myBalance +" "+myCurrrens);
                    break;

                    case 2:
                    bool check1 = true;
                    while(check1){
                    System.Console.WriteLine("1.Сомони\n2.USD\n3.EURO\n4.Ru\n5.Назад");
                    int n = int.Parse(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                        if (myCurrrens == smnOfLatin)
                        {
                            System.Console.WriteLine("Невозможно конвертировать");
                        }else if(myCurrrens == usdOfLatin){
                            myCurrrens = smnOfLatin;
                            myBalance = myBalance*10.22;
                            myBalance=Math.Round(myBalance);
                            System.Console.WriteLine(myBalance+" "+myCurrrens);
                        }else if(myCurrrens == eurOfLatin){
                            myCurrrens = smnOfLatin;
                            myBalance = myBalance*11.04;
                            myBalance=Math.Round(myBalance);
                            System.Console.WriteLine(myBalance+" "+myCurrrens);
                        }else if(myCurrrens == rubOfLatin){
                            myCurrrens = smnOfLatin;
                            myBalance = myBalance*0.1338;
                            myBalance=Math.Round(myBalance);
                            System.Console.WriteLine(myBalance+" "+myCurrrens);
                        }
                        break;

                        case 2:
                        if (myCurrrens == usdOfLatin)
                        {
                            System.Console.WriteLine("Невозможно конвертировать");
                        }else if(myCurrrens == smnOfLatin){
                            myCurrrens = usdOfLatin;
                            myBalance = myBalance/10.22;
                            myBalance=Math.Round(myBalance,5);
                            System.Console.WriteLine(myBalance+" "+myCurrrens);
                        }else if(myCurrrens == eurOfLatin){
                            myCurrrens = usdOfLatin;
                            myBalance = myBalance/1.08;
                            myBalance=Math.Round(myBalance, 5);
                            System.Console.WriteLine(myBalance+" "+myCurrrens);
                        }else if(myCurrrens == rubOfLatin){
                            myCurrrens = usdOfLatin;
                            myBalance = myBalance/76.41;
                            myBalance=Math.Round(myBalance, 5);
                            System.Console.WriteLine(myBalance+" "+myCurrrens);
                        }
                        break;

                        case 3:
                        if(myCurrrens == eurOfLatin){
                            System.Console.WriteLine("Невозможно конвертировать");
                        }else if(myCurrrens == usdOfLatin){
                            myCurrrens = eurOfLatin;
                            myBalance = myBalance/1.08;
                            myBalance=Math.Round(myBalance, 5);
                            System.Console.WriteLine(myBalance+" "+myCurrrens);
                        }else if(myCurrrens == smnOfLatin){
                            myCurrrens = eurOfLatin;
                            myBalance = myBalance/11.04;
                            myBalance=Math.Round(myBalance,5);
                            System.Console.WriteLine(myBalance+" "+myCurrrens);
                        }else if(myCurrrens == rubOfLatin){
                            myCurrrens = eurOfLatin;
                            myBalance = myBalance/82.56;
                            myBalance=Math.Round(myBalance, 5);
                            System.Console.WriteLine(myBalance+" "+myCurrrens);
                        }
                        break;

                        case 4:
                        if(myCurrrens == rubOfLatin){
                            System.Console.WriteLine("Невозможно конвертировать");
                        }else if(myCurrrens == usdOfLatin){
                            myCurrrens = rubOfLatin;
                            myBalance = myBalance*76.41;
                            System.Console.WriteLine(myBalance+" "+myCurrrens);
                        }
                        break;

                        case 5:
                        check1 = false;
                        break;
                        
                    }
                    }
                    break;

                    case 3:
                    check = false;
                    break;
                    
                }
            }
        }


        


    }

    
}

