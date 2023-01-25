using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    //интерфейс
    public interface InterfaceCalc
    {
        //а - первый аргумент, b - второй
        void Put_A(double a); //сохранить а

        void Clear_A();

        double Multiplication(double b);

        double Division(double b);

        double Sum(double b);

        double Subtraction(double b); 

        double DegreeY(double b);

        double Ckn(double k);

        double Sqrt();

        double Square();

        double Factorial();
    }
}
