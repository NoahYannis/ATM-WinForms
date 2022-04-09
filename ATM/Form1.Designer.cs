
namespace ATM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAbheben = new System.Windows.Forms.Button();
            this.btnKontostand = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDarlehen = new System.Windows.Forms.Label();
            this.lblAbheben = new System.Windows.Forms.Label();
            this.lblEinzahlen = new System.Windows.Forms.Label();
            this.lblPin = new System.Windows.Forms.Label();
            this.lblKontostand = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEinzahlen = new System.Windows.Forms.Button();
            this.btnDarlehen = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnTransaktionsBeleg = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.btnBestätigen = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnLöschen = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.rtbTransaktionsBeleg = new System.Windows.Forms.RichTextBox();
            this.gbDarlehen = new System.Windows.Forms.GroupBox();
            this.btnSchließen = new System.Windows.Forms.Button();
            this.btnNeu = new System.Windows.Forms.Button();
            this.btnBeleg = new System.Windows.Forms.Button();
            this.btnLeihen = new System.Windows.Forms.Button();
            this.rtbBeleg = new System.Windows.Forms.RichTextBox();
            this.txtMtlRate = new System.Windows.Forms.TextBox();
            this.txtZinshöhe = new System.Windows.Forms.TextBox();
            this.txtInsgesamteZahlung = new System.Windows.Forms.TextBox();
            this.txtDarlehensbetrag = new System.Windows.Forms.TextBox();
            this.txtLaufdauer = new System.Windows.Forms.TextBox();
            this.lblLaufdauer = new System.Windows.Forms.Label();
            this.lblInsgesamteZahlung = new System.Windows.Forms.Label();
            this.lblMontatlicheRate = new System.Windows.Forms.Label();
            this.lblZinshöhe = new System.Windows.Forms.Label();
            this.lblDarlehensbetrag = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbDarlehen.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAbheben);
            this.groupBox1.Controls.Add(this.btnKontostand);
            this.groupBox1.Location = new System.Drawing.Point(42, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnAbheben
            // 
            this.btnAbheben.Location = new System.Drawing.Point(6, 88);
            this.btnAbheben.Name = "btnAbheben";
            this.btnAbheben.Size = new System.Drawing.Size(134, 58);
            this.btnAbheben.TabIndex = 1;
            this.btnAbheben.Text = "-->";
            this.btnAbheben.UseVisualStyleBackColor = true;
            this.btnAbheben.Click += new System.EventHandler(this.btnAbheben_Click);
            // 
            // btnKontostand
            // 
            this.btnKontostand.Location = new System.Drawing.Point(6, 17);
            this.btnKontostand.Name = "btnKontostand";
            this.btnKontostand.Size = new System.Drawing.Size(134, 59);
            this.btnKontostand.TabIndex = 0;
            this.btnKontostand.Text = "--> ";
            this.btnKontostand.UseVisualStyleBackColor = true;
            this.btnKontostand.Click += new System.EventHandler(this.btnKontostand_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.lblDarlehen);
            this.groupBox2.Controls.Add(this.lblAbheben);
            this.groupBox2.Controls.Add(this.lblEinzahlen);
            this.groupBox2.Controls.Add(this.lblPin);
            this.groupBox2.Controls.Add(this.lblKontostand);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(194, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 129);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lblDarlehen
            // 
            this.lblDarlehen.AutoSize = true;
            this.lblDarlehen.Location = new System.Drawing.Point(107, 5);
            this.lblDarlehen.Name = "lblDarlehen";
            this.lblDarlehen.Size = new System.Drawing.Size(90, 28);
            this.lblDarlehen.TabIndex = 20;
            this.lblDarlehen.Text = "Darlehen";
            // 
            // lblAbheben
            // 
            this.lblAbheben.AutoSize = true;
            this.lblAbheben.Location = new System.Drawing.Point(6, 92);
            this.lblAbheben.Name = "lblAbheben";
            this.lblAbheben.Size = new System.Drawing.Size(91, 28);
            this.lblAbheben.TabIndex = 19;
            this.lblAbheben.Text = "Abheben";
            // 
            // lblEinzahlen
            // 
            this.lblEinzahlen.AutoSize = true;
            this.lblEinzahlen.Location = new System.Drawing.Point(103, 92);
            this.lblEinzahlen.Name = "lblEinzahlen";
            this.lblEinzahlen.Size = new System.Drawing.Size(94, 28);
            this.lblEinzahlen.TabIndex = 18;
            this.lblEinzahlen.Text = "Einzahlen";
            // 
            // lblPin
            // 
            this.lblPin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPin.Location = new System.Drawing.Point(6, 47);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(191, 45);
            this.lblPin.TabIndex = 17;
            // 
            // lblKontostand
            // 
            this.lblKontostand.AutoSize = true;
            this.lblKontostand.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKontostand.Location = new System.Drawing.Point(6, 10);
            this.lblKontostand.Name = "lblKontostand";
            this.lblKontostand.Size = new System.Drawing.Size(98, 23);
            this.lblKontostand.TabIndex = 16;
            this.lblKontostand.Text = "Kontostand";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEinzahlen);
            this.groupBox3.Controls.Add(this.btnDarlehen);
            this.groupBox3.Location = new System.Drawing.Point(403, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(146, 146);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnEinzahlen
            // 
            this.btnEinzahlen.Location = new System.Drawing.Point(6, 82);
            this.btnEinzahlen.Name = "btnEinzahlen";
            this.btnEinzahlen.Size = new System.Drawing.Size(134, 58);
            this.btnEinzahlen.TabIndex = 2;
            this.btnEinzahlen.Text = "<--";
            this.btnEinzahlen.UseVisualStyleBackColor = true;
            this.btnEinzahlen.Click += new System.EventHandler(this.btnEinzahlen_Click);
            // 
            // btnDarlehen
            // 
            this.btnDarlehen.Location = new System.Drawing.Point(4, 17);
            this.btnDarlehen.Name = "btnDarlehen";
            this.btnDarlehen.Size = new System.Drawing.Size(134, 59);
            this.btnDarlehen.TabIndex = 1;
            this.btnDarlehen.Text = "<--";
            this.btnDarlehen.UseVisualStyleBackColor = true;
            this.btnDarlehen.Click += new System.EventHandler(this.btnDarlehen_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnTransaktionsBeleg);
            this.groupBox4.Controls.Add(this.button18);
            this.groupBox4.Controls.Add(this.btn0);
            this.groupBox4.Controls.Add(this.button20);
            this.groupBox4.Controls.Add(this.btnBestätigen);
            this.groupBox4.Controls.Add(this.btn9);
            this.groupBox4.Controls.Add(this.btn8);
            this.groupBox4.Controls.Add(this.btn7);
            this.groupBox4.Controls.Add(this.btnLöschen);
            this.groupBox4.Controls.Add(this.btn6);
            this.groupBox4.Controls.Add(this.btn5);
            this.groupBox4.Controls.Add(this.btn4);
            this.groupBox4.Controls.Add(this.btnAbbrechen);
            this.groupBox4.Controls.Add(this.btn3);
            this.groupBox4.Controls.Add(this.btn2);
            this.groupBox4.Controls.Add(this.btn1);
            this.groupBox4.Location = new System.Drawing.Point(42, 188);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(507, 288);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // btnTransaktionsBeleg
            // 
            this.btnTransaktionsBeleg.Location = new System.Drawing.Point(369, 225);
            this.btnTransaktionsBeleg.Name = "btnTransaktionsBeleg";
            this.btnTransaktionsBeleg.Size = new System.Drawing.Size(132, 64);
            this.btnTransaktionsBeleg.TabIndex = 15;
            this.btnTransaktionsBeleg.Text = "Beleg";
            this.btnTransaktionsBeleg.UseVisualStyleBackColor = true;
            this.btnTransaktionsBeleg.Click += new System.EventHandler(this.btnTransaktionsBeleg_Click_1);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(247, 225);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(116, 64);
            this.button18.TabIndex = 14;
            this.button18.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(131, 225);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(108, 64);
            this.btn0.TabIndex = 13;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(6, 225);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(119, 64);
            this.button20.TabIndex = 12;
            this.button20.UseVisualStyleBackColor = true;
            // 
            // btnBestätigen
            // 
            this.btnBestätigen.Location = new System.Drawing.Point(369, 155);
            this.btnBestätigen.Name = "btnBestätigen";
            this.btnBestätigen.Size = new System.Drawing.Size(130, 64);
            this.btnBestätigen.TabIndex = 11;
            this.btnBestätigen.Text = "Bestätigen";
            this.btnBestätigen.UseVisualStyleBackColor = true;
            this.btnBestätigen.Click += new System.EventHandler(this.btnBestätigen_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(247, 155);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(116, 64);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(131, 155);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(108, 64);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(6, 155);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(119, 64);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnLöschen
            // 
            this.btnLöschen.Location = new System.Drawing.Point(369, 85);
            this.btnLöschen.Name = "btnLöschen";
            this.btnLöschen.Size = new System.Drawing.Size(130, 64);
            this.btnLöschen.TabIndex = 7;
            this.btnLöschen.Text = "Löschen";
            this.btnLöschen.UseVisualStyleBackColor = true;
            this.btnLöschen.Click += new System.EventHandler(this.btnLöschen_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(247, 85);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(116, 64);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(131, 85);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(108, 64);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(6, 85);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(119, 64);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.Location = new System.Drawing.Point(369, 15);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(130, 64);
            this.btnAbbrechen.TabIndex = 3;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(247, 15);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(116, 64);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(131, 15);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(108, 64);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(6, 15);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(119, 64);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // rtbTransaktionsBeleg
            // 
            this.rtbTransaktionsBeleg.AcceptsTab = true;
            this.rtbTransaktionsBeleg.Location = new System.Drawing.Point(0, 2);
            this.rtbTransaktionsBeleg.Name = "rtbTransaktionsBeleg";
            this.rtbTransaktionsBeleg.ReadOnly = true;
            this.rtbTransaktionsBeleg.Size = new System.Drawing.Size(276, 424);
            this.rtbTransaktionsBeleg.TabIndex = 16;
            this.rtbTransaktionsBeleg.Text = "Beleg";
            this.rtbTransaktionsBeleg.Visible = false;
            // 
            // gbDarlehen
            // 
            this.gbDarlehen.Controls.Add(this.btnSchließen);
            this.gbDarlehen.Controls.Add(this.btnNeu);
            this.gbDarlehen.Controls.Add(this.btnBeleg);
            this.gbDarlehen.Controls.Add(this.btnLeihen);
            this.gbDarlehen.Controls.Add(this.rtbBeleg);
            this.gbDarlehen.Controls.Add(this.txtMtlRate);
            this.gbDarlehen.Controls.Add(this.txtZinshöhe);
            this.gbDarlehen.Controls.Add(this.txtInsgesamteZahlung);
            this.gbDarlehen.Controls.Add(this.txtDarlehensbetrag);
            this.gbDarlehen.Controls.Add(this.txtLaufdauer);
            this.gbDarlehen.Controls.Add(this.lblLaufdauer);
            this.gbDarlehen.Controls.Add(this.lblInsgesamteZahlung);
            this.gbDarlehen.Controls.Add(this.lblMontatlicheRate);
            this.gbDarlehen.Controls.Add(this.lblZinshöhe);
            this.gbDarlehen.Controls.Add(this.lblDarlehensbetrag);
            this.gbDarlehen.Controls.Add(this.rtbTransaktionsBeleg);
            this.gbDarlehen.Location = new System.Drawing.Point(587, 51);
            this.gbDarlehen.Name = "gbDarlehen";
            this.gbDarlehen.Size = new System.Drawing.Size(694, 426);
            this.gbDarlehen.TabIndex = 21;
            this.gbDarlehen.TabStop = false;
            // 
            // btnSchließen
            // 
            this.btnSchließen.Location = new System.Drawing.Point(483, 362);
            this.btnSchließen.Name = "btnSchließen";
            this.btnSchließen.Size = new System.Drawing.Size(94, 43);
            this.btnSchließen.TabIndex = 22;
            this.btnSchließen.Text = "Schließen";
            this.btnSchließen.UseVisualStyleBackColor = true;
            this.btnSchließen.Click += new System.EventHandler(this.btnSchließen_Click);
            // 
            // btnNeu
            // 
            this.btnNeu.Location = new System.Drawing.Point(339, 362);
            this.btnNeu.Name = "btnNeu";
            this.btnNeu.Size = new System.Drawing.Size(94, 43);
            this.btnNeu.TabIndex = 22;
            this.btnNeu.Text = "Neu";
            this.btnNeu.UseVisualStyleBackColor = true;
            this.btnNeu.Click += new System.EventHandler(this.btnNeu_Click);
            // 
            // btnBeleg
            // 
            this.btnBeleg.Location = new System.Drawing.Point(182, 362);
            this.btnBeleg.Name = "btnBeleg";
            this.btnBeleg.Size = new System.Drawing.Size(94, 43);
            this.btnBeleg.TabIndex = 22;
            this.btnBeleg.Text = "Beleg";
            this.btnBeleg.UseVisualStyleBackColor = true;
            this.btnBeleg.Click += new System.EventHandler(this.btnBeleg_Click);
            // 
            // btnLeihen
            // 
            this.btnLeihen.Location = new System.Drawing.Point(32, 362);
            this.btnLeihen.Name = "btnLeihen";
            this.btnLeihen.Size = new System.Drawing.Size(94, 43);
            this.btnLeihen.TabIndex = 22;
            this.btnLeihen.Text = "Leihen";
            this.btnLeihen.UseVisualStyleBackColor = true;
            this.btnLeihen.Click += new System.EventHandler(this.btnLeihen_Click);
            // 
            // rtbBeleg
            // 
            this.rtbBeleg.Location = new System.Drawing.Point(339, 57);
            this.rtbBeleg.Name = "rtbBeleg";
            this.rtbBeleg.ReadOnly = true;
            this.rtbBeleg.Size = new System.Drawing.Size(329, 268);
            this.rtbBeleg.TabIndex = 2;
            this.rtbBeleg.Text = "";
            // 
            // txtMtlRate
            // 
            this.txtMtlRate.Location = new System.Drawing.Point(182, 241);
            this.txtMtlRate.Name = "txtMtlRate";
            this.txtMtlRate.ReadOnly = true;
            this.txtMtlRate.Size = new System.Drawing.Size(125, 27);
            this.txtMtlRate.TabIndex = 1;
            // 
            // txtZinshöhe
            // 
            this.txtZinshöhe.Location = new System.Drawing.Point(182, 181);
            this.txtZinshöhe.Name = "txtZinshöhe";
            this.txtZinshöhe.Size = new System.Drawing.Size(125, 27);
            this.txtZinshöhe.TabIndex = 1;
            this.txtZinshöhe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZinshöhe_KeyPress);
            // 
            // txtInsgesamteZahlung
            // 
            this.txtInsgesamteZahlung.Location = new System.Drawing.Point(182, 292);
            this.txtInsgesamteZahlung.Name = "txtInsgesamteZahlung";
            this.txtInsgesamteZahlung.ReadOnly = true;
            this.txtInsgesamteZahlung.Size = new System.Drawing.Size(125, 27);
            this.txtInsgesamteZahlung.TabIndex = 1;
            // 
            // txtDarlehensbetrag
            // 
            this.txtDarlehensbetrag.Location = new System.Drawing.Point(182, 67);
            this.txtDarlehensbetrag.Name = "txtDarlehensbetrag";
            this.txtDarlehensbetrag.Size = new System.Drawing.Size(125, 27);
            this.txtDarlehensbetrag.TabIndex = 1;
            this.txtDarlehensbetrag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDarlehensbetrag_KeyPress);
            // 
            // txtLaufdauer
            // 
            this.txtLaufdauer.Location = new System.Drawing.Point(182, 122);
            this.txtLaufdauer.Name = "txtLaufdauer";
            this.txtLaufdauer.Size = new System.Drawing.Size(125, 27);
            this.txtLaufdauer.TabIndex = 1;
            this.txtLaufdauer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLaufdauer_KeyPress);
            // 
            // lblLaufdauer
            // 
            this.lblLaufdauer.AutoSize = true;
            this.lblLaufdauer.Location = new System.Drawing.Point(32, 122);
            this.lblLaufdauer.Name = "lblLaufdauer";
            this.lblLaufdauer.Size = new System.Drawing.Size(107, 20);
            this.lblLaufdauer.TabIndex = 0;
            this.lblLaufdauer.Text = "Laufdauer (Jhr)";
            // 
            // lblInsgesamteZahlung
            // 
            this.lblInsgesamteZahlung.AutoSize = true;
            this.lblInsgesamteZahlung.Location = new System.Drawing.Point(32, 295);
            this.lblInsgesamteZahlung.Name = "lblInsgesamteZahlung";
            this.lblInsgesamteZahlung.Size = new System.Drawing.Size(125, 20);
            this.lblInsgesamteZahlung.TabIndex = 0;
            this.lblInsgesamteZahlung.Text = "Totaler Betrag (€)";
            // 
            // lblMontatlicheRate
            // 
            this.lblMontatlicheRate.AutoSize = true;
            this.lblMontatlicheRate.Location = new System.Drawing.Point(32, 241);
            this.lblMontatlicheRate.Name = "lblMontatlicheRate";
            this.lblMontatlicheRate.Size = new System.Drawing.Size(144, 20);
            this.lblMontatlicheRate.TabIndex = 0;
            this.lblMontatlicheRate.Text = "Montatliche Rate (€)";
            // 
            // lblZinshöhe
            // 
            this.lblZinshöhe.AutoSize = true;
            this.lblZinshöhe.Location = new System.Drawing.Point(32, 184);
            this.lblZinshöhe.Name = "lblZinshöhe";
            this.lblZinshöhe.Size = new System.Drawing.Size(95, 20);
            this.lblZinshöhe.TabIndex = 0;
            this.lblZinshöhe.Text = "Zinshöhe (%)";
            // 
            // lblDarlehensbetrag
            // 
            this.lblDarlehensbetrag.AutoSize = true;
            this.lblDarlehensbetrag.Location = new System.Drawing.Point(32, 67);
            this.lblDarlehensbetrag.Name = "lblDarlehensbetrag";
            this.lblDarlehensbetrag.Size = new System.Drawing.Size(141, 20);
            this.lblDarlehensbetrag.TabIndex = 0;
            this.lblDarlehensbetrag.Text = "Darlehensbetrag (€)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 653);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDarlehen);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.gbDarlehen.ResumeLayout(false);
            this.gbDarlehen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnKontostand;
        private System.Windows.Forms.Button btnAbheben;
        private System.Windows.Forms.Button btnEinzahlen;
        private System.Windows.Forms.Button btnDarlehen;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.Button btnTransaktionsBeleg;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button btnBestätigen;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnLöschen;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Label lblDarlehen;
        private System.Windows.Forms.Label lblAbheben;
        private System.Windows.Forms.Label lblEinzahlen;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.Label lblKontostand;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblLaufdauer;
        private System.Windows.Forms.Label lblInsgesamteZahlung;
        private System.Windows.Forms.Label lblZinshöhe;
        private System.Windows.Forms.Label lblDarlehensbetrag;
        private System.Windows.Forms.Button btnSchließen;
        private System.Windows.Forms.Button btnNeu;
        private System.Windows.Forms.Button btnBeleg;
        private System.Windows.Forms.Button btnLeihen;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtDarlehensbetrag;
        private System.Windows.Forms.TextBox txtZinshöhe;
        private System.Windows.Forms.TextBox txtInsgesamteZahlung;
        private System.Windows.Forms.TextBox txtLaufdauer;
        private System.Windows.Forms.TextBox txtMtlRate;
        private System.Windows.Forms.Label lblMontatlicheRate;
        private System.Windows.Forms.RichTextBox tTbBeleg;
        private System.Windows.Forms.RichTextBox rtbBeleg;
        private System.Windows.Forms.GroupBox gbDarlehen;
        private System.Windows.Forms.RichTextBox rtbTransaktionsBeleg;
    }
}

