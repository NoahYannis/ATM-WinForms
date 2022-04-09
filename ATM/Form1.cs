using System;
using System.Windows.Forms;

namespace ATM
{


    public partial class Form1 : Form
    {
        double Zinshöhe, monatlicheZinshöhe, Darlehensbetrag, monatlicheRate, InsgesamterBetrag;
        int anzahlJahre; int aktuellerKontostand = 5000; int alterKontostand; int transaktionsSumme; int falscherLogin = 0;
        String imonatlicheRate, iInsgesamterBetrag;
        bool loginErfolgreich = false, willEinzahlen = false, willAbheben = false, willKontostand = false, willDarlehen = false, transaktionErfolgreich = false, darlehenErfolgreich = false;



        public Form1()
        {
           
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblKontostand.Visible = false;
            lblAbheben.Visible = false;
            lblDarlehen.Visible = false;
            lblEinzahlen.Visible = false;

            btnKontostand.Enabled = false;
            btnAbheben.Enabled = false;
            btnEinzahlen.Enabled = false;
            btnDarlehen.Enabled = false;

            btnLeihen.Enabled = false;
            btnNeu.Enabled = false;
            btnSchließen.Enabled = false;
            btnBeleg.Enabled = false;

            gbDarlehen.Visible = false;
            rtbTransaktionsBeleg.Visible = false;

            lblPin.Text = "PIN eingeben";
        }
      
