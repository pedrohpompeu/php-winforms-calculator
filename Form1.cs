using Exemplo.Classes;
using System.Security.Cryptography;

namespace Exemplo
{
    public partial class Form1 : Form
    {
        Operacoes op;
        public Form1()
        {
            InitializeComponent();
            op = new Operacoes();

        }

        public void setInputs()
        {
            op.setXFromInput(double.Parse(inputTextX.Text));
            op.setYFromInput(double.Parse(inputTextY.Text));
        }
        public void printResult(double x, double y, string operacao, double result)
        {
            string formatoSaida = x + " " + operacao + " " + y + " = ";
            labelOutput.Visible = true;
            labelOutput.Text = formatoSaida;
            labelResult.Visible = true;
            labelResult.Text = result.ToString();
        }

        public void printResultOO(double x, string operacao, double result)
        {
            string formatoSaida = x + " " + operacao + " " + " = ";
            labelOutput.Visible = true;
            labelOutput.Text = formatoSaida;
            labelResult.Visible = true;
            labelResult.Text = result.ToString();
        }

        public void cleanInputs()
        {

        }

        private void onSomaClick(object sender, EventArgs e)
        {
            setInputs();
            double result = op.soma();
            printResult(op.getX(), op.getY(), "+", result);
        }

        private void labelOutput_Click(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            setInputs();
            double result = op.sub();
            printResult(op.getX(), op.getY(), "-", result);
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            setInputs();
            double result = op.mult();
            printResult(op.getX(), op.getY(), "x", result);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            setInputs();
            double result = op.div();
            printResult(op.getX(), op.getY(), "÷", result);
        }

        private void btnDobro_Click(object sender, EventArgs e)
        {
            op.setXFromInput(double.Parse(inputTextX.Text));
            double result = op.quadrado();
            printResultOO(op.getX(), "²", result);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            setInputs();
            double result = op.elevado();
            printResult(op.getX(), op.getY(), "^", result);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            op.setXFromInput(double.Parse(inputTextX.Text));
            double result = op.binary();
            printResultOO(op.getX(), "Binary", result);
        }
    }
}
