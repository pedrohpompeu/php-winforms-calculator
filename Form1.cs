using exemplo.Classes;

namespace exemplo
{
    public partial class X : Form
    {
        operacoes op = new operacoes();
        
        public X()
        {
            InitializeComponent();
        }

        public void setImput()
        {
            op.SetXFromInput(Double.Parse(imputTextX.Text));
            op.SetYFromInput(Double.Parse(inputTextY.Text));
        }

        public void printResult(double X, double Y, string operacao, double result)
        {
            string saida = operacao;
            string saida2 = "" + result;

            labelOutPut.Visible = true;
            labelOutPut.Text = saida;

            label1.Visible = true;
            label1.Text = saida2;
        }

        public void printResultOO(double X, string operacao, double result)
        {
            string saida = operacao;
            string saida2 = "" + result;

            labelOutPut.Visible = true;
            labelOutPut.Text = saida;

            label1.Visible = true;
            label1.Text = saida2;
        }

        private void onSomaClick(object sender, EventArgs e)
        {
            setImput();
            double result = op.soma();
            printResult(op.getX(), op.gety(), "soma", result);
        }

        private void labelOutPut_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setImput();
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void inputTextY_TextChanged(object sender, EventArgs e)
        {

        }

        private void imputTextX_TextChanged(object sender, EventArgs e)
        {

        }

        private void soma_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            setImput();
            double result = op.sub();
            printResult(op.getX(), op.gety(), "sub", result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setImput();
            double result = op.mult();
            printResult(op.getX(), op.gety(), "mult", result);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            setImput();
            double result = op.div();
            printResult(op.getX(), op.gety(), "div", result);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setImput();
            double result = op.quadrado();
            printResultOO(op.getX(), "quadrado", result);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            setImput();
            double result = op.raiz();
            printResult(op.getX(), op.gety(), "raiz", result);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            setImput();
            double result = op.porcentagem();
            printResult(op.getX(), op.gety(), "porcentagem", result);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            setImput();
            double result = op.elevado();
            printResult(op.getX(), op.gety(), "elevado", result);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
