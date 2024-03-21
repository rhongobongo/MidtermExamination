namespace TestForm
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
            dgvStudentInfo = new DataGridView();
            tabPage3 = new TabPage();
            tabPage2 = new TabPage();
            label15 = new Label();
            textBoxTo = new TextBox();
            textBoxFrom = new TextBox();
            label14 = new Label();
            tabPage1 = new TabPage();
            textBox13 = new TextBox();
            label13 = new Label();
            textBox12 = new TextBox();
            label12 = new Label();
            textBox11 = new TextBox();
            label11 = new Label();
            textBox10 = new TextBox();
            label10 = new Label();
            textBox08 = new TextBox();
            label9 = new Label();
            textBox07 = new TextBox();
            label8 = new Label();
            textBox06 = new TextBox();
            label7 = new Label();
            textBox05 = new TextBox();
            label6 = new Label();
            textBox04 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            textBoxID = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            trackBarAppRating = new TrackBar();
            labelRating = new Label();
            textBox03 = new TextBox();
            textBox02 = new TextBox();
            textBox01 = new TextBox();
            label3 = new Label();
            btnInput = new Button();
            label2 = new Label();
            label1 = new Label();
            tabControl1 = new TabControl();
            btnQuery = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudentInfo).BeginInit();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarAppRating).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvStudentInfo
            // 
            dgvStudentInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentInfo.Location = new Point(279, 39);
            dgvStudentInfo.Name = "dgvStudentInfo";
            dgvStudentInfo.Size = new Size(959, 604);
            dgvStudentInfo.TabIndex = 2;
            dgvStudentInfo.CellClick += dgvStudentInfo_CellClick;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(257, 354);
            tabPage3.TabIndex = 1;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnQuery);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(textBoxTo);
            tabPage2.Controls.Add(textBoxFrom);
            tabPage2.Controls.Add(label14);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(257, 614);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "QUERY";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(121, 24);
            label15.Name = "label15";
            label15.Size = new Size(18, 15);
            label15.TabIndex = 3;
            label15.Text = "to";
            label15.Click += label15_Click;
            // 
            // textBoxTo
            // 
            textBoxTo.Location = new Point(159, 21);
            textBoxTo.Name = "textBoxTo";
            textBoxTo.Size = new Size(92, 23);
            textBoxTo.TabIndex = 2;
            // 
            // textBoxFrom
            // 
            textBoxFrom.Location = new Point(6, 21);
            textBoxFrom.Name = "textBoxFrom";
            textBoxFrom.Size = new Size(95, 23);
            textBoxFrom.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 3);
            label14.Name = "label14";
            label14.Size = new Size(54, 15);
            label14.TabIndex = 0;
            label14.Text = "ID Range";
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(textBox13);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(textBox12);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(textBox11);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(textBox10);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(textBox08);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(textBox07);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(textBox06);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(textBox05);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(textBox04);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(textBoxID);
            tabPage1.Controls.Add(btnDelete);
            tabPage1.Controls.Add(btnUpdate);
            tabPage1.Controls.Add(trackBarAppRating);
            tabPage1.Controls.Add(labelRating);
            tabPage1.Controls.Add(textBox03);
            tabPage1.Controls.Add(textBox02);
            tabPage1.Controls.Add(textBox01);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(btnInput);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(257, 614);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "CRUD";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(8, 439);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(240, 23);
            textBox13.TabIndex = 30;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(7, 421);
            label13.Name = "label13";
            label13.Size = new Size(72, 15);
            label13.TabIndex = 29;
            label13.Text = "Android Ver.";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(130, 395);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(118, 23);
            textBox12.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(130, 377);
            label12.Name = "label12";
            label12.Size = new Size(69, 15);
            label12.TabIndex = 27;
            label12.Text = "Current Ver.";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(6, 395);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(118, 23);
            textBox11.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 377);
            label11.Name = "label11";
            label11.Size = new Size(76, 15);
            label11.TabIndex = 25;
            label11.Text = "Last Updated";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(8, 351);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(240, 23);
            textBox10.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 333);
            label10.Name = "label10";
            label10.Size = new Size(38, 15);
            label10.TabIndex = 23;
            label10.Text = "Genre";
            // 
            // textBox08
            // 
            textBox08.Location = new Point(130, 307);
            textBox08.Name = "textBox08";
            textBox08.Size = new Size(118, 23);
            textBox08.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(130, 289);
            label9.Name = "label9";
            label9.Size = new Size(87, 15);
            label9.TabIndex = 21;
            label9.Text = "Content Rating";
            // 
            // textBox07
            // 
            textBox07.Location = new Point(6, 307);
            textBox07.Name = "textBox07";
            textBox07.Size = new Size(118, 23);
            textBox07.TabIndex = 20;
            textBox07.TextChanged += textBox07_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 289);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 19;
            label8.Text = "Price";
            // 
            // textBox06
            // 
            textBox06.Location = new Point(130, 263);
            textBox06.Name = "textBox06";
            textBox06.Size = new Size(121, 23);
            textBox06.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(130, 245);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 17;
            label7.Text = "Type";
            // 
            // textBox05
            // 
            textBox05.Location = new Point(6, 263);
            textBox05.Name = "textBox05";
            textBox05.Size = new Size(118, 23);
            textBox05.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 245);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 15;
            label6.Text = "Installs";
            // 
            // textBox04
            // 
            textBox04.Location = new Point(130, 219);
            textBox04.Name = "textBox04";
            textBox04.Size = new Size(121, 23);
            textBox04.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(130, 201);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 13;
            label5.Text = "Size";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 3);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 12;
            label4.Text = "ID";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(6, 21);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(245, 23);
            textBoxID.TabIndex = 11;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(6, 569);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(244, 38);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDeleteStudent_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(6, 525);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(244, 38);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Modify";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdateStudent_Click;
            // 
            // trackBarAppRating
            // 
            trackBarAppRating.LargeChange = 1;
            trackBarAppRating.Location = new Point(6, 153);
            trackBarAppRating.Maximum = 50;
            trackBarAppRating.Minimum = 1;
            trackBarAppRating.Name = "trackBarAppRating";
            trackBarAppRating.Size = new Size(244, 45);
            trackBarAppRating.TabIndex = 8;
            trackBarAppRating.Value = 1;
            trackBarAppRating.ValueChanged += trackBarAppRating_ValueChanged;
            // 
            // labelRating
            // 
            labelRating.AutoSize = true;
            labelRating.Location = new Point(7, 135);
            labelRating.Name = "labelRating";
            labelRating.Size = new Size(41, 15);
            labelRating.TabIndex = 7;
            labelRating.Text = "Rating";
            // 
            // textBox03
            // 
            textBox03.Location = new Point(6, 219);
            textBox03.Name = "textBox03";
            textBox03.Size = new Size(118, 23);
            textBox03.TabIndex = 6;
            // 
            // textBox02
            // 
            textBox02.Location = new Point(7, 109);
            textBox02.Name = "textBox02";
            textBox02.Size = new Size(245, 23);
            textBox02.TabIndex = 3;
            // 
            // textBox01
            // 
            textBox01.Location = new Point(6, 65);
            textBox01.Name = "textBox01";
            textBox01.Size = new Size(245, 23);
            textBox01.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 201);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 5;
            label3.Text = "Review";
            // 
            // btnInput
            // 
            btnInput.Location = new Point(7, 481);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(244, 38);
            btnInput.TabIndex = 4;
            btnInput.Text = "Input";
            btnInput.UseVisualStyleBackColor = true;
            btnInput.Click += btnInputStudent_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 91);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 2;
            label2.Text = "Category";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 47);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Application Name";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(265, 642);
            tabControl1.TabIndex = 3;
            // 
            // btnQuery
            // 
            btnQuery.Location = new Point(6, 567);
            btnQuery.Name = "btnQuery";
            btnQuery.Size = new Size(245, 40);
            btnQuery.TabIndex = 4;
            btnQuery.Text = "Query";
            btnQuery.UseVisualStyleBackColor = true;
            btnQuery.Click += btnQuery_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 666);
            Controls.Add(tabControl1);
            Controls.Add(dgvStudentInfo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvStudentInfo).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarAppRating).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvStudentInfo;
        private TabPage tabPage3;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private TrackBar trackBarAppRating;
        private Label labelRating;
        private TextBox textBox03;
        private TextBox textBox02;
        private TextBox textBox01;
        private Label label3;
        private Button btnInput;
        private Label label2;
        private Label label1;
        private TabControl tabControl1;
        private Button btnDelete;
        private Button btnUpdate;
        private Label label4;
        private TextBox textBoxID;
        private TextBox textBox04;
        private Label label5;
        private TextBox textBox07;
        private Label label8;
        private TextBox textBox06;
        private Label label7;
        private TextBox textBox05;
        private Label label6;
        private TextBox textBox11;
        private Label label11;
        private TextBox textBox10;
        private Label label10;
        private TextBox textBox08;
        private Label label9;
        private TextBox textBox13;
        private Label label13;
        private TextBox textBox12;
        private Label label12;
        private TextBox textBoxFrom;
        private Label label14;
        private TextBox textBoxTo;
        private Label label15;
        private Button btnQuery;
        /*private Label label5;
private Label label4;
private TextBox cn3;
private Label label7;
private Label label6;
private TextBox cn2;
private TextBox cn1;
private TextBox cn5;
private Label label8;
private TextBox cn4;*/
    }
}
