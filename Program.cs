using System;

namespace HW_04_04_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter con = new Converter(1000);
            con.showMoney();
        }
    }

    class Converter{
        public double smn{get;set;}
        public double usd{get;set;}
        public double eur{get;set;}
        public double rub{get;set;}

        public Converter(double somoni){
            this.smn = somoni;
            usd = smn/10.25;
            eur = smn/11.04;
            rub = smn/0.13;
        }
        public void showMoney(){
            System.Console.WriteLine("Сомони: "+smn);
            System.Console.WriteLine("Доллар: "+usd);
            System.Console.WriteLine("Евро: "+eur);
            System.Console.WriteLine("Рубль: "+rub);
        }


    }
}
