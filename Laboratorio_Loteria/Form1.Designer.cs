namespace Laboratorio_Loteria
{
    
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabVender = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnVenderMensual = new System.Windows.Forms.Button();
            this.txtNumeroMensual = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreMensual = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVenderSemanal = new System.Windows.Forms.Button();
            this.txtNumero2Semanal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumero1Semanal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreSemanal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVenderDiario = new System.Windows.Forms.Button();
            this.txtNumero5Diario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumero4Diario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNumero3Diario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumero2Diario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero1Diario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreDiario = new System.Windows.Forms.TextBox();
            this.lblNombreDiario = new System.Windows.Forms.Label();
            this.tabJugar = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnJugarMensual = new System.Windows.Forms.Button();
            this.lstGanadoresMensual = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnJugarSemanal = new System.Windows.Forms.Button();
            this.lstGanadoresSemanal = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnJugarDiario = new System.Windows.Forms.Button();
            this.lstGanadoresDiario = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabVender.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabJugar.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabVender);
            this.tabControl1.Controls.Add(this.tabJugar);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(686, 390);
            this.tabControl1.TabIndex = 0;
            // 
            // tabVender
            // 
            this.tabVender.Controls.Add(this.groupBox3);
            this.tabVender.Controls.Add(this.groupBox2);
            this.tabVender.Controls.Add(this.groupBox1);
            this.tabVender.Location = new System.Drawing.Point(4, 22);
            this.tabVender.Name = "tabVender";
            this.tabVender.Padding = new System.Windows.Forms.Padding(3);
            this.tabVender.Size = new System.Drawing.Size(678, 364);
            this.tabVender.TabIndex = 0;
            this.tabVender.Text = "Vender Boletos";
            this.tabVender.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnVenderMensual);
            this.groupBox3.Controls.Add(this.txtNumeroMensual);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtNombreMensual);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(17, 243);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(643, 104);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Venta Mensual";
            // 
            // btnVenderMensual
            // 
            this.btnVenderMensual.Location = new System.Drawing.Point(514, 35);
            this.btnVenderMensual.Name = "btnVenderMensual";
            this.btnVenderMensual.Size = new System.Drawing.Size(103, 43);
            this.btnVenderMensual.TabIndex = 4;
            this.btnVenderMensual.Text = "Vender";
            this.btnVenderMensual.UseVisualStyleBackColor = true;
            this.btnVenderMensual.Click += new System.EventHandler(this.btnVenderMensual_Click);
            // 
            // txtNumeroMensual
            // 
            this.txtNumeroMensual.Location = new System.Drawing.Point(343, 52);
            this.txtNumeroMensual.Name = "txtNumeroMensual";
            this.txtNumeroMensual.Size = new System.Drawing.Size(86, 20);
            this.txtNumeroMensual.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(343, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Número:";
            // 
            // txtNombreMensual
            // 
            this.txtNombreMensual.Location = new System.Drawing.Point(17, 52);
            this.txtNombreMensual.Name = "txtNombreMensual";
            this.txtNombreMensual.Size = new System.Drawing.Size(301, 20);
            this.txtNombreMensual.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nombre del cliente:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVenderSemanal);
            this.groupBox2.Controls.Add(this.txtNumero2Semanal);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtNumero1Semanal);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtNombreSemanal);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(17, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 104);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Venta Semanal";
            // 
            // btnVenderSemanal
            // 
            this.btnVenderSemanal.Location = new System.Drawing.Point(514, 35);
            this.btnVenderSemanal.Name = "btnVenderSemanal";
            this.btnVenderSemanal.Size = new System.Drawing.Size(103, 43);
            this.btnVenderSemanal.TabIndex = 6;
            this.btnVenderSemanal.Text = "Vender";
            this.btnVenderSemanal.UseVisualStyleBackColor = true;
            this.btnVenderSemanal.Click += new System.EventHandler(this.btnVenderSemanal_Click);
            // 
            // txtNumero2Semanal
            // 
            this.txtNumero2Semanal.Location = new System.Drawing.Point(429, 52);
            this.txtNumero2Semanal.Name = "txtNumero2Semanal";
            this.txtNumero2Semanal.Size = new System.Drawing.Size(43, 20);
            this.txtNumero2Semanal.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Número 2:";
            // 
            // txtNumero1Semanal
            // 
            this.txtNumero1Semanal.Location = new System.Drawing.Point(343, 52);
            this.txtNumero1Semanal.Name = "txtNumero1Semanal";
            this.txtNumero1Semanal.Size = new System.Drawing.Size(43, 20);
            this.txtNumero1Semanal.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Número 1:";
            // 
            // txtNombreSemanal
            // 
            this.txtNombreSemanal.Location = new System.Drawing.Point(17, 52);
            this.txtNombreSemanal.Name = "txtNombreSemanal";
            this.txtNombreSemanal.Size = new System.Drawing.Size(301, 20);
            this.txtNombreSemanal.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre del cliente:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVenderDiario);
            this.groupBox1.Controls.Add(this.txtNumero5Diario);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtNumero4Diario);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtNumero3Diario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNumero2Diario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNumero1Diario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombreDiario);
            this.groupBox1.Controls.Add(this.lblNombreDiario);
            this.groupBox1.Location = new System.Drawing.Point(17, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venta Diaria";
            // 
            // btnVenderDiario
            // 
            this.btnVenderDiario.Location = new System.Drawing.Point(514, 35);
            this.btnVenderDiario.Name = "btnVenderDiario";
            this.btnVenderDiario.Size = new System.Drawing.Size(103, 43);
            this.btnVenderDiario.TabIndex = 12;
            this.btnVenderDiario.Text = "Vender";
            this.btnVenderDiario.UseVisualStyleBackColor = true;
            this.btnVenderDiario.Click += new System.EventHandler(this.btnVenderDiario_Click);
            // 
            // txtNumero5Diario
            // 
            this.txtNumero5Diario.Location = new System.Drawing.Point(463, 52);
            this.txtNumero5Diario.Name = "txtNumero5Diario";
            this.txtNumero5Diario.Size = new System.Drawing.Size(43, 20);
            this.txtNumero5Diario.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(463, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Número 5:";
            // 
            // txtNumero4Diario
            // 
            this.txtNumero4Diario.Location = new System.Drawing.Point(403, 52);
            this.txtNumero4Diario.Name = "txtNumero4Diario";
            this.txtNumero4Diario.Size = new System.Drawing.Size(43, 20);
            this.txtNumero4Diario.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(403, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Número 4:";
            // 
            // txtNumero3Diario
            // 
            this.txtNumero3Diario.Location = new System.Drawing.Point(343, 52);
            this.txtNumero3Diario.Name = "txtNumero3Diario";
            this.txtNumero3Diario.Size = new System.Drawing.Size(43, 20);
            this.txtNumero3Diario.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Número 3:";
            // 
            // txtNumero2Diario
            // 
            this.txtNumero2Diario.Location = new System.Drawing.Point(283, 52);
            this.txtNumero2Diario.Name = "txtNumero2Diario";
            this.txtNumero2Diario.Size = new System.Drawing.Size(43, 20);
            this.txtNumero2Diario.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número 2:";
            // 
            // txtNumero1Diario
            // 
            this.txtNumero1Diario.Location = new System.Drawing.Point(223, 52);
            this.txtNumero1Diario.Name = "txtNumero1Diario";
            this.txtNumero1Diario.Size = new System.Drawing.Size(43, 20);
            this.txtNumero1Diario.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número 1:";
            // 
            // txtNombreDiario
            // 
            this.txtNombreDiario.Location = new System.Drawing.Point(17, 52);
            this.txtNombreDiario.Name = "txtNombreDiario";
            this.txtNombreDiario.Size = new System.Drawing.Size(172, 20);
            this.txtNombreDiario.TabIndex = 1;
            // 
            // lblNombreDiario
            // 
            this.lblNombreDiario.AutoSize = true;
            this.lblNombreDiario.Location = new System.Drawing.Point(17, 35);
            this.lblNombreDiario.Name = "lblNombreDiario";
            this.lblNombreDiario.Size = new System.Drawing.Size(98, 13);
            this.lblNombreDiario.TabIndex = 0;
            this.lblNombreDiario.Text = "Nombre del cliente:";
            // 
            // tabJugar
            // 
            this.tabJugar.Controls.Add(this.groupBox6);
            this.tabJugar.Controls.Add(this.groupBox5);
            this.tabJugar.Controls.Add(this.groupBox4);
            this.tabJugar.Location = new System.Drawing.Point(4, 22);
            this.tabJugar.Name = "tabJugar";
            this.tabJugar.Padding = new System.Windows.Forms.Padding(3);
            this.tabJugar.Size = new System.Drawing.Size(678, 364);
            this.tabJugar.TabIndex = 1;
            this.tabJugar.Text = "Jugar";
            this.tabJugar.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnJugarMensual);
            this.groupBox6.Controls.Add(this.lstGanadoresMensual);
            this.groupBox6.Location = new System.Drawing.Point(17, 243);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(643, 104);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Juego Mensual";
            // 
            // btnJugarMensual
            // 
            this.btnJugarMensual.Location = new System.Drawing.Point(17, 35);
            this.btnJugarMensual.Name = "btnJugarMensual";
            this.btnJugarMensual.Size = new System.Drawing.Size(103, 43);
            this.btnJugarMensual.TabIndex = 1;
            this.btnJugarMensual.Text = "Jugar";
            this.btnJugarMensual.UseVisualStyleBackColor = true;
            this.btnJugarMensual.Click += new System.EventHandler(this.btnJugarMensual_Click);
            // 
            // lstGanadoresMensual
            // 
            this.lstGanadoresMensual.FormattingEnabled = true;
            this.lstGanadoresMensual.Location = new System.Drawing.Point(137, 17);
            this.lstGanadoresMensual.Name = "lstGanadoresMensual";
            this.lstGanadoresMensual.Size = new System.Drawing.Size(498, 82);
            this.lstGanadoresMensual.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnJugarSemanal);
            this.groupBox5.Controls.Add(this.lstGanadoresSemanal);
            this.groupBox5.Location = new System.Drawing.Point(17, 130);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(643, 104);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Juego Semanal";
            // 
            // btnJugarSemanal
            // 
            this.btnJugarSemanal.Location = new System.Drawing.Point(17, 35);
            this.btnJugarSemanal.Name = "btnJugarSemanal";
            this.btnJugarSemanal.Size = new System.Drawing.Size(103, 43);
            this.btnJugarSemanal.TabIndex = 1;
            this.btnJugarSemanal.Text = "Jugar";
            this.btnJugarSemanal.UseVisualStyleBackColor = true;
            this.btnJugarSemanal.Click += new System.EventHandler(this.btnJugarSemanal_Click);
            // 
            // lstGanadoresSemanal
            // 
            this.lstGanadoresSemanal.FormattingEnabled = true;
            this.lstGanadoresSemanal.Location = new System.Drawing.Point(137, 17);
            this.lstGanadoresSemanal.Name = "lstGanadoresSemanal";
            this.lstGanadoresSemanal.Size = new System.Drawing.Size(498, 82);
            this.lstGanadoresSemanal.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnJugarDiario);
            this.groupBox4.Controls.Add(this.lstGanadoresDiario);
            this.groupBox4.Location = new System.Drawing.Point(17, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(643, 104);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Juego Diario";
            // 
            // btnJugarDiario
            // 
            this.btnJugarDiario.Location = new System.Drawing.Point(17, 35);
            this.btnJugarDiario.Name = "btnJugarDiario";
            this.btnJugarDiario.Size = new System.Drawing.Size(103, 43);
            this.btnJugarDiario.TabIndex = 1;
            this.btnJugarDiario.Text = "Jugar";
            this.btnJugarDiario.UseVisualStyleBackColor = true;
            this.btnJugarDiario.Click += new System.EventHandler(this.btnJugarDiario_Click);
            // 
            // lstGanadoresDiario
            // 
            this.lstGanadoresDiario.FormattingEnabled = true;
            this.lstGanadoresDiario.Location = new System.Drawing.Point(137, 17);
            this.lstGanadoresDiario.Name = "lstGanadoresDiario";
            this.lstGanadoresDiario.Size = new System.Drawing.Size(498, 82);
            this.lstGanadoresDiario.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Sistema de Lotería";
            this.tabControl1.ResumeLayout(false);
            this.tabVender.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabJugar.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabVender;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnVenderMensual;
        private System.Windows.Forms.TextBox txtNumeroMensual;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombreMensual;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVenderSemanal;
        private System.Windows.Forms.TextBox txtNumero2Semanal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumero1Semanal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreSemanal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVenderDiario;
        private System.Windows.Forms.TextBox txtNumero5Diario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumero4Diario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNumero3Diario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumero2Diario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero1Diario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreDiario;
        private System.Windows.Forms.Label lblNombreDiario;
        private System.Windows.Forms.TabPage tabJugar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnJugarMensual;
        private System.Windows.Forms.ListBox lstGanadoresMensual;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnJugarSemanal;
        private System.Windows.Forms.ListBox lstGanadoresSemanal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnJugarDiario;
        private System.Windows.Forms.ListBox lstGanadoresDiario;
    }
}

