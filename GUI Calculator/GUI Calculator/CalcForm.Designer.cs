namespace GUI_Calculator
{
    partial class CalcForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.BtnSQRT = new System.Windows.Forms.Button();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.BtnMinus = new System.Windows.Forms.Button();
            this.BtnDivide = new System.Windows.Forms.Button();
            this.BtnMult = new System.Windows.Forms.Button();
            this.BtnEquals = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnDot = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCRT = new System.Windows.Forms.Button();
            this.BtnInv = new System.Windows.Forms.Button();
            this.BtnCos = new System.Windows.Forms.Button();
            this.BtnSin = new System.Windows.Forms.Button();
            this.BtnTan = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(6, 34);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(293, 29);
            this.txtDisplay.TabIndex = 0;
            // 
            // BtnSQRT
            // 
            this.BtnSQRT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSQRT.Location = new System.Drawing.Point(252, 77);
            this.BtnSQRT.Name = "BtnSQRT";
            this.BtnSQRT.Size = new System.Drawing.Size(47, 31);
            this.BtnSQRT.TabIndex = 1;
            this.BtnSQRT.Text = "√";
            this.BtnSQRT.UseVisualStyleBackColor = false;
            this.BtnSQRT.Click += new System.EventHandler(this.BtnSQRT_Click);
            // 
            // BtnPlus
            // 
            this.BtnPlus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlus.Location = new System.Drawing.Point(180, 88);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(47, 31);
            this.BtnPlus.TabIndex = 2;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = false;
            this.BtnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn3.Location = new System.Drawing.Point(112, 129);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(47, 31);
            this.Btn3.TabIndex = 3;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn2.Location = new System.Drawing.Point(59, 129);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(47, 31);
            this.Btn2.TabIndex = 4;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn1.Location = new System.Drawing.Point(6, 129);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(47, 31);
            this.Btn1.TabIndex = 5;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // BtnMinus
            // 
            this.BtnMinus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinus.Location = new System.Drawing.Point(180, 125);
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.Size = new System.Drawing.Size(47, 31);
            this.BtnMinus.TabIndex = 6;
            this.BtnMinus.Text = "-";
            this.BtnMinus.UseVisualStyleBackColor = false;
            this.BtnMinus.Click += new System.EventHandler(this.BtnMinus_Click);
            // 
            // BtnDivide
            // 
            this.BtnDivide.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDivide.Location = new System.Drawing.Point(180, 162);
            this.BtnDivide.Name = "BtnDivide";
            this.BtnDivide.Size = new System.Drawing.Size(47, 31);
            this.BtnDivide.TabIndex = 7;
            this.BtnDivide.Text = "÷";
            this.BtnDivide.UseVisualStyleBackColor = false;
            this.BtnDivide.Click += new System.EventHandler(this.BtnDivide_Click);
            // 
            // BtnMult
            // 
            this.BtnMult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMult.Location = new System.Drawing.Point(180, 199);
            this.BtnMult.Name = "BtnMult";
            this.BtnMult.Size = new System.Drawing.Size(47, 31);
            this.BtnMult.TabIndex = 8;
            this.BtnMult.Text = "×";
            this.BtnMult.UseVisualStyleBackColor = false;
            this.BtnMult.Click += new System.EventHandler(this.BtnMult_Click);
            // 
            // BtnEquals
            // 
            this.BtnEquals.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEquals.Location = new System.Drawing.Point(180, 250);
            this.BtnEquals.Name = "BtnEquals";
            this.BtnEquals.Size = new System.Drawing.Size(47, 100);
            this.BtnEquals.TabIndex = 9;
            this.BtnEquals.Text = "=";
            this.BtnEquals.UseVisualStyleBackColor = false;
            this.BtnEquals.Click += new System.EventHandler(this.BtnEqual_Click);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn4.Location = new System.Drawing.Point(6, 166);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(47, 31);
            this.Btn4.TabIndex = 12;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn5.Location = new System.Drawing.Point(59, 166);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(47, 31);
            this.Btn5.TabIndex = 11;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn6.Location = new System.Drawing.Point(112, 166);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(47, 31);
            this.Btn6.TabIndex = 10;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn7.Location = new System.Drawing.Point(6, 203);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(47, 31);
            this.Btn7.TabIndex = 15;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn8.Location = new System.Drawing.Point(59, 203);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(47, 31);
            this.Btn8.TabIndex = 14;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn9.Location = new System.Drawing.Point(112, 203);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(47, 31);
            this.Btn9.TabIndex = 13;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // Btn0
            // 
            this.Btn0.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn0.Location = new System.Drawing.Point(59, 240);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(47, 31);
            this.Btn0.TabIndex = 16;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnClear.Location = new System.Drawing.Point(6, 275);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(47, 31);
            this.BtnClear.TabIndex = 17;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnDot
            // 
            this.BtnDot.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDot.Location = new System.Drawing.Point(112, 275);
            this.BtnDot.Name = "BtnDot";
            this.BtnDot.Size = new System.Drawing.Size(47, 31);
            this.BtnDot.TabIndex = 18;
            this.BtnDot.Text = ".";
            this.BtnDot.UseVisualStyleBackColor = false;
            this.BtnDot.Click += new System.EventHandler(this.BtnDot_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(308, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "&File";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // BtnCRT
            // 
            this.BtnCRT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCRT.Location = new System.Drawing.Point(252, 116);
            this.BtnCRT.Name = "BtnCRT";
            this.BtnCRT.Size = new System.Drawing.Size(47, 31);
            this.BtnCRT.TabIndex = 20;
            this.BtnCRT.Text = "3√";
            this.BtnCRT.UseVisualStyleBackColor = false;
            this.BtnCRT.Click += new System.EventHandler(this.BtnCBRT_Click);
            // 
            // BtnInv
            // 
            this.BtnInv.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnInv.Location = new System.Drawing.Point(252, 153);
            this.BtnInv.Name = "BtnInv";
            this.BtnInv.Size = new System.Drawing.Size(47, 31);
            this.BtnInv.TabIndex = 21;
            this.BtnInv.Text = "Inv";
            this.BtnInv.UseVisualStyleBackColor = false;
            this.BtnInv.Click += new System.EventHandler(this.BtnInv_Click);
            // 
            // BtnCos
            // 
            this.BtnCos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCos.Location = new System.Drawing.Point(252, 287);
            this.BtnCos.Name = "BtnCos";
            this.BtnCos.Size = new System.Drawing.Size(47, 31);
            this.BtnCos.TabIndex = 24;
            this.BtnCos.Text = "Cos";
            this.BtnCos.UseVisualStyleBackColor = false;
            this.BtnCos.Click += new System.EventHandler(this.BtnCos_Click);
            // 
            // BtnSin
            // 
            this.BtnSin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSin.Location = new System.Drawing.Point(252, 250);
            this.BtnSin.Name = "BtnSin";
            this.BtnSin.Size = new System.Drawing.Size(47, 31);
            this.BtnSin.TabIndex = 23;
            this.BtnSin.Text = "Sin";
            this.BtnSin.UseVisualStyleBackColor = false;
            this.BtnSin.Click += new System.EventHandler(this.BtnSin_Click);
            // 
            // BtnTan
            // 
            this.BtnTan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnTan.Location = new System.Drawing.Point(252, 211);
            this.BtnTan.Name = "BtnTan";
            this.BtnTan.Size = new System.Drawing.Size(47, 31);
            this.BtnTan.TabIndex = 22;
            this.BtnTan.Text = "Tan";
            this.BtnTan.UseVisualStyleBackColor = false;
            this.BtnTan.Click += new System.EventHandler(this.BtnTan_Click);
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(308, 361);
            this.Controls.Add(this.BtnCos);
            this.Controls.Add(this.BtnSin);
            this.Controls.Add(this.BtnTan);
            this.Controls.Add(this.BtnInv);
            this.Controls.Add(this.BtnCRT);
            this.Controls.Add(this.BtnDot);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.BtnEquals);
            this.Controls.Add(this.BtnMult);
            this.Controls.Add(this.BtnDivide);
            this.Controls.Add(this.BtnMinus);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.BtnPlus);
            this.Controls.Add(this.BtnSQRT);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CalcForm";
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalcForm_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button BtnSQRT;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button BtnMinus;
        private System.Windows.Forms.Button BtnDivide;
        private System.Windows.Forms.Button BtnMult;
        private System.Windows.Forms.Button BtnEquals;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnDot;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.Button BtnCRT;
        private System.Windows.Forms.Button BtnInv;
        private System.Windows.Forms.Button BtnCos;
        private System.Windows.Forms.Button BtnSin;
        private System.Windows.Forms.Button BtnTan;
    }
}

