namespace NirSoftNetTools
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Whois_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.WhoisResult_TextBox = new System.Windows.Forms.RichTextBox();
            this.domainName_TextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TR_ListView = new System.Windows.Forms.ListView();
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TraceRoute_Button = new System.Windows.Forms.Button();
            this.TraceRoute_TextBox = new System.Windows.Forms.TextBox();
            this.TR_InputTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.Resolver = new System.Windows.Forms.TabPage();
            this.Resolver_Button = new System.Windows.Forms.Button();
            this.Resolver_TextBox = new System.Windows.Forms.TextBox();
            this.Imei_Tab = new System.Windows.Forms.TabPage();
            this.IMEI_output_tb = new System.Windows.Forms.TextBox();
            this.IMEI_input_tb = new System.Windows.Forms.TextBox();
            this.IMEI_button = new System.Windows.Forms.Button();
            this.Tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.Resolver.SuspendLayout();
            this.Imei_Tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.tabPage1);
            this.Tab.Controls.Add(this.tabPage2);
            this.Tab.Controls.Add(this.tabPage3);
            this.Tab.Controls.Add(this.tabPage4);
            this.Tab.Controls.Add(this.tabPage5);
            this.Tab.Controls.Add(this.Resolver);
            this.Tab.Controls.Add(this.Imei_Tab);
            this.Tab.Location = new System.Drawing.Point(3, 3);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(1066, 608);
            this.Tab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Whois_button);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.WhoisResult_TextBox);
            this.tabPage1.Controls.Add(this.domainName_TextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1058, 582);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Инфо о владельцах";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // Whois_button
            // 
            this.Whois_button.Location = new System.Drawing.Point(642, 6);
            this.Whois_button.Name = "Whois_button";
            this.Whois_button.Size = new System.Drawing.Size(75, 21);
            this.Whois_button.TabIndex = 6;
            this.Whois_button.Text = "Добавить";
            this.Whois_button.UseVisualStyleBackColor = true;
            this.Whois_button.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Данный инструмент, позволет извлекать и просматривать актуальную информацию о вла" +
    "дельцах IP-адресов, сетей и автономных систем.";
            // 
            // WhoisResult_TextBox
            // 
            this.WhoisResult_TextBox.Location = new System.Drawing.Point(5, 35);
            this.WhoisResult_TextBox.Name = "WhoisResult_TextBox";
            this.WhoisResult_TextBox.Size = new System.Drawing.Size(1046, 541);
            this.WhoisResult_TextBox.TabIndex = 3;
            this.WhoisResult_TextBox.Text = "";
            // 
            // domainName_TextBox
            // 
            this.domainName_TextBox.Location = new System.Drawing.Point(384, 6);
            this.domainName_TextBox.Name = "domainName_TextBox";
            this.domainName_TextBox.Size = new System.Drawing.Size(252, 20);
            this.domainName_TextBox.TabIndex = 0;
            this.domainName_TextBox.Text = "google.com";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TR_ListView);
            this.tabPage2.Controls.Add(this.TraceRoute_Button);
            this.tabPage2.Controls.Add(this.TraceRoute_TextBox);
            this.tabPage2.Controls.Add(this.TR_InputTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1058, 582);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Trace Route";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TR_ListView
            // 
            this.TR_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader25});
            this.TR_ListView.Location = new System.Drawing.Point(3, 35);
            this.TR_ListView.Name = "TR_ListView";
            this.TR_ListView.Size = new System.Drawing.Size(663, 541);
            this.TR_ListView.TabIndex = 3;
            this.TR_ListView.UseCompatibleStateImageBehavior = false;
            this.TR_ListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "№";
            this.columnHeader22.Width = 31;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "EllapsedTime";
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "IP";
            this.columnHeader24.Width = 211;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "Host Name";
            this.columnHeader25.Width = 357;
            // 
            // TraceRoute_Button
            // 
            this.TraceRoute_Button.Location = new System.Drawing.Point(672, 6);
            this.TraceRoute_Button.Name = "TraceRoute_Button";
            this.TraceRoute_Button.Size = new System.Drawing.Size(380, 23);
            this.TraceRoute_Button.TabIndex = 2;
            this.TraceRoute_Button.Text = "TraceRoute";
            this.TraceRoute_Button.UseVisualStyleBackColor = true;
            this.TraceRoute_Button.Click += new System.EventHandler(this.TraceRoute_Button_Click);
            // 
            // TraceRoute_TextBox
            // 
            this.TraceRoute_TextBox.Location = new System.Drawing.Point(672, 35);
            this.TraceRoute_TextBox.Multiline = true;
            this.TraceRoute_TextBox.Name = "TraceRoute_TextBox";
            this.TraceRoute_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TraceRoute_TextBox.Size = new System.Drawing.Size(380, 541);
            this.TraceRoute_TextBox.TabIndex = 1;
            // 
            // TR_InputTextBox
            // 
            this.TR_InputTextBox.Location = new System.Drawing.Point(3, 6);
            this.TR_InputTextBox.Name = "TR_InputTextBox";
            this.TR_InputTextBox.Size = new System.Drawing.Size(663, 20);
            this.TR_InputTextBox.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1058, 582);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MAC";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 32);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(1046, 544);
            this.textBox4.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(965, 20);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "D8-CB-8A-7C-F2-FF";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(977, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button6);
            this.tabPage4.Controls.Add(this.textBox6);
            this.tabPage4.Controls.Add(this.textBox5);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1058, 582);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Operator from number";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(895, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(157, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "Стационарный";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(5, 32);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox6.Size = new System.Drawing.Size(1047, 545);
            this.textBox6.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(5, 6);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(747, 20);
            this.textBox5.TabIndex = 1;
            this.textBox5.Text = "89279239211";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(758, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Мобильный";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.textBox8);
            this.tabPage5.Controls.Add(this.textBox7);
            this.tabPage5.Controls.Add(this.button5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1058, 582);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Bank BIN Card";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(5, 12);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(966, 20);
            this.textBox8.TabIndex = 2;
            this.textBox8.Text = "639002";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(5, 38);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox7.Size = new System.Drawing.Size(1047, 539);
            this.textBox7.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(977, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "Пуск";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Resolver
            // 
            this.Resolver.Controls.Add(this.Resolver_Button);
            this.Resolver.Controls.Add(this.Resolver_TextBox);
            this.Resolver.Location = new System.Drawing.Point(4, 22);
            this.Resolver.Name = "Resolver";
            this.Resolver.Padding = new System.Windows.Forms.Padding(3);
            this.Resolver.Size = new System.Drawing.Size(1058, 582);
            this.Resolver.TabIndex = 5;
            this.Resolver.Text = "Resolver";
            this.Resolver.UseVisualStyleBackColor = true;
            // 
            // Resolver_Button
            // 
            this.Resolver_Button.Location = new System.Drawing.Point(198, 6);
            this.Resolver_Button.Name = "Resolver_Button";
            this.Resolver_Button.Size = new System.Drawing.Size(75, 23);
            this.Resolver_Button.TabIndex = 1;
            this.Resolver_Button.Text = "Resolve";
            this.Resolver_Button.UseVisualStyleBackColor = true;
            this.Resolver_Button.Click += new System.EventHandler(this.Resolver_Button_Click);
            // 
            // Resolver_TextBox
            // 
            this.Resolver_TextBox.Location = new System.Drawing.Point(6, 9);
            this.Resolver_TextBox.Name = "Resolver_TextBox";
            this.Resolver_TextBox.Size = new System.Drawing.Size(186, 20);
            this.Resolver_TextBox.TabIndex = 0;
            // 
            // Imei_Tab
            // 
            this.Imei_Tab.Controls.Add(this.IMEI_output_tb);
            this.Imei_Tab.Controls.Add(this.IMEI_input_tb);
            this.Imei_Tab.Controls.Add(this.IMEI_button);
            this.Imei_Tab.Location = new System.Drawing.Point(4, 22);
            this.Imei_Tab.Name = "Imei_Tab";
            this.Imei_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Imei_Tab.Size = new System.Drawing.Size(1058, 582);
            this.Imei_Tab.TabIndex = 6;
            this.Imei_Tab.Text = "IMEI";
            this.Imei_Tab.UseVisualStyleBackColor = true;
            // 
            // IMEI_output_tb
            // 
            this.IMEI_output_tb.Location = new System.Drawing.Point(3, 32);
            this.IMEI_output_tb.Multiline = true;
            this.IMEI_output_tb.Name = "IMEI_output_tb";
            this.IMEI_output_tb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.IMEI_output_tb.Size = new System.Drawing.Size(1049, 544);
            this.IMEI_output_tb.TabIndex = 2;
            // 
            // IMEI_input_tb
            // 
            this.IMEI_input_tb.Location = new System.Drawing.Point(6, 6);
            this.IMEI_input_tb.Name = "IMEI_input_tb";
            this.IMEI_input_tb.Size = new System.Drawing.Size(852, 20);
            this.IMEI_input_tb.TabIndex = 1;
            this.IMEI_input_tb.Text = "354869047125463";
            // 
            // IMEI_button
            // 
            this.IMEI_button.Location = new System.Drawing.Point(864, 6);
            this.IMEI_button.Name = "IMEI_button";
            this.IMEI_button.Size = new System.Drawing.Size(188, 23);
            this.IMEI_button.TabIndex = 0;
            this.IMEI_button.Text = "Пуск";
            this.IMEI_button.UseVisualStyleBackColor = true;
            this.IMEI_button.Click += new System.EventHandler(this.IMEI_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1071, 614);
            this.Controls.Add(this.Tab);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.Resolver.ResumeLayout(false);
            this.Resolver.PerformLayout();
            this.Imei_Tab.ResumeLayout(false);
            this.Imei_Tab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox domainName_TextBox;
        private System.Windows.Forms.RichTextBox WhoisResult_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Whois_button;
        private System.Windows.Forms.Button TraceRoute_Button;
        private System.Windows.Forms.TextBox TraceRoute_TextBox;
        private System.Windows.Forms.TextBox TR_InputTextBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TabPage Resolver;
        private System.Windows.Forms.Button Resolver_Button;
        private System.Windows.Forms.TextBox Resolver_TextBox;
        private System.Windows.Forms.ListView TR_ListView;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.TabPage Imei_Tab;
        private System.Windows.Forms.TextBox IMEI_output_tb;
        private System.Windows.Forms.TextBox IMEI_input_tb;
        private System.Windows.Forms.Button IMEI_button;
    }
}

