namespace Kalkulator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.labelCurrentOperation = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oMnieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacjeOProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyślijOpinięToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zgłośProblemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podajSugestięToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "C";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(247, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "*";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.operator_click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(174, 101);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "6";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(106, 101);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(36, 101);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(51, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(324, 72);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(51, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "CE";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(247, 72);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(51, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "/";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.operator_click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(174, 72);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(51, 23);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(106, 72);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(51, 23);
            this.button10.TabIndex = 9;
            this.button10.Text = "8";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button_click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(247, 161);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(51, 23);
            this.button11.TabIndex = 10;
            this.button11.Text = "+";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.operator_click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(174, 161);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(51, 23);
            this.button12.TabIndex = 11;
            this.button12.Text = ".";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.operator_click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(36, 161);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(121, 23);
            this.button13.TabIndex = 12;
            this.button13.Text = "0";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button_click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(324, 130);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(51, 54);
            this.button14.TabIndex = 13;
            this.button14.Text = "=";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(247, 132);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(51, 23);
            this.button15.TabIndex = 14;
            this.button15.Text = "-";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.operator_click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(174, 132);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(51, 23);
            this.button16.TabIndex = 15;
            this.button16.Text = "3";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button_click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(106, 132);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(51, 23);
            this.button17.TabIndex = 16;
            this.button17.Text = "2";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button_click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(36, 132);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(51, 23);
            this.button18.TabIndex = 17;
            this.button18.Text = "1";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button_click);
            // 
            // textBox_result
            // 
            this.textBox_result.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_result.Location = new System.Drawing.Point(36, 36);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_result.Size = new System.Drawing.Size(339, 20);
            this.textBox_result.TabIndex = 18;
            this.textBox_result.Text = "0";
            // 
            // labelCurrentOperation
            // 
            this.labelCurrentOperation.AutoSize = true;
            this.labelCurrentOperation.Location = new System.Drawing.Point(36, 13);
            this.labelCurrentOperation.Name = "labelCurrentOperation";
            this.labelCurrentOperation.Size = new System.Drawing.Size(0, 13);
            this.labelCurrentOperation.TabIndex = 19;
            this.labelCurrentOperation.Click += new System.EventHandler(this.Label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(393, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pomocOnlineToolStripMenuItem,
            this.oMnieToolStripMenuItem,
            this.informacjeOProgramieToolStripMenuItem,
            this.wyślijOpinięToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // pomocOnlineToolStripMenuItem
            // 
            this.pomocOnlineToolStripMenuItem.Name = "pomocOnlineToolStripMenuItem";
            this.pomocOnlineToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.pomocOnlineToolStripMenuItem.Text = "Pomoc on-line";
            // 
            // oMnieToolStripMenuItem
            // 
            this.oMnieToolStripMenuItem.Name = "oMnieToolStripMenuItem";
            this.oMnieToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.oMnieToolStripMenuItem.Text = "O mnie";
            this.oMnieToolStripMenuItem.Click += new System.EventHandler(this.oMnieToolStripMenuItem_Click);
            // 
            // informacjeOProgramieToolStripMenuItem
            // 
            this.informacjeOProgramieToolStripMenuItem.Name = "informacjeOProgramieToolStripMenuItem";
            this.informacjeOProgramieToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.informacjeOProgramieToolStripMenuItem.Text = "Informacje o programie";
            // 
            // wyślijOpinięToolStripMenuItem
            // 
            this.wyślijOpinięToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zgłośProblemToolStripMenuItem,
            this.podajSugestięToolStripMenuItem,
            this.ustawieniaToolStripMenuItem});
            this.wyślijOpinięToolStripMenuItem.Name = "wyślijOpinięToolStripMenuItem";
            this.wyślijOpinięToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.wyślijOpinięToolStripMenuItem.Text = "Wyślij opinię";
            // 
            // zgłośProblemToolStripMenuItem
            // 
            this.zgłośProblemToolStripMenuItem.Name = "zgłośProblemToolStripMenuItem";
            this.zgłośProblemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zgłośProblemToolStripMenuItem.Text = "Zgłoś problem";
            // 
            // podajSugestięToolStripMenuItem
            // 
            this.podajSugestięToolStripMenuItem.Name = "podajSugestięToolStripMenuItem";
            this.podajSugestięToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.podajSugestięToolStripMenuItem.Text = "Podaj sugestię";
            // 
            // ustawieniaToolStripMenuItem
            // 
            this.ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            this.ustawieniaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ustawieniaToolStripMenuItem.Text = "Ustawienia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 196);
            this.Controls.Add(this.labelCurrentOperation);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Label labelCurrentOperation;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocOnlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oMnieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacjeOProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyślijOpinięToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zgłośProblemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem podajSugestięToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem;
    }
}

