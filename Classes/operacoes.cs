using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo.Classes
{
    internal class operacoes
    {
        double x, y;
        public operacoes() { 
            x = 0; y = 0;
        }

        public void SetXFromInput (double x)
        {
            this.x = x;
        }

        public void SetYFromInput (double y)
        {
            this.y = y;
        }

        public double getX()
        {
            return this.x;
        }

        public double gety()
        {
            return this.y;
        }

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
            return this.x / this.y;
        }

        public double quadrado() 
        { 
            return this.x * this.x;
        }

        public double porcentagem()
        {
            return (this.x * this.y) / 100;
        }

        public double elevado()
        {
            return Math.Pow(this.x, this.y);
        }

        public double raiz()
        {
            return Math.Sqrt(this.x);
        }

        public double binario()
        {
            return 0;
        }
    }
}
