namespace Session_09
{
    public partial class Form1 : Form
    {
        private decimal? _value1 = null;
        private decimal? _value2 = null;
        private decimal? _result = null;

        private Caloper _caloper;

        enum Caloper
        {
            Addition,
            Subtraction,
            Multiplication,
            Division,
            Raise_to_Power,
            Square_Root
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnclr_Click(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " 1 ";

            if (_value1 == null)
            {
                _value1 = 1;
            }
            else
            {
                _value2 = 1;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " 2 ";
        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {

        }

        private void btn8_Click(object sender, EventArgs e)
        {

        }

        private void btn9_Click(object sender, EventArgs e)
        {

        }

        private void btndec_Click(object sender, EventArgs e)
        {

        }

        private void btneq_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " = ";

            switch (_caloper)
            {
                case Caloper.Addition:
                    _result = _value1 + _value2;
                    break;
                case Caloper.Subtraction:
                    _result = _value1 - _value2;
                    break;
                default:
                    break;
            }
            ctrlDisplay.Text += _result;
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " + ";
            _caloper = Caloper.Addition;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " - ";
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " x ";
        }


        private void btndiv_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " / ";
        }

        private void btnsq_Click(object sender, EventArgs e)
        {

        }

        private void btnpow_Click(object sender, EventArgs e)
        {

        }

        private void ctrlDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void True(object sender, EventArgs e)
        {

        }
    }
}