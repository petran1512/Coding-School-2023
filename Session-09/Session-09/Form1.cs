using CalculatorLibrary;

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
            Raise_To_Power,
            Square_Root,
            Raise_To_power
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnclr_Click(object sender, EventArgs e)
        {

            ctrlDisplay.Text = string.Empty;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {
                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += " 0 ";

            if (_value1 == null)
            {
                _value1 = 0;
            }
            else
            {
                _value2 = 0;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            if (_result != null)
            {
                ctrlDisplay.Text= string.Empty;
                _value1= null;
                _value2= null;
                _result= null;
            }

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
            if (_result != null)
            {
                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += " 2 ";

            if (_value1 == null)
            {
                _value1 = 2;
            }
            else
            {
                _value2 = 2;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {
                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += " 3 ";

            if (_value1 == null)
            {
                _value1 = 3;
            }
            else
            {
                _value2 = 3;
            }

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {
                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += " 4 ";

            if (_value1 == null)
            {
                _value1 = 4;
            }
            else
            {
                _value2 = 4;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {
                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += " 5 ";

            if (_value1 == null)
            {
                _value1 = 5;
            }
            else
            {
                _value2 = 5;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {
                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += " 6 ";

            if (_value1 == null)
            {
                _value1 = 6;
            }
            else
            {
                _value2 = 6;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {
                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += " 7 ";

            if (_value1 == null)
            {
                _value1 = 7;
            }
            else
            {
                _value2 = 7;
            }

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {
                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += " 8 ";

            if (_value1 == null)
            {
                _value1 = 8;
            }
            else
            {
                _value2 = 8;
            }

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {
                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += " 9 ";

            if (_value1 == null)
            {
                _value1 = 9;
            }
            else
            {
                _value2 = 9;
            }

        }

        private void btndec_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {
                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += ".";

            if (_value1 == null)
            {
                _value1 = 0;
            }
            else
            {
                _value2 = 0;
            }
        }

        private void btneq_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " = ";

            switch (_caloper)
            {
                case Caloper.Addition:

                    Addition addition= new Addition();
                    _result = addition.Do(_value1.Value, _value2.Value);
                    break;
                case Caloper.Subtraction:

                    Subtraction subtraction = new Subtraction();
                    _result = subtraction.Do(_value1.Value, _value2.Value);
                    break;
                case Caloper.Multiplication:

                    Multiplication multiplication = new Multiplication();
                    _result = multiplication.Do(_value1.Value, _value2.Value);
                    break;
                case Caloper.Division:

                    Division division = new Division();
                    _result = division.Do(_value1.Value, _value2.Value);
                    break;
                case Caloper.Square_Root:

                    Square_Root square_Root = new Square_Root();
                    _result = square_Root.Do(_value1.Value);
                    break;
                case Caloper.Raise_To_power:

                    Raise_to_Power raise_to_power = new Raise_to_Power();
                    _result = raise_to_power.Do(_value1.Value);
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
            _caloper = Caloper.Subtraction;
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " x ";
            _caloper = Caloper.Multiplication;
        }


        private void btndiv_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " / ";
            _caloper = Caloper.Division;

        }

        private void btnsq_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " √ ";
            _caloper = Caloper.Square_Root;

        }

        private void btnpow_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " ^ ";
            _caloper = Caloper.Raise_To_Power;

        }

        private void ctrlDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void True(object sender, EventArgs e)
        {

        }
    }
}