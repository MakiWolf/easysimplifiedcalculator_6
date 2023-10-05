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

        public double zahl1;
        public double zahl2;
        public double nichts;
        public double erg;
        public double erg1;
        public double erg2;
        public string rechenzeichen1;
        public string prozentrechnen;
        public string test;
        public string test11;
        public string weiterrechnen;

        public Form1()
        {
            InitializeComponent();
        }

        private void MR_Click(object sender, EventArgs e)
        {
            nichts = 0;
            prozentrechnen = "0";
            eingabe.Text = "";
            eingabe.Text = eingabe.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            //die folgenden Buttons mit den Zahlen von 0 bis 9 dienen dazu um der Eingabe immer eine neue Zahl anzuhaengen
            eingabe.Text = eingabe.Text + "0";

            if (nichts == 1)
            {
                if (test == "1")
                {
                    eingabe.Text = eingabe.Text;
                }
                else
                {
                    eingabe.Text = "";
                    test = "1";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eingabe.Text = eingabe.Text + "1";

            if (nichts == 1)
            {
                
                if (test=="1") {
                    eingabe.Text =  eingabe.Text ;
                }
                else
                {
                    eingabe.Text = "";
                    test = "1";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eingabe.Text = eingabe.Text + "2";
            if (nichts == 1)
            {
                if (test == "1")
                {
                    eingabe.Text = eingabe.Text;
                }
                else
                {
                    eingabe.Text = "";
                    test = "1";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            eingabe.Text = eingabe.Text + "3";
            if (nichts == 1)
            {
                if (test == "1")
                {
                    eingabe.Text = eingabe.Text;
                }
                else
                {
                    eingabe.Text = "";
                    test = "1";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            eingabe.Text = eingabe.Text + "4";

            if (nichts == 1)
            {
                if (test == "1")
                {
                    eingabe.Text = eingabe.Text;
                }
                else
                {
                    eingabe.Text = "";
                    test = "1";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            eingabe.Text = eingabe.Text + "5";

            if (nichts == 1)
            {
                if (test == "1")
                {
                    eingabe.Text = eingabe.Text;
                }
                else
                {
                    eingabe.Text = "";
                    test = "1";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            eingabe.Text = eingabe.Text + "6";

            if (nichts == 1)
            {

                if (test == "1")
                {
                    eingabe.Text = eingabe.Text;
                }
                else
                {
                    eingabe.Text = "";
                    test = "1";
                }
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            eingabe.Text = eingabe.Text + "7";

            if (nichts == 1)
            {

                if (test == "1")
                {
                    eingabe.Text = eingabe.Text;
                }
                else
                {
                    eingabe.Text = "";
                    test = "1";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            eingabe.Text = eingabe.Text + "8";

            if (nichts == 1)
            {
                if (test == "1")
                {
                    eingabe.Text = eingabe.Text;
                }
                else
                {
                    eingabe.Text = "";
                    test = "1";
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            eingabe.Text = eingabe.Text + "9";

            if (nichts == 1)
            {
                if (test == "1")
                {
                    eingabe.Text = eingabe.Text;
                }
                else
                {
                    eingabe.Text = "";
                    test = "1";
                }
            }
        }

        private void prozent_Click(object sender, EventArgs e)
        {
            
            try
            {
                //rechenzeichen1 = "Prozent";
                prozentrechnen = "1";
                zahl2 = Convert.ToDouble(eingabe.Text);
                
                //eingabe.Text = "";
                //test11 = "1";
               // eingabe.Text = Convert.ToString(zahl1 / 100 * zahl2);
            }
            catch
            {
                eingabe.Text = "Falsche Eingabe!";
            }


            //eingabe.Text = eingabe.Text + "%";
            // 200/100*20
        }

        private void durch_Click(object sender, EventArgs e)
        {
            double durch = Convert.ToDouble( eingabe.Text);
            //um das was in der Eingabe steht zu dividieren also 1 / das was in der Textbox steht
            eingabe.Text = Convert.ToString( 1 / (durch));
            nichts = 1;            
        }

        private void komma_Click(object sender, EventArgs e)
        {
            // um der Eingabe ein Komma hinzuzufuegen
            eingabe.Text = eingabe.Text + ",";
        }

        private void minusTaste_Click(object sender, EventArgs e)
        {
            // um vor der Eingabe ein minus hinzuzufuegen
            eingabe.Text = "-" + eingabe.Text;
        }

        private void pi_Click(object sender, EventArgs e)
        {
            //um in die Eingabe die Zahl pi einzusetzen
            eingabe.Text = Convert.ToString(Math.PI);
        }

        //Rechenzeichen.Text wird fuer den Switch spaeter benoetigt
        //eingabe2.Text dient dazu den Text in das obere Feld einzutragen und dann wieder in das untere Feled keinen Text einzutragen

        private void plus_Click(object sender, EventArgs e)
        {
            try
            {
                rechenzeichen1 = "+";
                zahl1 = Convert.ToDouble(eingabe.Text);
                eingabe.Text = "";
                test11 = "1";
            }
            catch
            {
                eingabe.Text = "Zwei Rechenzeichen!";
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            try
                {
                rechenzeichen1 = "-";
                zahl1 = Convert.ToDouble(eingabe.Text);
                eingabe.Text = "";
                test11 = "1";
            }
            catch
                {
                eingabe.Text = "Zwei Rechenzeichen!"; 
                }
        }

        private void multiplizieren_Click(object sender, EventArgs e)
        {
            try
            {
                rechenzeichen1 = "*";
                zahl1 = Convert.ToDouble(eingabe.Text);
                eingabe.Text = "";

            }
            catch
            {
                eingabe.Text = "Zwei Rechenzeichen!"; 

            }
        }

        private void dividieren_Click(object sender, EventArgs e)
        {
            try
            {
                rechenzeichen1 = "/";
                zahl1 = Convert.ToDouble(eingabe.Text);
                eingabe.Text = "";
               }
            catch
            {
                eingabe.Text = "Zwei Rechenzeichen!"; 
            }
        }

        //ab hier wird dann fuer eingabe.Text, 0 eingesetzt, um nicht mit falscher Eingabe zu enden

        private void sin_Click(object sender, EventArgs e)
        {
            try
            {
                rechenzeichen1 = "sin";
                zahl2 = Convert.ToDouble(eingabe.Text);
                //eingabe.Text = "";
            }
            catch
            {
                eingabe.Text = "Falsche Eingabe!";
            }
        }

        private void cos_Click(object sender, EventArgs e)
        {
            try
            {
                rechenzeichen1 = "cos";
                zahl2 = Convert.ToDouble(eingabe.Text);
                // eingabe.Text = "";
            }
            catch
            {
                eingabe.Text = "Falsche Eingabe!";
            }
        }

        private void tan_Click(object sender, EventArgs e)
        {
            try
            {
                rechenzeichen1 = "tan";
                zahl2 = Convert.ToDouble(eingabe.Text);
                //eingabe.Text = "";
            }
            catch
            {
                eingabe.Text = "Falsche Eingabe!";
            }
        }
        private void sqrt_Click(object sender, EventArgs e)
        {
            try { 
                rechenzeichen1 = "sqrt";
                zahl1 = Convert.ToDouble(eingabe.Text);
                //eingabe.Text = "";
                }
            catch
                {
                eingabe.Text = "Falsche Eingabe!";
                }
        }

        private void sqr_Click(object sender, EventArgs e)
        {
            try { 
                rechenzeichen1 = "sqr";
                zahl1 = Convert.ToDouble(eingabe.Text);
                // eingabe.Text = "";
                }
            catch
                {
                eingabe.Text = "Falsche Eingabe!";
                }
        }

        private void berechnen_Click(object sender, EventArgs e)
        {

            try
            {

                // string rechenzeichen1 = Convert.ToString(rechenzeichen.Text);
                //  double zahl1 = Convert.ToDouble(eingabe2.Text);

                double zahl2 = Convert.ToDouble(eingabe.Text);
                if (prozentrechnen == "1")
                {
                    //eingabe.Text = zahl2 + "%";
                }
               
                  
                    erg = 0; //um dem Ergebnis einen Wert zuzuweisen damit es funktioniert
                
                    
                

                switch (rechenzeichen1)

                {
                    case "+":                        
                        if (prozentrechnen == "1") //wenn man Prozentrechnen will
                        {
                            erg = zahl1 + (zahl1 / 100 * zahl2);
                            rechenzeichen1 = "++";
                            //prozentrechnen = "1";
                            erg1 = Convert.ToDouble(eingabe.Text);
                            erg2 = (zahl1 / 100 * zahl2);

                        }
                        else
                        {
                            calculation_class calc = new calculation_class();
                            erg = calc.add(zahl1, zahl2);


                            rechenzeichen1 = "++";
                            erg1 = Convert.ToDouble(eingabe.Text);

                        }
                        nichts = 1;
                        break;

                    case "++": //fuer nochmals die = Taste
                        if (prozentrechnen == "1") //wenn man Prozentrechnen will
                        {
                            calculation_class calc = new calculation_class();
                            erg = calc.add(zahl1, zahl2);
                        }
                        else
                        {
                            calculation_class calc = new calculation_class();
                            erg = calc.add(zahl1, zahl2);
                            rechenzeichen1 = "++";

                        }
                        nichts = 1;
                        break;


                    case "-":                        
                        if (prozentrechnen == "1")
                        {
                            erg = zahl1 - (zahl1 / 100 * zahl2);
                            rechenzeichen1 = "--";
                            erg1 = Convert.ToDouble(eingabe.Text);
                        }
                        else
                        {
                            calculation_class calc = new calculation_class();
                            erg = calc.sub(zahl1, zahl2);
                            rechenzeichen1 = "--";
                            erg1 = Convert.ToDouble(eingabe.Text);
                        }
                        nichts = 1;
                        break;

                    case "--": //fuer nochmals die = Taste
                        if (prozentrechnen == "1") //wenn man Prozentrechnen will
                        {
                            calculation_class calc = new calculation_class();
                            erg = calc.sub(zahl1, zahl2);
                        }
                        else
                        {
                            calculation_class calc = new calculation_class();
                            erg = calc.sub(zahl1, zahl2);
                            rechenzeichen1 = "--";

                        }
                        nichts = 1;
                        break;

                    case "/":                      
                        if (prozentrechnen == "1")
                        {
                            erg = zahl1 / (zahl1 / 100 * zahl2);
                        }
                        else
                        {
                            calculation_class calc = new calculation_class();
                            erg = calc.div(zahl1, zahl2);
                            rechenzeichen1 = "//";
                            erg1 = Convert.ToDouble(eingabe.Text);
                        }
                        nichts = 1;
                        break;

                    case "//": //fuer nochmals die = Taste
                        if (prozentrechnen == "1") //wenn man Prozentrechnen will
                        {
                            erg = erg1 - erg2;
                        }
                        else
                        {
                            calculation_class calc = new calculation_class();
                            erg = calc.div(zahl1, zahl2);
                            rechenzeichen1 = "//";

                        }
                        nichts = 1;
                        break;

                    case "*":                        
                        if (prozentrechnen == "1")
                        {
                            erg = zahl1 * (zahl1 / 100 * zahl2);
                        }
                        else
                        {
                           
                            erg = zahl1 * zahl2;
                            rechenzeichen1 = "**";
                            erg1 = Convert.ToDouble(eingabe.Text);

                        }
                        nichts = 1;
                        break;

                    case "**": //fuer nochmals die = Taste
                        if (prozentrechnen == "1") //wenn man Prozentrechnen will
                        {
                            erg = erg1 - erg2;
                        }
                        else
                        {
                            erg = zahl2 * erg1;
                            rechenzeichen1 = "**";

                        }
                        nichts = 1;
                        break;

                    //Winkelfunktionen
                    case "sin":
                        zahl1 = zahl2 * Math.PI / 180.0;
                        erg = Math.Round(Math.Sin(zahl1), 4);
                        if (prozentrechnen == "1")
                        {
                            erg = Convert.ToDouble("Falsche Eingabe");
                        }
                        nichts = 1;
                        break;

                    case "cos":
                        zahl1 = zahl2 * Math.PI / 180.0;
                        erg = Math.Round(Math.Cos(zahl1), 4);
                        if (prozentrechnen == "1")
                        {
                            erg = Convert.ToDouble("Falsche Eingabe");
                        }
                        nichts = 1;
                        break;

                    case "tan":
                        zahl1 = zahl2 * Math.PI / 180.0;
                        erg = Math.Round(Math.Tan(zahl1), 4);
                        if (prozentrechnen == "1")
                        {
                            erg = Convert.ToDouble("Falsche Eingabe");
                        }
                        nichts = 1;
                        break;

                    case "sqrt":
                        erg = Math.Sqrt(zahl1);
                        nichts = 1;
                        break;

                    case "sqr":
                        erg = zahl1 *zahl1;
                        nichts = 1;
                        break;

                    //case "Prozent":
                    //    erg = zahl1 -(zahl1 / 100 * zahl2);
                    //    nichts = 1;
                    //    break;

                    default:
                        eingabe.Text = "Das Rechenzeichen ist in diesem Rechner unbekannt!";
                        break;
                        
                }
                eingabe.Text = Convert.ToString(erg);

            }
            catch
            {
                eingabe.Text = "Falsche Eingabe!"; 

            }            
        }

        private void eingabe2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ErgebnisText_Click(object sender, EventArgs e)
        {

        }

        private void ergebnis_TextChanged(object sender, EventArgs e)
        {

        }

        private void eingabe_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            if (eingabe.Text.Length > 0) {
                eingabe.Text = eingabe.Text.Substring(0, eingabe.Text.Length - 1);
            }
        }
    }
    }