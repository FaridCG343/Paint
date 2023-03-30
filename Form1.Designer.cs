namespace Paint
{
    partial class frmcgfPaint
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
            pnlcgfPanel = new Panel();
            btncgfColorActual = new Button();
            btncgfBorrar = new Button();
            lblcgfGrosor = new Label();
            btncgfLapiz = new Button();
            btncgfBorrador = new Button();
            btncgfColorDialog = new Button();
            button18 = new Button();
            button17 = new Button();
            button16 = new Button();
            button15 = new Button();
            button14 = new Button();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            tcbcgfGrosorLapiz = new TrackBar();
            colorDialogcgf = new ColorDialog();
            pnlcgfPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tcbcgfGrosorLapiz).BeginInit();
            SuspendLayout();
            // 
            // pnlcgfPanel
            // 
            pnlcgfPanel.BackColor = Color.LightGray;
            pnlcgfPanel.Controls.Add(btncgfColorActual);
            pnlcgfPanel.Controls.Add(btncgfBorrar);
            pnlcgfPanel.Controls.Add(lblcgfGrosor);
            pnlcgfPanel.Controls.Add(btncgfLapiz);
            pnlcgfPanel.Controls.Add(btncgfBorrador);
            pnlcgfPanel.Controls.Add(btncgfColorDialog);
            pnlcgfPanel.Controls.Add(button18);
            pnlcgfPanel.Controls.Add(button17);
            pnlcgfPanel.Controls.Add(button16);
            pnlcgfPanel.Controls.Add(button15);
            pnlcgfPanel.Controls.Add(button14);
            pnlcgfPanel.Controls.Add(button13);
            pnlcgfPanel.Controls.Add(button12);
            pnlcgfPanel.Controls.Add(button11);
            pnlcgfPanel.Controls.Add(button10);
            pnlcgfPanel.Controls.Add(button9);
            pnlcgfPanel.Controls.Add(button8);
            pnlcgfPanel.Controls.Add(button7);
            pnlcgfPanel.Controls.Add(button6);
            pnlcgfPanel.Controls.Add(button5);
            pnlcgfPanel.Controls.Add(button4);
            pnlcgfPanel.Controls.Add(button3);
            pnlcgfPanel.Controls.Add(button2);
            pnlcgfPanel.Controls.Add(button1);
            pnlcgfPanel.Controls.Add(tcbcgfGrosorLapiz);
            pnlcgfPanel.Dock = DockStyle.Top;
            pnlcgfPanel.Location = new Point(0, 0);
            pnlcgfPanel.Name = "pnlcgfPanel";
            pnlcgfPanel.Size = new Size(784, 100);
            pnlcgfPanel.TabIndex = 0;
            // 
            // btncgfColorActual
            // 
            btncgfColorActual.BackColor = Color.Black;
            btncgfColorActual.Enabled = false;
            btncgfColorActual.FlatAppearance.BorderSize = 0;
            btncgfColorActual.FlatStyle = FlatStyle.Flat;
            btncgfColorActual.Location = new Point(507, 36);
            btncgfColorActual.Name = "btncgfColorActual";
            btncgfColorActual.Size = new Size(20, 20);
            btncgfColorActual.TabIndex = 24;
            btncgfColorActual.UseVisualStyleBackColor = false;
            // 
            // btncgfBorrar
            // 
            btncgfBorrar.Location = new Point(12, 20);
            btncgfBorrar.Name = "btncgfBorrar";
            btncgfBorrar.Size = new Size(74, 61);
            btncgfBorrar.TabIndex = 23;
            btncgfBorrar.Text = "Limpiar";
            btncgfBorrar.UseVisualStyleBackColor = true;
            btncgfBorrar.Click += btncgfClear_Click;
            // 
            // lblcgfGrosor
            // 
            lblcgfGrosor.AutoSize = true;
            lblcgfGrosor.ForeColor = Color.Black;
            lblcgfGrosor.Location = new Point(259, 10);
            lblcgfGrosor.Name = "lblcgfGrosor";
            lblcgfGrosor.Size = new Size(54, 15);
            lblcgfGrosor.TabIndex = 22;
            lblcgfGrosor.Text = "Grosor: 4";
            // 
            // btncgfLapiz
            // 
            btncgfLapiz.BackgroundImage = Properties.Resources.lapiz;
            btncgfLapiz.BackgroundImageLayout = ImageLayout.Stretch;
            btncgfLapiz.Location = new Point(92, 20);
            btncgfLapiz.Name = "btncgfLapiz";
            btncgfLapiz.Size = new Size(75, 61);
            btncgfLapiz.TabIndex = 21;
            btncgfLapiz.UseVisualStyleBackColor = true;
            btncgfLapiz.Click += btncgfLapiz_Click;
            // 
            // btncgfBorrador
            // 
            btncgfBorrador.BackgroundImage = Properties.Resources.borrador;
            btncgfBorrador.BackgroundImageLayout = ImageLayout.Stretch;
            btncgfBorrador.Location = new Point(173, 20);
            btncgfBorrador.Name = "btncgfBorrador";
            btncgfBorrador.Size = new Size(80, 61);
            btncgfBorrador.TabIndex = 20;
            btncgfBorrador.UseVisualStyleBackColor = true;
            btncgfBorrador.Click += btncgfBorrador_Click;
            // 
            // btncgfColorDialog
            // 
            btncgfColorDialog.BackgroundImage = Properties.Resources.acuarela;
            btncgfColorDialog.BackgroundImageLayout = ImageLayout.Stretch;
            btncgfColorDialog.Location = new Point(385, 10);
            btncgfColorDialog.Name = "btncgfColorDialog";
            btncgfColorDialog.Size = new Size(106, 67);
            btncgfColorDialog.TabIndex = 19;
            btncgfColorDialog.UseVisualStyleBackColor = true;
            btncgfColorDialog.Click += btncgfColorDialog_Click;
            // 
            // button18
            // 
            button18.BackColor = Color.FromArgb(255, 128, 255);
            button18.FlatAppearance.BorderSize = 0;
            button18.FlatStyle = FlatStyle.Flat;
            button18.Location = new Point(752, 48);
            button18.Name = "button18";
            button18.Size = new Size(20, 20);
            button18.TabIndex = 18;
            button18.UseVisualStyleBackColor = false;
            button18.Click += btnColor_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.FromArgb(128, 128, 255);
            button17.FlatAppearance.BorderSize = 0;
            button17.FlatStyle = FlatStyle.Flat;
            button17.Location = new Point(726, 48);
            button17.Name = "button17";
            button17.Size = new Size(20, 20);
            button17.TabIndex = 17;
            button17.UseVisualStyleBackColor = false;
            button17.Click += btnColor_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.FromArgb(128, 255, 128);
            button16.FlatAppearance.BorderSize = 0;
            button16.FlatStyle = FlatStyle.Flat;
            button16.Location = new Point(700, 48);
            button16.Name = "button16";
            button16.Size = new Size(20, 20);
            button16.TabIndex = 16;
            button16.UseVisualStyleBackColor = false;
            button16.Click += btnColor_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.FromArgb(255, 255, 128);
            button15.FlatAppearance.BorderSize = 0;
            button15.FlatStyle = FlatStyle.Flat;
            button15.Location = new Point(674, 48);
            button15.Name = "button15";
            button15.Size = new Size(20, 20);
            button15.TabIndex = 15;
            button15.UseVisualStyleBackColor = false;
            button15.Click += btnColor_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.FromArgb(255, 192, 128);
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatStyle = FlatStyle.Flat;
            button14.Location = new Point(648, 48);
            button14.Name = "button14";
            button14.Size = new Size(20, 20);
            button14.TabIndex = 14;
            button14.UseVisualStyleBackColor = false;
            button14.Click += btnColor_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(255, 128, 128);
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Location = new Point(622, 48);
            button13.Name = "button13";
            button13.Size = new Size(20, 20);
            button13.TabIndex = 13;
            button13.UseVisualStyleBackColor = false;
            button13.Click += btnColor_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(64, 0, 0);
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Location = new Point(596, 22);
            button12.Name = "button12";
            button12.Size = new Size(20, 20);
            button12.TabIndex = 12;
            button12.UseVisualStyleBackColor = false;
            button12.Click += btnColor_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.Silver;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Location = new Point(544, 48);
            button11.Name = "button11";
            button11.Size = new Size(20, 20);
            button11.TabIndex = 11;
            button11.UseVisualStyleBackColor = false;
            button11.Click += btnColor_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.Black;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Location = new Point(570, 22);
            button10.Name = "button10";
            button10.Size = new Size(20, 20);
            button10.TabIndex = 10;
            button10.UseVisualStyleBackColor = false;
            button10.Click += btnColor_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Fuchsia;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Location = new Point(752, 22);
            button9.Name = "button9";
            button9.Size = new Size(20, 20);
            button9.TabIndex = 9;
            button9.UseVisualStyleBackColor = false;
            button9.Click += btnColor_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Blue;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(726, 22);
            button8.Name = "button8";
            button8.Size = new Size(20, 20);
            button8.TabIndex = 8;
            button8.UseVisualStyleBackColor = false;
            button8.Click += btnColor_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Lime;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(700, 22);
            button7.Name = "button7";
            button7.Size = new Size(20, 20);
            button7.TabIndex = 7;
            button7.UseVisualStyleBackColor = false;
            button7.Click += btnColor_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Yellow;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(674, 22);
            button6.Name = "button6";
            button6.Size = new Size(20, 20);
            button6.TabIndex = 6;
            button6.UseVisualStyleBackColor = false;
            button6.Click += btnColor_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 128, 0);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(648, 22);
            button5.Name = "button5";
            button5.Size = new Size(20, 20);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = false;
            button5.Click += btnColor_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(622, 22);
            button4.Name = "button4";
            button4.Size = new Size(20, 20);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = false;
            button4.Click += btnColor_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Brown;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(596, 48);
            button3.Name = "button3";
            button3.Size = new Size(20, 20);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnColor_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(544, 22);
            button2.Name = "button2";
            button2.Size = new Size(20, 20);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnColor_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(570, 48);
            button1.Name = "button1";
            button1.Size = new Size(20, 20);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnColor_Click;
            // 
            // tcbcgfGrosorLapiz
            // 
            tcbcgfGrosorLapiz.LargeChange = 1;
            tcbcgfGrosorLapiz.Location = new Point(259, 36);
            tcbcgfGrosorLapiz.Maximum = 14;
            tcbcgfGrosorLapiz.Minimum = 4;
            tcbcgfGrosorLapiz.Name = "tcbcgfGrosorLapiz";
            tcbcgfGrosorLapiz.Size = new Size(120, 45);
            tcbcgfGrosorLapiz.TabIndex = 0;
            tcbcgfGrosorLapiz.Value = 4;
            tcbcgfGrosorLapiz.Scroll += tcbcgfGrosorLapiz_Scroll;
            // 
            // frmcgfPaint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 461);
            Controls.Add(pnlcgfPanel);
            ForeColor = Color.Black;
            Name = "frmcgfPaint";
            Text = "Paint";
            MouseDown += frmcgfPaint_MouseDown;
            MouseMove += frmcgfPaint_MouseMove;
            MouseUp += frmcgfPaint_MouseUp;
            pnlcgfPanel.ResumeLayout(false);
            pnlcgfPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tcbcgfGrosorLapiz).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlcgfPanel;
        private Button btncgfBorrador;
        private Button btncgfColorDialog;
        private Button button18;
        private Button button17;
        private Button button16;
        private Button button15;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TrackBar tcbcgfGrosorLapiz;
        private ColorDialog colorDialogcgf;
        private Button btncgfLapiz;
        private Label lblcgfGrosor;
        private Button btncgfBorrar;
        private Button btncgfColorActual;
    }
}