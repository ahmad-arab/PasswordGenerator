
namespace PasswordGenerator
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.nNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.tbDataSource = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nLength = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCapitals = new System.Windows.Forms.CheckBox();
            this.cbSymbols = new System.Windows.Forms.CheckBox();
            this.cbNumbers = new System.Windows.Forms.CheckBox();
            this.cbSmall = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.wCapital = new System.Windows.Forms.NumericUpDown();
            this.wSymbols = new System.Windows.Forms.NumericUpDown();
            this.wNumbers = new System.Windows.Forms.NumericUpDown();
            this.wSmall = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rdUsername = new System.Windows.Forms.RadioButton();
            this.rdPassword = new System.Windows.Forms.RadioButton();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wCapital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wSymbols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wNumbers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wSmall)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 15, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number";
            // 
            // nNumber
            // 
            this.nNumber.Location = new System.Drawing.Point(88, 22);
            this.nNumber.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nNumber.Name = "nNumber";
            this.nNumber.Size = new System.Drawing.Size(64, 22);
            this.nNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(15, 15, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filter by Note";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(500, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(459, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Username,
            this.Password,
            this.Note});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(27, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(653, 433);
            this.dataGridView1.TabIndex = 5;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 30;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.Width = 75;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.Width = 75;
            // 
            // Note
            // 
            this.Note.HeaderText = "Note";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            this.Note.Width = 125;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 53);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(246, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Add to DataBase";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(713, 89);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(246, 30);
            this.button3.TabIndex = 7;
            this.button3.Text = "Update DataBase";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(713, 197);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(246, 30);
            this.button4.TabIndex = 8;
            this.button4.Text = "Import from DataBase";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(713, 125);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(246, 30);
            this.button5.TabIndex = 9;
            this.button5.Text = "Delete from DataBase";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(713, 456);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(246, 30);
            this.button6.TabIndex = 10;
            this.button6.Text = "Save as document";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(713, 420);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(246, 30);
            this.button7.TabIndex = 11;
            this.button7.Text = "Clear Grid";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(713, 161);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(246, 30);
            this.button8.TabIndex = 12;
            this.button8.Text = "Clear DataBase";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // tbDataSource
            // 
            this.tbDataSource.Location = new System.Drawing.Point(117, 501);
            this.tbDataSource.Name = "tbDataSource";
            this.tbDataSource.Size = new System.Drawing.Size(415, 22);
            this.tbDataSource.TabIndex = 14;
            this.tbDataSource.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 504);
            this.label3.Margin = new System.Windows.Forms.Padding(15, 15, 3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Data Source";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Length";
            // 
            // nLength
            // 
            this.nLength.Location = new System.Drawing.Point(222, 22);
            this.nLength.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nLength.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nLength.Name = "nLength";
            this.nLength.Size = new System.Drawing.Size(64, 22);
            this.nLength.TabIndex = 16;
            this.nLength.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nLength.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(710, 504);
            this.label5.Margin = new System.Windows.Forms.Padding(15, 15, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Developer: Eng.Ahmad Arab";
            // 
            // cbCapitals
            // 
            this.cbCapitals.AutoSize = true;
            this.cbCapitals.Checked = true;
            this.cbCapitals.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCapitals.Location = new System.Drawing.Point(713, 272);
            this.cbCapitals.Margin = new System.Windows.Forms.Padding(15, 5, 3, 3);
            this.cbCapitals.Name = "cbCapitals";
            this.cbCapitals.Size = new System.Drawing.Size(116, 21);
            this.cbCapitals.TabIndex = 19;
            this.cbCapitals.Text = "Capital letters";
            this.cbCapitals.UseVisualStyleBackColor = true;
            this.cbCapitals.CheckedChanged += new System.EventHandler(this.capital_CheckedChanged);
            // 
            // cbSymbols
            // 
            this.cbSymbols.AutoSize = true;
            this.cbSymbols.Checked = true;
            this.cbSymbols.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSymbols.Location = new System.Drawing.Point(713, 359);
            this.cbSymbols.Margin = new System.Windows.Forms.Padding(15, 5, 3, 3);
            this.cbSymbols.Name = "cbSymbols";
            this.cbSymbols.Size = new System.Drawing.Size(83, 21);
            this.cbSymbols.TabIndex = 21;
            this.cbSymbols.Text = "Symbols";
            this.cbSymbols.UseVisualStyleBackColor = true;
            this.cbSymbols.CheckedChanged += new System.EventHandler(this.cbSymbols_CheckedChanged);
            // 
            // cbNumbers
            // 
            this.cbNumbers.AutoSize = true;
            this.cbNumbers.Checked = true;
            this.cbNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNumbers.Location = new System.Drawing.Point(713, 330);
            this.cbNumbers.Margin = new System.Windows.Forms.Padding(15, 5, 3, 3);
            this.cbNumbers.Name = "cbNumbers";
            this.cbNumbers.Size = new System.Drawing.Size(87, 21);
            this.cbNumbers.TabIndex = 22;
            this.cbNumbers.Text = "Numbers";
            this.cbNumbers.UseVisualStyleBackColor = true;
            this.cbNumbers.CheckedChanged += new System.EventHandler(this.cbNumbers_CheckedChanged);
            // 
            // cbSmall
            // 
            this.cbSmall.AutoSize = true;
            this.cbSmall.Checked = true;
            this.cbSmall.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSmall.Location = new System.Drawing.Point(713, 301);
            this.cbSmall.Margin = new System.Windows.Forms.Padding(15, 5, 3, 3);
            this.cbSmall.Name = "cbSmall";
            this.cbSmall.Size = new System.Drawing.Size(107, 21);
            this.cbSmall.TabIndex = 23;
            this.cbSmall.Text = "Small letters";
            this.cbSmall.UseVisualStyleBackColor = true;
            this.cbSmall.CheckedChanged += new System.EventHandler(this.cbSmall_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(710, 245);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 15, 3, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Include:";
            // 
            // wCapital
            // 
            this.wCapital.Location = new System.Drawing.Point(911, 272);
            this.wCapital.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.wCapital.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wCapital.Name = "wCapital";
            this.wCapital.Size = new System.Drawing.Size(48, 22);
            this.wCapital.TabIndex = 25;
            this.wCapital.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wCapital.ValueChanged += new System.EventHandler(this.wCapital_ValueChanged);
            // 
            // wSymbols
            // 
            this.wSymbols.Location = new System.Drawing.Point(911, 359);
            this.wSymbols.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.wSymbols.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wSymbols.Name = "wSymbols";
            this.wSymbols.Size = new System.Drawing.Size(48, 22);
            this.wSymbols.TabIndex = 27;
            this.wSymbols.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wSymbols.ValueChanged += new System.EventHandler(this.wSymbols_ValueChanged);
            // 
            // wNumbers
            // 
            this.wNumbers.Location = new System.Drawing.Point(911, 330);
            this.wNumbers.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.wNumbers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wNumbers.Name = "wNumbers";
            this.wNumbers.Size = new System.Drawing.Size(48, 22);
            this.wNumbers.TabIndex = 28;
            this.wNumbers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wNumbers.ValueChanged += new System.EventHandler(this.wNumbers_ValueChanged);
            // 
            // wSmall
            // 
            this.wSmall.Location = new System.Drawing.Point(911, 301);
            this.wSmall.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.wSmall.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wSmall.Name = "wSmall";
            this.wSmall.Size = new System.Drawing.Size(48, 22);
            this.wSmall.TabIndex = 29;
            this.wSmall.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wSmall.ValueChanged += new System.EventHandler(this.wSmall_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(891, 274);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "x";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(891, 361);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "x";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(891, 332);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "x";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(891, 303);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 17);
            this.label10.TabIndex = 33;
            this.label10.Text = "x";
            // 
            // rdUsername
            // 
            this.rdUsername.AutoSize = true;
            this.rdUsername.Checked = true;
            this.rdUsername.Location = new System.Drawing.Point(773, 243);
            this.rdUsername.Name = "rdUsername";
            this.rdUsername.Size = new System.Drawing.Size(94, 21);
            this.rdUsername.TabIndex = 34;
            this.rdUsername.TabStop = true;
            this.rdUsername.Text = "Username";
            this.rdUsername.UseVisualStyleBackColor = true;
            this.rdUsername.CheckedChanged += new System.EventHandler(this.rdUsername_CheckedChanged);
            // 
            // rdPassword
            // 
            this.rdPassword.AutoSize = true;
            this.rdPassword.Location = new System.Drawing.Point(869, 243);
            this.rdPassword.Name = "rdPassword";
            this.rdPassword.Size = new System.Drawing.Size(90, 21);
            this.rdPassword.TabIndex = 35;
            this.rdPassword.Text = "Password";
            this.rdPassword.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(538, 497);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(68, 30);
            this.button9.TabIndex = 36;
            this.button9.Text = "Brows";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(612, 497);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(68, 30);
            this.button10.TabIndex = 37;
            this.button10.Text = "Create";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 545);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.rdPassword);
            this.Controls.Add(this.rdUsername);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.wSmall);
            this.Controls.Add(this.wNumbers);
            this.Controls.Add(this.wSymbols);
            this.Controls.Add(this.wCapital);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbSmall);
            this.Controls.Add(this.cbNumbers);
            this.Controls.Add(this.cbSymbols);
            this.Controls.Add(this.cbCapitals);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nLength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDataSource);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nNumber);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordGenerator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wCapital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wSymbols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wNumbers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wSmall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox tbDataSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbCapitals;
        private System.Windows.Forms.CheckBox cbSymbols;
        private System.Windows.Forms.CheckBox cbNumbers;
        private System.Windows.Forms.CheckBox cbSmall;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown wCapital;
        private System.Windows.Forms.NumericUpDown wSymbols;
        private System.Windows.Forms.NumericUpDown wNumbers;
        private System.Windows.Forms.NumericUpDown wSmall;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rdUsername;
        private System.Windows.Forms.RadioButton rdPassword;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}

