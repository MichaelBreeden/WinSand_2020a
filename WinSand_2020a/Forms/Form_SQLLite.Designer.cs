namespace WinSand_2020a.Forms
{
    partial class Form_SQLLite
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
            this.textBoxMessages = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage1_button_Add = new System.Windows.Forms.Button();
            this.tabPage1_textBox_FirstName = new System.Windows.Forms.TextBox();
            this.tabPage1_label_Person = new System.Windows.Forms.Label();
            this.tabPage1_label_FirstName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1_label_People = new System.Windows.Forms.Label();
            this.tabPage1_label_LastName = new System.Windows.Forms.Label();
            this.tabPage1_textBox_LastName = new System.Windows.Forms.TextBox();
            this.tabPage1_button_List = new System.Windows.Forms.Button();
            this.tabPage1_listBox_People = new System.Windows.Forms.ListBox();
            this.tabPage1_button_Delete = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxMessages
            // 
            this.textBoxMessages.Location = new System.Drawing.Point(12, 12);
            this.textBoxMessages.Multiline = true;
            this.textBoxMessages.Name = "textBoxMessages";
            this.textBoxMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMessages.Size = new System.Drawing.Size(356, 113);
            this.textBoxMessages.TabIndex = 4;
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(703, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(80, 25);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(7, 157);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 281);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabPage1_button_Delete);
            this.tabPage1.Controls.Add(this.tabPage1_listBox_People);
            this.tabPage1.Controls.Add(this.tabPage1_button_List);
            this.tabPage1.Controls.Add(this.tabPage1_textBox_LastName);
            this.tabPage1.Controls.Add(this.tabPage1_label_LastName);
            this.tabPage1.Controls.Add(this.tabPage1_label_People);
            this.tabPage1.Controls.Add(this.tabPage1_button_Add);
            this.tabPage1.Controls.Add(this.tabPage1_textBox_FirstName);
            this.tabPage1.Controls.Add(this.tabPage1_label_Person);
            this.tabPage1.Controls.Add(this.tabPage1_label_FirstName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 255);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SQLLite";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage1_button_Add
            // 
            this.tabPage1_button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1_button_Add.Location = new System.Drawing.Point(17, 117);
            this.tabPage1_button_Add.Name = "tabPage1_button_Add";
            this.tabPage1_button_Add.Size = new System.Drawing.Size(80, 25);
            this.tabPage1_button_Add.TabIndex = 3;
            this.tabPage1_button_Add.Text = "Add";
            this.tabPage1_button_Add.UseVisualStyleBackColor = true;
            this.tabPage1_button_Add.Click += new System.EventHandler(this.tabPage1_button_Add_Click);
            // 
            // tabPage1_textBox_FirstName
            // 
            this.tabPage1_textBox_FirstName.Location = new System.Drawing.Point(80, 38);
            this.tabPage1_textBox_FirstName.MaxLength = 100;
            this.tabPage1_textBox_FirstName.Name = "tabPage1_textBox_FirstName";
            this.tabPage1_textBox_FirstName.Size = new System.Drawing.Size(157, 20);
            this.tabPage1_textBox_FirstName.TabIndex = 2;
            // 
            // tabPage1_label_Person
            // 
            this.tabPage1_label_Person.AutoSize = true;
            this.tabPage1_label_Person.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1_label_Person.Location = new System.Drawing.Point(14, 12);
            this.tabPage1_label_Person.Name = "tabPage1_label_Person";
            this.tabPage1_label_Person.Size = new System.Drawing.Size(46, 13);
            this.tabPage1_label_Person.TabIndex = 1;
            this.tabPage1_label_Person.Text = "Person";
            // 
            // tabPage1_label_FirstName
            // 
            this.tabPage1_label_FirstName.AutoSize = true;
            this.tabPage1_label_FirstName.Location = new System.Drawing.Point(14, 41);
            this.tabPage1_label_FirstName.Name = "tabPage1_label_FirstName";
            this.tabPage1_label_FirstName.Size = new System.Drawing.Size(60, 13);
            this.tabPage1_label_FirstName.TabIndex = 0;
            this.tabPage1_label_FirstName.Text = "First Name:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 255);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Page 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1_label_People
            // 
            this.tabPage1_label_People.AutoSize = true;
            this.tabPage1_label_People.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1_label_People.Location = new System.Drawing.Point(323, 12);
            this.tabPage1_label_People.Name = "tabPage1_label_People";
            this.tabPage1_label_People.Size = new System.Drawing.Size(46, 13);
            this.tabPage1_label_People.TabIndex = 4;
            this.tabPage1_label_People.Text = "People";
            // 
            // tabPage1_label_LastName
            // 
            this.tabPage1_label_LastName.AutoSize = true;
            this.tabPage1_label_LastName.Location = new System.Drawing.Point(14, 67);
            this.tabPage1_label_LastName.Name = "tabPage1_label_LastName";
            this.tabPage1_label_LastName.Size = new System.Drawing.Size(61, 13);
            this.tabPage1_label_LastName.TabIndex = 5;
            this.tabPage1_label_LastName.Text = "Last Name:";
            // 
            // tabPage1_textBox_LastName
            // 
            this.tabPage1_textBox_LastName.Location = new System.Drawing.Point(80, 64);
            this.tabPage1_textBox_LastName.MaxLength = 100;
            this.tabPage1_textBox_LastName.Name = "tabPage1_textBox_LastName";
            this.tabPage1_textBox_LastName.Size = new System.Drawing.Size(157, 20);
            this.tabPage1_textBox_LastName.TabIndex = 6;
            // 
            // tabPage1_button_List
            // 
            this.tabPage1_button_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1_button_List.Location = new System.Drawing.Point(103, 117);
            this.tabPage1_button_List.Name = "tabPage1_button_List";
            this.tabPage1_button_List.Size = new System.Drawing.Size(80, 25);
            this.tabPage1_button_List.TabIndex = 7;
            this.tabPage1_button_List.Text = "List";
            this.tabPage1_button_List.UseVisualStyleBackColor = true;
            this.tabPage1_button_List.Click += new System.EventHandler(this.tabPage1_button_List_Click);
            // 
            // tabPage1_listBox_People
            // 
            this.tabPage1_listBox_People.FormattingEnabled = true;
            this.tabPage1_listBox_People.Location = new System.Drawing.Point(326, 41);
            this.tabPage1_listBox_People.Name = "tabPage1_listBox_People";
            this.tabPage1_listBox_People.Size = new System.Drawing.Size(231, 186);
            this.tabPage1_listBox_People.TabIndex = 8;
            // 
            // tabPage1_button_Delete
            // 
            this.tabPage1_button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1_button_Delete.Location = new System.Drawing.Point(17, 148);
            this.tabPage1_button_Delete.Name = "tabPage1_button_Delete";
            this.tabPage1_button_Delete.Size = new System.Drawing.Size(80, 25);
            this.tabPage1_button_Delete.TabIndex = 9;
            this.tabPage1_button_Delete.Text = "Delete";
            this.tabPage1_button_Delete.UseVisualStyleBackColor = true;
            this.tabPage1_button_Delete.Click += new System.EventHandler(this.tabPage1_button_Delete_Click);
            // 
            // Form_SQLLite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBoxMessages);
            this.Controls.Add(this.buttonClose);
            this.Name = "Form_SQLLite";
            this.Text = "Form_SQLLite";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMessages;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button tabPage1_button_List;
        private System.Windows.Forms.TextBox tabPage1_textBox_LastName;
        private System.Windows.Forms.Label tabPage1_label_LastName;
        private System.Windows.Forms.Label tabPage1_label_People;
        private System.Windows.Forms.Button tabPage1_button_Add;
        private System.Windows.Forms.TextBox tabPage1_textBox_FirstName;
        private System.Windows.Forms.Label tabPage1_label_Person;
        private System.Windows.Forms.Label tabPage1_label_FirstName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox tabPage1_listBox_People;
        private System.Windows.Forms.Button tabPage1_button_Delete;
    }
}