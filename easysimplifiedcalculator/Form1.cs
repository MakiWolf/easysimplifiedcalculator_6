using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace easysimplifiedcalculator
{
    public partial class Form1 : Form
    {

        public double number1;
        public double number2;
        public double nothing;
        public double result;
        public double result1;
        public double result2;
        public string char1;
        public string percent;
        public string test;
        public string test11;
        public string continuecalculation;

        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
           
            input.Text = input.Text + "0";

            if (nothing == 1)
            {
                if (test == "1")
                {
                    input.Text = input.Text;
                }
                else
                {
                    input.Text = "";
                    test = "1";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + "1";

            if (nothing == 1)
            {
                
                if (test=="1") {
                    input.Text =  input.Text ;
                }
                else
                {
                    input.Text = "";
                    test = "1";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + "2";
            if (nothing == 1)
            {
                if (test == "1")
                {
                    input.Text = input.Text;
                }
                else
                {
                    input.Text = "";
                    test = "1";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + "3";
            if (nothing == 1)
            {
                if (test == "1")
                {
                    input.Text = input.Text;
                }
                else
                {
                    input.Text = "";
                    test = "1";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + "4";

            if (nothing == 1)
            {
                if (test == "1")
                {
                    input.Text = input.Text;
                }
                else
                {
                    input.Text = "";
                    test = "1";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + "5";

            if (nothing == 1)
            {
                if (test == "1")
                {
                    input.Text = input.Text;
                }
                else
                {
                    input.Text = "";
                    test = "1";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + "6";

            if (nothing == 1)
            {

                if (test == "1")
                {
                    input.Text = input.Text;
                }
                else
                {
                    input.Text = "";
                    test = "1";
                }
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + "7";

            if (nothing == 1)
            {

                if (test == "1")
                {
                    input.Text = input.Text;
                }
                else
                {
                    input.Text = "";
                    test = "1";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + "8";

            if (nothing == 1)
            {
                if (test == "1")
                {
                    input.Text = input.Text;
                }
                else
                {
                    input.Text = "";
                    test = "1";
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + "9";

            if (nothing == 1)
            {
                if (test == "1")
                {
                    input.Text = input.Text;
                }
                else
                {
                    input.Text = "";
                    test = "1";
                }
            }
        }

        private void percentbutton_Click(object sender, EventArgs e)
        {
            
            try
            {
                percent = "1";
                number2 = Convert.ToDouble(input.Text);
            }
            catch
            {
                input.Text = "Falsche Eingabe!";
            }

        }

        private void durch_Click(object sender, EventArgs e)
        {
            try
            {
                double durch = Convert.ToDouble(input.Text);
                //um das was in der Eingabe steht zu dividieren also 1 / das was in der Textbox steht
                input.Text = Convert.ToString(1 / (durch));
                nothing = 1;
            }
            catch {
                input.Text = "Falsche Eingabe!";
            }
        }

        private void comma_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + ",";
        }

        private void minusbutton_Click(object sender, EventArgs e)
        {
            input.Text = "-" + input.Text;
        }

        private void pi_Click(object sender, EventArgs e)
        {
            //um in die Eingabe die Zahl pi einzusetzen
            input.Text = Convert.ToString(Math.PI);
        }

        //Rechenzeichen.Text wird fuer den Switch spaeter benoetigt
        //eingabe2.Text dient dazu den Text in das obere Feld einzutragen und dann wieder in das untere Feled keinen Text einzutragen

        private void plus_Click(object sender, EventArgs e)
        {
            try
            {
                char1 = "+";
                number1 = Convert.ToDouble(input.Text);
                input.Text = "";
                test11 = "1";
            }
            catch
            {
                input.Text = "Zwei Rechenzeichen!";
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            try
                {
                char1 = "-";
                number1 = Convert.ToDouble(input.Text);
                input.Text = "";
                test11 = "1";
            }
            catch
                {
                input.Text = "Zwei Rechenzeichen!"; 
                }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            try
            {
                char1 = "*";
                number1 = Convert.ToDouble(input.Text);
                input.Text = "";

            }
            catch
            {
                input.Text = "Zwei Rechenzeichen!";

            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            try
            {
                char1 = "/";
                number1 = Convert.ToDouble(input.Text);
                input.Text = "";
            }
            catch
            {
                input.Text = "Zwei Rechenzeichen!";
            }
        }

        //ab hier wird dann fuer eingabe.Text, 0 eingesetzt, um nicht mit falscher Eingabe zu enden

        private void sin_Click(object sender, EventArgs e)
        {
            try
            {
                char1 = "sin";
                number2 = Convert.ToDouble(input.Text);
                
            }
            catch
            {
                input.Text = "Falsche Eingabe!";
            }
        }

        private void cos_Click(object sender, EventArgs e)
        {
            try
            {
                char1 = "cos";
                number2 = Convert.ToDouble(input.Text);
               
            }
            catch
            {
                input.Text = "Falsche Eingabe!";
            }
        }

        private void tan_Click(object sender, EventArgs e)
        {
            try
            {
                char1 = "tan";
                number2 = Convert.ToDouble(input.Text);
                
            }
            catch
            {
                input.Text = "Falsche Eingabe!";
            }
        }
        private void sqrt_Click(object sender, EventArgs e)
        {
            try { 
                char1 = "sqrt";
                number1 = Convert.ToDouble(input.Text);
                
                }
            catch
                {
                input.Text = "Falsche Eingabe!";
                }
        }

        private void sqr_Click(object sender, EventArgs e)
        {
            try { 
                char1 = "sqr";
                number1 = Convert.ToDouble(input.Text);
                
                }
            catch
                {
                input.Text = "Falsche Eingabe!";
                }
        }

        private void calculate_Click(object sender, EventArgs e)
        {

            try
            {

                // string rechenzeichen1 = Convert.ToString(rechenzeichen.Text);
                //  double zahl1 = Convert.ToDouble(eingabe2.Text);

                double zahl2 = Convert.ToDouble(input.Text);
                if (percent == "1")
                {
                    //eingabe.Text = zahl2 + "%";
                }
               
                  
                    result = 0; //um dem Ergebnis einen Wert zuzuweisen damit es funktioniert
                
                    
                

                switch (char1)

                {
                    case "+":                        
                        if (percent == "1")
                        {
                            result = number1 + (number1 / 100 * zahl2);
                            char1 = "++";
                            
                            result1 = Convert.ToDouble(input.Text);
                            result2 = (number1 / 100 * zahl2);

                        }
                        else
                        {
                            calculation_class calc = new calculation_class();
                            result = calc.add(number1, zahl2);


                            char1 = "++";
                            result1 = Convert.ToDouble(input.Text);

                        }
                        nothing = 1;
                        break;

                    case "++": //fuer nochmals die = Taste
                        if (percent == "1")
                        {
                            calculation_class calc = new calculation_class();
                            result = calc.add(number1, zahl2);
                        }
                        else
                        {
                            calculation_class calc = new calculation_class();
                            result = calc.add(number1, zahl2);
                            char1 = "++";

                        }
                        nothing = 1;
                        break;


                    case "-":                        
                        if (percent == "1")
                        {
                            result = number1 - (number1 / 100 * zahl2);
                            char1 = "--";
                            result1 = Convert.ToDouble(input.Text);
                        }
                        else
                        {
                            calculation_class calc = new calculation_class();
                            result = calc.sub(number1, zahl2);
                            char1 = "--";
                            result1 = Convert.ToDouble(input.Text);
                        }
                        nothing = 1;
                        break;

                    case "--": //fuer nochmals die = Taste
                        if (percent == "1")
                        {
                            calculation_class calc = new calculation_class();
                            result = calc.sub(number1, zahl2);
                        }
                        else
                        {
                            calculation_class calc = new calculation_class();
                            result = calc.sub(number1, zahl2);
                            char1 = "--";

                        }
                        nothing = 1;
                        break;

                    case "/":                      
                        if (percent == "1")
                        {
                            result = number1 / (number1 / 100 * zahl2);
                        }
                        else
                        {
                            calculation_class calc = new calculation_class();
                            result = calc.div(number1, zahl2);
                            char1 = "//";
                            result1 = Convert.ToDouble(input.Text);
                        }
                        nothing = 1;
                        break;

                    case "//": //fuer nochmals die = Taste
                        if (percent == "1")
                        {
                            result = result1 - result2;
                        }
                        else
                        {
                            calculation_class calc = new calculation_class();
                            result = calc.div(number1, zahl2);
                            char1 = "//";

                        }
                        nothing = 1;
                        break;

                    case "*":                        
                        if (percent == "1")
                        {
                            result = number1 * (number1 / 100 * zahl2);
                        }
                        else
                        {
                           
                            result = number1 * zahl2;
                            char1 = "**";
                            result1 = Convert.ToDouble(input.Text);

                        }
                        nothing = 1;
                        break;

                    case "**": //fuer nochmals die = Taste
                        if (percent == "1")
                        {
                            result = result1 - result2;
                        }
                        else
                        {
                            result = zahl2 * result1;
                            char1 = "**";

                        }
                        nothing = 1;
                        break;

                    //Winkelfunktionen
                    case "sin":
                        number1 = zahl2 * Math.PI / 180.0;
                        result = Math.Round(Math.Sin(number1), 4);
                        if (percent == "1")
                        {
                            result = Convert.ToDouble("Falsche Eingabe");
                        }
                        nothing = 1;
                        break;

                    case "cos":
                        number1 = zahl2 * Math.PI / 180.0;
                        result = Math.Round(Math.Cos(number1), 4);
                        if (percent == "1")
                        {
                            result = Convert.ToDouble("Falsche Eingabe");
                        }
                        nothing = 1;
                        break;

                    case "tan":
                        number1 = zahl2 * Math.PI / 180.0;
                        result = Math.Round(Math.Tan(number1), 4);
                        if (percent == "1")
                        {
                            result = Convert.ToDouble("Falsche Eingabe");
                        }
                        nothing = 1;
                        break;

                    case "sqrt":
                        result = Math.Sqrt(number1);
                        nothing = 1;
                        break;

                    case "sqr":
                        result = number1 *number1;
                        nothing = 1;
                        break;

                    //case "Prozent":
                    //    erg = zahl1 -(zahl1 / 100 * zahl2);
                    //    nichts = 1;
                    //    break;

                    default:
                        input.Text = "Das Rechenzeichen ist in diesem Rechner unbekannt!";
                        break;
                        
                }
                input.Text = Convert.ToString(result);

            }
            catch
            {
                input.Text = "Falsche Eingabe!"; 

            }            
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (input.Text.Length > 0) {
                input.Text = input.Text.Substring(0, input.Text.Length - 1);
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            nothing = 0;
            percent = "0";
            input.Text = "";
            input.Text = input.Text;
        }
    }
    }