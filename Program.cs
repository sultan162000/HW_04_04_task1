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
        public double smn{get; set;}
        public string smnOfcur= "Сомони";

        public Converter(double somoni){
            smn = somoni;
            startTheProject();
        }

        public void showMoney(double ind,string curr){
            System.Console.WriteLine(curr+": "+ind);
        }

        public void ConvertSmnToOther(){
            System.Console.WriteLine("-----");
        }

        public void startTheProject(){
            bool check = true;
            while (check)
            {
                System.Console.WriteLine("1.Показать счет\n2.Конвертировать в валюту...\n3.Выйти из программ");
                int x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                    System.Console.WriteLine("---------");
                    break;
                    case 2:
                    System.Console.WriteLine("----------");
                    break;
                    case 3:
                    check = false;
                    break;
                }
            }
        }
        


    }

    
}

