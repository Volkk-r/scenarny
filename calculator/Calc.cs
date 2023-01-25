using NLua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    //класс, реализующий интерфейс InterfaceCalc
    public class Calc : InterfaceCalc
    {
        private double a = 0;
        private string localpath = "C:\\Projects\\C#\\calculator\\calculator\\CalcFunctions.lua";

        public void Put_A(double a)
        {
            this.a = a;
        }

        public void Clear_A()
        {
            a = 0;
        }

        public double Multiplication(double b)
        {
            return a * b;
        }

        public double Division(double b)
        {
            return a / b;
        }

        public double Sum(double b)
        {
            return a + b;

        }

        public double Subtraction(double b) 
        {
            return a - b;
        }

        public double DegreeY(double b)
        {
            return Math.Pow(a, b);
        }

        public double Sqrt()
        {
            return Math.Sqrt(a);
        }

        public double Square()
        {
            return Math.Pow(a, 2.0);
        }

        public double Factorial()
        {
            using (Lua luaState = new Lua())
            {
                luaState.DoFile(localpath);
                
                LuaFunction factorial = luaState["fact"] as LuaFunction;
                var result = Convert.ToDouble(factorial.Call(a)[0]);
                Console.WriteLine(result);
                return Convert.ToDouble(result);
            }
        }

        public double Ckn(double k)
        {
            throw new NotImplementedException();
        }
    }
}
