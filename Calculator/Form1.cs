using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double numberInMemory;
        bool isEmptyLabel;

        public Form1()
        {
            InitializeComponent();
        }

        private void InsertToLabel(string str)
        {
            Label_Calculation.Text += str;
        }
        private void ClearLabel(string startedStr, bool emptyLabel)
        {
            Label_Calculation.Text = startedStr;
            isEmptyLabel = emptyLabel;
        }

        private bool IsEnterOperator()
        {
            int lastOperator = Label_Calculation.Text.LastIndexOfAny("+-*/".ToCharArray());
            int lastComma = Label_Calculation.Text.LastIndexOf(',');

            int length = Label_Calculation.Text.Length - 1;

            return lastOperator != length && lastComma != length;
        }
        private bool IsEnterComma()
        {
            int lastOperator = Label_Calculation.Text.LastIndexOfAny("+-*/".ToCharArray());
            int lastComma = Label_Calculation.Text.LastIndexOf(',');

            int length = Label_Calculation.Text.Length - 1;

            return lastOperator >= lastComma && lastOperator != length;
        }

        private void Calculate()
        {
            string expression = GetExpression(Label_Calculation.Text);

            Label_Calculation.Text = Counting(expression);
            isEmptyLabel = false;
        }

        private string GetExpression(string str)
        {
            Stack<char> operators = new Stack<char>();
            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (IsSpace(str[i]))
                    continue;

                if (IsDigit(str[i]))
                {
                    while (!IsSpace(str[i]) && !IsOperator(str[i]))
                    {
                        result += str[i++];

                        if (i == str.Length)
                            break;
                    }

                    result += " ";
                    i--;
                }

                if (IsOperator(str[i]))
                {
                    if (operators.Count > 0)
                        if (GetPriority(str[i]) <= GetPriority(operators.Peek()))
                            result += string.Format("{0} ", operators.Pop());

                    operators.Push(char.Parse(str[i].ToString()));
                }
            }

            while (operators.Count > 0)
                result += string.Format("{0} ", operators.Pop());

            return result;
        }
        private string Counting(string expression)
        {
            Stack<double> result = new Stack<double>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (IsDigit(expression[i]))
                {
                    string number = "";

                    while (!IsSpace(expression[i]) && !IsOperator(expression[i]))
                    {
                        number += expression[i++];

                        if (i == expression.Length)
                            break;
                    }

                    result.Push(double.Parse(number));
                    i--;
                }
                else if (IsOperator(expression[i]))
                {
                    if (result.Count > 1)
                    {
                        double a = result.Pop();
                        double b = result.Pop();

                        double tempResult = 0;

                        switch (expression[i])
                        {
                            case '+': tempResult = b + a; break;
                            case '-': tempResult = b - a; break;
                            case '*': tempResult = b * a; break;
                            case '/':
                                {
                                    if (a != 0 && b != 0)
                                        tempResult = b / a;
                                }
                                break;
                        }

                        result.Push(tempResult);
                    }

                }
            }

            return result.Peek().ToString();
        }
        
        private byte GetPriority(char symbol)
        {
            switch (symbol)
            {
                case '+': return 0;
                case '-': return 1;
                case '*': return 2;
                case '/': return 3;
                default: return 4;
            }
        }
        private bool IsOperator(char symbol)
        {
            return "+-*/".IndexOf(symbol) != -1;
        }
        private bool IsSpace(char symbol)
        {
            return symbol == ' ';            
        }
        private bool IsDigit(char symbol)
        {
            return Char.IsDigit(symbol);
        }

        private void Button_0_Click(object sender, EventArgs e)
        {
            if (!isEmptyLabel)
                ClearLabel("", true);

            InsertToLabel("0");
        }
        private void Button_1_Click(object sender, EventArgs e)
        {
            if (!isEmptyLabel)
                ClearLabel("", true);

            InsertToLabel("1");
        }
        private void Button_2_Click(object sender, EventArgs e)
        {
            if (!isEmptyLabel)
                ClearLabel("", true);

            InsertToLabel("2");
        }
        private void Button_3_Click(object sender, EventArgs e)
        {
            if (!isEmptyLabel)
                ClearLabel("", true);

            InsertToLabel("3");
        }
        private void Button_4_Click(object sender, EventArgs e)
        {
            if (!isEmptyLabel)
                ClearLabel("", true);

            InsertToLabel("4");
        }
        private void Button_5_Click(object sender, EventArgs e)
        {
            if (!isEmptyLabel)
                ClearLabel("", true);

            InsertToLabel("5");
        }
        private void Button_6_Click(object sender, EventArgs e)
        {
            if (!isEmptyLabel)
                ClearLabel("", true);

            InsertToLabel("6");
        }
        private void Button_7_Click(object sender, EventArgs e)
        {
            if (!isEmptyLabel)
                ClearLabel("", true);

            InsertToLabel("7");
        }
        private void Button_8_Click(object sender, EventArgs e)
        {
            if (!isEmptyLabel)
                ClearLabel("", true);

            InsertToLabel("8");
        }
        private void Button_9_Click(object sender, EventArgs e)
        {
            if (!isEmptyLabel)
                ClearLabel("", true);

            InsertToLabel("9");
        }

        private void Button_Plus_Click(object sender, EventArgs e)
        {
            if (IsEnterOperator())
                InsertToLabel("+");
        }
        private void Button_Minus_Click(object sender, EventArgs e)
        {
            if (IsEnterOperator())
                InsertToLabel("-");
        }
        private void Button_Multiply_Click(object sender, EventArgs e)
        {
            if (IsEnterOperator())
                InsertToLabel("*");
        }
        private void Button_Divide_Click(object sender, EventArgs e)
        {
            if (IsEnterOperator())
                InsertToLabel("/");
        }
        private void Button_Comma_Click(object sender, EventArgs e)
        {
            if (IsEnterComma())
            {
                InsertToLabel(",");
                isEmptyLabel = true;
            }
        }
        
        private void Button_Sqrt_Click(object sender, EventArgs e)
        {
            Calculate();

            double number = double.Parse(Label_Calculation.Text);
            string result = Math.Sqrt(number).ToString();

            Label_Calculation.Text = result;
        }
        private void Button_Percent_Click(object sender, EventArgs e)
        {

        }
        private void Button_Reciprocal_Click(object sender, EventArgs e)
        {
            Calculate();

            double number = double.Parse(Label_Calculation.Text);
            string result = (1 / number).ToString();

            Label_Calculation.Text = result;
        }
        private void Button_PlusMinus_Click(object sender, EventArgs e)
        {

        }

        private void Button_CE_Click(object sender, EventArgs e)
        {
            int startIndex = Label_Calculation.Text.Length - 1;
            int endIndex = Label_Calculation.Text.LastIndexOfAny("+-*/".ToCharArray(), startIndex);

            if (startIndex != endIndex && endIndex != -1)
                Label_Calculation.Text = Label_Calculation.Text.Remove(endIndex + 1);
            else
                ClearLabel("0", false);
        }
        private void Button_C_Click(object sender, EventArgs e)
        {
            ClearLabel("0", false);
        }

        private void Button_MC_Click(object sender, EventArgs e)
        {
            numberInMemory = 0;
        }
        private void Button_MR_Click(object sender, EventArgs e)
        {
            Label_Calculation.Text = numberInMemory.ToString();
        }
        private void Button_MS_Click(object sender, EventArgs e)
        {
            Calculate();

            numberInMemory = double.Parse(Label_Calculation.Text);
        }
        private void Button_MPlus_Click(object sender, EventArgs e)
        {
            Calculate();

            double number = double.Parse(Label_Calculation.Text);

            numberInMemory = numberInMemory + number;
        }
        private void Button_MMinus_Click(object sender, EventArgs e)
        {
            Calculate();

            double number = double.Parse(Label_Calculation.Text);

            numberInMemory = numberInMemory - number;
        }

        private void Button_Remove_Click(object sender, EventArgs e)
        {
            if (Label_Calculation.Text.Length > 0)
            {
                int startIndex = Label_Calculation.Text.Length - 1;
                
                Label_Calculation.Text = Label_Calculation.Text.Remove(startIndex, 1);

                if (Label_Calculation.Text == "")
                    ClearLabel("0", false);
            }            
        }
        private void Button_Result_Click(object sender, EventArgs e)
        {
                Calculate();
        }
    }
}
