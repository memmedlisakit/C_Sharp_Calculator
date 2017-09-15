using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProgram
{
    class Calculator
    {
        private double firstInput;
        private double seconInput;
        private double cem;

        private string line;
        private string calc;


        public void strat()
        {
            this.input();
            this.inputCalc();
            this.result();
        }


        private void input()
        {
            //for input first number from user
            Console.Write("birinci eded daxil edin: ");
            this.line = Console.ReadLine();
            while (!double.TryParse(this.line, out this.firstInput))
            {
                Console.Write("duzgun eded daxil edin: ");
                this.line = Console.ReadLine();
            }
            this.firstInput = Convert.ToDouble(this.line);
            Console.WriteLine("girilen deyer: {0}", this.firstInput);



            //for input secon number from user
            Console.Write("ikinci ededi daxil edin: ");
            this.line = Console.ReadLine();
            while (!double.TryParse(this.line, out this.seconInput))
            {
                Console.Write("duzgun eded daxil edin: ");
                this.line = Console.ReadLine();
            }
            this.seconInput = Convert.ToDouble(this.line);
        }


        private void inputCalc()
        {
            Console.Write("toplama (\"T\"), cixma (\"C\"), vurma (\"V\"), bolme (\"B\") emeliyyati edmek uchun birini secin: ");
            this.calc = Console.ReadLine();

            while (this.calc != "T" && this.calc != "C" && this.calc != "V" && this.calc != "B")
            {
                Console.Write("duzgun secim daxil edin: ");
                this.calc = Console.ReadLine();
            }
            switch (calc)
            {
                case "T":
                    this.cem = this.firstInput + this.seconInput;
                    break;

                case "C":
                    this.cem = this.firstInput - this.seconInput;
                    break;

                case "V":
                    this.cem = this.firstInput * this.seconInput;
                    break;

                case "B":
                    this.cem = this.firstInput / this.seconInput;
                    break;

            }




        }

        private void result()
        {
            Console.WriteLine("cavab: {0}", this.cem);
        }
    }
}
