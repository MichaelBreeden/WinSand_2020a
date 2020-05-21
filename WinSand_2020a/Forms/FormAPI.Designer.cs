namespace WinSand_2020a.Forms
{
    partial class FormAPI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_API_1 = new System.Windows.Forms.TabPage();
            this.tabPage_API_1_textBox_Response = new System.Windows.Forms.TextBox();
            this.tabPage_API_1_button_Go = new System.Windows.Forms.Button();
            this.tabPage_API_1textBox_URL = new System.Windows.Forms.TextBox();
            this.tabPage_API_1_label_URL = new System.Windows.Forms.Label();
            this.tabPage_API_1_label_Video = new System.Windows.Forms.Label();
            this.tabPage_API_2 = new System.Windows.Forms.TabPage();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxMessages = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage_API_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_API_1);
            this.tabControl1.Controls.Add(this.tabPage_API_2);
            this.tabControl1.Location = new System.Drawing.Point(12, 157);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 281);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_API_1
            // 
            this.tabPage_API_1.Controls.Add(this.tabPage_API_1_textBox_Response);
            this.tabPage_API_1.Controls.Add(this.tabPage_API_1_button_Go);
            this.tabPage_API_1.Controls.Add(this.tabPage_API_1textBox_URL);
            this.tabPage_API_1.Controls.Add(this.tabPage_API_1_label_URL);
            this.tabPage_API_1.Controls.Add(this.tabPage_API_1_label_Video);
            this.tabPage_API_1.Location = new System.Drawing.Point(4, 22);
            this.tabPage_API_1.Name = "tabPage_API_1";
            this.tabPage_API_1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_API_1.Size = new System.Drawing.Size(768, 255);
            this.tabPage_API_1.TabIndex = 0;
            this.tabPage_API_1.Text = "API 1";
            this.tabPage_API_1.UseVisualStyleBackColor = true;
            // 
            // tabPage_API_1_textBox_Response
            // 
            this.tabPage_API_1_textBox_Response.Location = new System.Drawing.Point(56, 45);
            this.tabPage_API_1_textBox_Response.Multiline = true;
            this.tabPage_API_1_textBox_Response.Name = "tabPage_API_1_textBox_Response";
            this.tabPage_API_1_textBox_Response.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tabPage_API_1_textBox_Response.Size = new System.Drawing.Size(487, 113);
            this.tabPage_API_1_textBox_Response.TabIndex = 4;
            // 
            // tabPage_API_1_button_Go
            // 
            this.tabPage_API_1_button_Go.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_API_1_button_Go.Location = new System.Drawing.Point(682, 6);
            this.tabPage_API_1_button_Go.Name = "tabPage_API_1_button_Go";
            this.tabPage_API_1_button_Go.Size = new System.Drawing.Size(80, 25);
            this.tabPage_API_1_button_Go.TabIndex = 3;
            this.tabPage_API_1_button_Go.Text = "Go";
            this.tabPage_API_1_button_Go.UseVisualStyleBackColor = true;
            this.tabPage_API_1_button_Go.Click += new System.EventHandler(this.tabPage_API_1_button_Go_Click);
            // 
            // tabPage_API_1textBox_URL
            // 
            this.tabPage_API_1textBox_URL.Location = new System.Drawing.Point(56, 9);
            this.tabPage_API_1textBox_URL.Name = "tabPage_API_1textBox_URL";
            this.tabPage_API_1textBox_URL.Size = new System.Drawing.Size(487, 20);
            this.tabPage_API_1textBox_URL.TabIndex = 2;
            // 
            // tabPage_API_1_label_URL
            // 
            this.tabPage_API_1_label_URL.AutoSize = true;
            this.tabPage_API_1_label_URL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_API_1_label_URL.Location = new System.Drawing.Point(14, 12);
            this.tabPage_API_1_label_URL.Name = "tabPage_API_1_label_URL";
            this.tabPage_API_1_label_URL.Size = new System.Drawing.Size(36, 13);
            this.tabPage_API_1_label_URL.TabIndex = 1;
            this.tabPage_API_1_label_URL.Text = "URL:";
            // 
            // tabPage_API_1_label_Video
            // 
            this.tabPage_API_1_label_Video.AutoSize = true;
            this.tabPage_API_1_label_Video.Location = new System.Drawing.Point(6, 230);
            this.tabPage_API_1_label_Video.Name = "tabPage_API_1_label_Video";
            this.tabPage_API_1_label_Video.Size = new System.Drawing.Size(151, 13);
            this.tabPage_API_1_label_Video.TabIndex = 0;
            this.tabPage_API_1_label_Video.Text = "C# REST Client - Les Jackson";
            // 
            // tabPage_API_2
            // 
            this.tabPage_API_2.Location = new System.Drawing.Point(4, 22);
            this.tabPage_API_2.Name = "tabPage_API_2";
            this.tabPage_API_2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_API_2.Size = new System.Drawing.Size(768, 255);
            this.tabPage_API_2.TabIndex = 1;
            this.tabPage_API_2.Text = "API 2";
            this.tabPage_API_2.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(703, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(80, 25);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxMessages
            // 
            this.textBoxMessages.Location = new System.Drawing.Point(12, 12);
            this.textBoxMessages.Multiline = true;
            this.textBoxMessages.Name = "textBoxMessages";
            this.textBoxMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMessages.Size = new System.Drawing.Size(356, 113);
            this.textBoxMessages.TabIndex = 2;
            // 
            // FormAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxMessages);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAPI";
            this.Text = "FormAPI";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_API_1.ResumeLayout(false);
            this.tabPage_API_1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_API_1;
        private System.Windows.Forms.TabPage tabPage_API_2;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxMessages;
        private System.Windows.Forms.Label tabPage_API_1_label_Video;
        private System.Windows.Forms.TextBox tabPage_API_1textBox_URL;
        private System.Windows.Forms.Label tabPage_API_1_label_URL;
        private System.Windows.Forms.Button tabPage_API_1_button_Go;
        private System.Windows.Forms.TextBox tabPage_API_1_textBox_Response;
    }
}