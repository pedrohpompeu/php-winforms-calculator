using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo.Classes
{
    internal class Operacoes
    {
        double x, y;
        public Operacoes()
        {
            x = 0; y = 0;
        }

        //Getters e Setters

        public void setXFromInput(double x)
        {
            this.x = x;
        }

        public double getX()
        {
            return this.x;
        }

        public void setYFromInput(double y)
        {
            this.y = y;
        }

        public double getY()
        {
            return this.y;
        }

        //Operações

        public double soma()
        {
            return this.x + this.y;
        }

        public double sub()
        {
            return this.x - this.y;
        }

        public double mult()
        {
            return this.x * this.y;
        }

        public double div()
        {
            if (this.y == 0)
            {
                return 0;
            }
            else
            {
                return this.x / this.y;
            }
        }

        public double quadrado()
        {
            return (this.x * this.x);
        }

        public double elevado()
        {
            int cont = 0;
            double result = this.x;

            while (cont < (this.y - 1))
            {
                result *= this.x;
                cont++;
            }
            return result;
        }

        public int binary()
        {
            long value = (long)this.x;
            if (value <= 0)
            {
                return 0000;
            }
            else
            {
                string resto = "";
                while (value > 0)
                {
                    resto += value % 2;
                    value = value / 2;
                }
                string resultBinary = "";
                for (int i = resto.Length - 1; i >= 0; i--)
                {
                    resultBinary += resto[i];
                }
                return int.Parse(resultBinary);
            }
        }
    }
}