        private void btn1_Click(object sender, EventArgs e)
        {
            ClearPin();
            ZahlenEingabe(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ClearPin();
            ZahlenEingabe(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ClearPin();
            ZahlenEingabe(3);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ClearPin();
            ZahlenEingabe(4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ClearPin();
            ZahlenEingabe(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ClearPin();
            ZahlenEingabe(6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ClearPin();
            ZahlenEingabe(7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ClearPin();
            ZahlenEingabe(8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ClearPin();
            ZahlenEingabe(9);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            ClearPin();
            ZahlenEingabe(0);
        }

        private void btnLöschen_Click(object sender, EventArgs e)
        {
            if (lblPin.Text.Length > 0)
            {
                if (lblPin.Text.Contains("€") == false && lblPin.Text.Contains("PIN") == false && lblPin.Text.Contains("Zahl") == false && lblPin.Text.Contains("Konto") == false)
                {
                    lblPin.Text = lblPin.Text.Remove(lblPin.Text.Length - 1);
                }           
            }

            if (rtbTransaktionsBeleg.Visible == true)
            {
                rtbTransaktionsBeleg.Clear();
            }
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
                
            iExit = MessageBox.Show("Wollen Sie den Vorgang beenden?",
            "ATM System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnBestätigen_Click(object sender, EventArgs e)
        {
            String pin1 = String.Format(lblPin.Text);
            
            if (loginErfolgreich == false)
            {
                if (falscherLogin < 3)
                {
                    if (pin1 == "1234")
                    {
                        lblKontostand.Visible = true;
                        lblAbheben.Visible = true;
                        lblDarlehen.Visible = true;
                        lblEinzahlen.Visible = true;

                        btnKontostand.Enabled = true;
                        btnAbheben.Enabled = true;
                        btnEinzahlen.Enabled = true;
                        btnDarlehen.Enabled = true;
                        lblPin.Text = "";

                        loginErfolgreich = true;
                    }
                    else
                    {
                        lblPin.Text = "Ungültige PIN";
                        falscherLogin++;

                        if (falscherLogin == 3)
                        {
                            lblPin.Text = "Konto gesperrt";
                            btnKontostand.Enabled = false;
                            btnAbheben.Enabled = false;
                            btnEinzahlen.Enabled = false;
                            btnDarlehen.Enabled = false;
                        }
                    }
                }
              
            }

            if (willAbheben)
            {              
                if (lblPin.Text.Contains("€") | lblPin.Text.Contains("Ungültige Zahl") | lblPin.Text == "0")
                {
                    lblPin.Text = "Ungültige Zahl";                                       
                }
                else if (transaktionsSumme > 1000000)
                {
                    lblPin.Text = "Max 1 Mio.€";
                }
                else
                {
                    if (aktuellerKontostand - Int64.Parse(lblPin.Text) < 0)
                    {
                        lblPin.Text = "Kontostand zu niedrig";
                    }
                    else
                    {
                        int neuerKontostand = aktuellerKontostand - Int32.Parse(lblPin.Text);                             
                        lblPin.Text = "Kontostand: " + neuerKontostand.ToString("C");
                        transaktionsSumme = aktuellerKontostand - neuerKontostand;
                        alterKontostand = neuerKontostand - transaktionsSumme;
                        aktuellerKontostand = neuerKontostand;
                        transaktionErfolgreich = true;
                        btnTransaktionsBeleg.Text = "Beleg";
                    }
                }
            }
            else if (willEinzahlen)
            {
                if (lblPin.Text.Contains("€") | lblPin.Text.Contains("Ungültige Zahl") | lblPin.Text == "0")
                {
                    lblPin.Text = "Ungültige Zahl";
                }
                else
                {
                    int neuerKontostand = aktuellerKontostand + Int32.Parse(lblPin.Text);
                    lblPin.Text = "Kontostand: " + neuerKontostand.ToString("C");
                    transaktionsSumme = neuerKontostand - aktuellerKontostand;
                    alterKontostand = neuerKontostand + transaktionsSumme;
                    aktuellerKontostand = neuerKontostand;

                    transaktionErfolgreich = true;
                    btnTransaktionsBeleg.Text = "Beleg";
                }
            }
        }

        private void btnBeleg_Click(object sender, EventArgs e)
        {
            if (darlehenErfolgreich)
            {
                rtbBeleg.AppendText("\t" + "  " + "ATM Kredit" + "\n");
                rtbBeleg.AppendText("------------------------------------" + "\n");
                rtbBeleg.AppendText("Kredithöhe:" + "\t" + txtDarlehensbetrag.Text + "\n");
                rtbBeleg.AppendText("Laufdauer:" + "\t" + txtLaufdauer.Text + " Jahre" + "\n");
                rtbBeleg.AppendText("Zinshöhe:" + "\t" + txtZinshöhe.Text + "%" + "\n");
                rtbBeleg.AppendText("Mtl. Rate:" + "\t" + txtMtlRate.Text + "\n");
                rtbBeleg.AppendText("Insg. Betrag:" + "\t" + txtInsgesamteZahlung.Text + "\n");
                rtbBeleg.AppendText("------------------------------------" + "\n");
                rtbBeleg.AppendText("------------Vielen-Dank!------------" + "\n");
            }      
        }

     
        private void btnTransaktionsBeleg_Click_1(object sender, EventArgs e)
        {
            ZeigeTransaktionsBeleg();        
        }

        private void txtDarlehensbetrag_KeyPress(object sender, KeyPressEventArgs e)
        {           
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtLaufdauer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            } 
            else if (txtLaufdauer.Text.Length > 1 && (!char.IsControl(e.KeyChar)))
            {                                                        
                e.Handled = true;
            }
        }
        private void txtZinshöhe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
            else if (txtZinshöhe.Text.Length > 1 && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }       
        private void btnLeihen_Click(object sender, EventArgs e)
        {
            if (txtDarlehensbetrag.Text.Length > 0 && txtLaufdauer.Text.Length > 0 && txtZinshöhe.Text.Length > 0)
            {
                Zinshöhe = Convert.ToDouble(txtZinshöhe.Text);
                monatlicheZinshöhe = Zinshöhe / 1200;
                anzahlJahre = Convert.ToInt32(txtLaufdauer.Text);
                Darlehensbetrag = Convert.ToDouble(txtDarlehensbetrag.Text);

                monatlicheRate = Darlehensbetrag * monatlicheZinshöhe / (1 - 1 / Math.Pow(1 + monatlicheZinshöhe, anzahlJahre * 12));
                //-------------------------------------------------
                imonatlicheRate = Convert.ToString(monatlicheRate);
                imonatlicheRate = String.Format("{0:C}", monatlicheRate);
                txtMtlRate.Text = (imonatlicheRate);
                //-------------------------------------------------

                InsgesamterBetrag = monatlicheRate * 12 * anzahlJahre;
                iInsgesamterBetrag = String.Format("{0:C}", InsgesamterBetrag);
                txtInsgesamteZahlung.Text = (iInsgesamterBetrag);

                txtDarlehensbetrag.Text = String.Format("{0:C}", Darlehensbetrag);

                darlehenErfolgreich = true;
                btnLeihen.Enabled = false;

                if (Convert.ToInt32(txtLaufdauer.Text) > 30)
                {
                    txtDarlehensbetrag.Text = "";
                    txtLaufdauer.Text = "";
                    txtZinshöhe.Text = "";
                    txtMtlRate.Text = "";
                    txtInsgesamteZahlung.Text = "";
                    rtbBeleg.Text = "Laufdauer darf maximal 30 Jahre betragen";
                }
                else if (Convert.ToInt32(txtZinshöhe.Text) > 20)
                {
                    txtDarlehensbetrag.Text = "";
                    txtLaufdauer.Text = "";
                    txtZinshöhe.Text = "";
                    txtMtlRate.Text = "";
                    txtInsgesamteZahlung.Text = "";
                    rtbBeleg.Text = "Zinshöhe darf maximal 20% betragen";
                }
                else if (Darlehensbetrag > 100000)
                {
                    txtDarlehensbetrag.Text = "";
                    txtLaufdauer.Text = "";
                    txtZinshöhe.Text = "";
                    txtMtlRate.Text = "";
                    txtInsgesamteZahlung.Text = "";
                    rtbBeleg.Text = "Betrag darf maximal 1.000.000€ betragen";
                }
            }                                 
        }

        private void btnKontostand_Click(object sender, EventArgs e)
        {
            willKontostand = true;
            willDarlehen = false;
            willEinzahlen = false;
            willAbheben = false;

            transaktionErfolgreich = false;

            lblPin.Text = aktuellerKontostand.ToString("C");

            if (willDarlehen == false)
            {
                gbDarlehen.Visible = false;
            }
        }

        private void btnAbheben_Click(object sender, EventArgs e)
        {
            willKontostand = false;
            willDarlehen = false;
            willEinzahlen = false;
            willAbheben = true;
            transaktionErfolgreich = false;

            if (willDarlehen == false)
            {
                gbDarlehen.Visible = false;
            }

            lblPin.Text = "Kontostand: " + aktuellerKontostand.ToString("C");
        }

        private void btnEinzahlen_Click(object sender, EventArgs e)
        {
            willKontostand = false;
            willDarlehen = false;
            willEinzahlen = true;
            willAbheben = false;
            transaktionErfolgreich = false;

            if (willDarlehen == false)
            {
                gbDarlehen.Visible = false;
            }

            lblPin.Text = "Kontostand: " + aktuellerKontostand.ToString("C");        
        }    
        private void btnNeu_Click(object sender, EventArgs e)
        {
            txtDarlehensbetrag.Clear();
            txtLaufdauer.Clear();
            txtZinshöhe.Clear();
            txtMtlRate.Text = "";
            txtInsgesamteZahlung.Text = "";
            rtbBeleg.Clear();
            rtbBeleg.ScrollBars = RichTextBoxScrollBars.None;
            btnLeihen.Enabled = true;
            darlehenErfolgreich = false;
        }

        private void btnDarlehen_Click(object sender, EventArgs e)
        {
            willKontostand = false;
            willDarlehen = true;
            willEinzahlen = false;
            willAbheben = false;
            transaktionErfolgreich = false;

            lblPin.Text =  "Kontostand: " + aktuellerKontostand.ToString("C");
            gbDarlehen.Visible = true;
            rtbTransaktionsBeleg.Visible = false;

            btnLeihen.Visible = true;
            btnLeihen.Enabled = true;

            btnNeu.Visible = true;
            btnNeu.Enabled = true;

            btnSchließen.Visible = true;
            btnSchließen.Enabled = true;

            btnBeleg.Visible = true;
            btnBeleg.Enabled = true;

            lblDarlehensbetrag.Visible = true;
            lblLaufdauer.Visible = true;
            lblZinshöhe.Visible = true;
            lblMontatlicheRate.Visible = true;
            lblInsgesamteZahlung.Visible = true;
            txtDarlehensbetrag.Visible = true;
            txtInsgesamteZahlung.Visible = true;
            txtLaufdauer.Visible = true;
            txtMtlRate.Visible = true;
            txtZinshöhe.Visible = true;
            rtbBeleg.Visible = true;
        }

        private void btnSchließen_Click(object sender, EventArgs e)
        {
            DialogResult iExitLoan;
                
           iExitLoan = MessageBox.Show("Wollen Sie den Vorgang beenden?",
           "ATM System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExitLoan == DialogResult.Yes)
            {
                gbDarlehen.Visible = false;
            }
        }
    
        private void ClearPin()
        {
            if (lblPin.Text.Contains("Kontostand") || lblPin.Text.Contains("PIN") || lblPin.Text.Contains("Ungültige Zahl"))
            {
                lblPin.Text = "";
            }
        }
  
        private void ZahlenEingabe(int zahl)
        {
            if (falscherLogin < 3)
            {
                if (loginErfolgreich == false)
                {
                    if (lblPin.Text.Length < 4)
                    {
                        lblPin.Text += zahl;
                    }
                }

                if (loginErfolgreich)
                {
                    if (willAbheben | willEinzahlen)
                    {
                        if (lblPin.Text.Length < 7)
                        {
                            lblPin.Text += zahl;
                        }
                    }
                }
            }
                
        }        
   
        private void ZeigeTransaktionsBeleg()
        {
            if (willAbheben | willEinzahlen)
            {
                if (willAbheben)
                {
                    alterKontostand = aktuellerKontostand + transaktionsSumme;
                }
                else if (willEinzahlen)
                {
                    alterKontostand = aktuellerKontostand - transaktionsSumme;
                }

                if (transaktionErfolgreich)
                {
                    btnTransaktionsBeleg.Text = "Beleg";

                    gbDarlehen.Visible = true;
                    btnLeihen.Visible = false;
                    btnNeu.Visible = false;
                    btnSchließen.Visible = false;
                    btnBeleg.Visible = false;
                    lblDarlehensbetrag.Visible = false;
                    lblLaufdauer.Visible = false;
                    lblZinshöhe.Visible = false;
                    lblMontatlicheRate.Visible = false;
                    lblInsgesamteZahlung.Visible = false;
                    txtDarlehensbetrag.Visible = false;
                    txtInsgesamteZahlung.Visible = false;
                    txtLaufdauer.Visible = false;
                    txtMtlRate.Visible = false;
                    txtZinshöhe.Visible = false;
                    rtbBeleg.Visible = false;
                    rtbTransaktionsBeleg.Visible = true;


                    rtbTransaktionsBeleg.AppendText("\t" + "  " + "ATM Transaktion" + "\n");
                    rtbTransaktionsBeleg.AppendText("---------------------------------------" + "\n");
                    rtbTransaktionsBeleg.AppendText("Transaktionssumme:" + "\t" + transaktionsSumme.ToString("C")  + "\n");
                    rtbTransaktionsBeleg.AppendText("Alter Kontostand:" + "\t" + "\t" + alterKontostand.ToString("C")  + "\n");
                    rtbTransaktionsBeleg.AppendText("Neuer Kontostand:" + "\t" + aktuellerKontostand.ToString("C")  + "\n");
                    rtbTransaktionsBeleg.AppendText("Datum:" + "\t" + DateTime.Now + "\n");
                    rtbTransaktionsBeleg.AppendText("---------------------------------------" + "\n");

                    if(transaktionsSumme == 69)
                    {
                       rtbTransaktionsBeleg.AppendText("----------------Nice---------------" + "\n");
                    }
                    else
                    {
                        rtbTransaktionsBeleg.AppendText("------------Vielen-Dank!---------------" + "\n");
                    }
                    rtbTransaktionsBeleg.AppendText("\n");
                }
            }
        }
    }
}
