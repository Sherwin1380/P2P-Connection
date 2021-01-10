namespace P2P
{
    partial class ClientWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iptextbox = new System.Windows.Forms.TextBox();
            this.porttextbox = new System.Windows.Forms.TextBox();
            this.sendbutton = new System.Windows.Forms.Button();
            this.okbutton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.selectfilebutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Statustextbox = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP ADDRESS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "PORT NUMBER";
            // 
            // iptextbox
            // 
            this.iptextbox.Location = new System.Drawing.Point(203, 66);
            this.iptextbox.Name = "iptextbox";
            this.iptextbox.Size = new System.Drawing.Size(250, 22);
            this.iptextbox.TabIndex = 2;
            this.iptextbox.Text = "192.168.1.143";
            // 
            // porttextbox
            // 
            this.porttextbox.Location = new System.Drawing.Point(203, 128);
            this.porttextbox.Name = "porttextbox";
            this.porttextbox.Size = new System.Drawing.Size(250, 22);
            this.porttextbox.TabIndex = 3;
            this.porttextbox.Text = "1134";
            // 
            // sendbutton
            // 
            this.sendbutton.Location = new System.Drawing.Point(222, 371);
            this.sendbutton.Name = "sendbutton";
            this.sendbutton.Size = new System.Drawing.Size(194, 47);
            this.sendbutton.TabIndex = 6;
            this.sendbutton.Text = "SEND";
            this.sendbutton.UseVisualStyleBackColor = true;
            this.sendbutton.Visible = false;
            this.sendbutton.Click += new System.EventHandler(this.sendbutton_Click);
            // 
            // okbutton
            // 
            this.okbutton.Location = new System.Drawing.Point(257, 177);
            this.okbutton.Name = "okbutton";
            this.okbutton.Size = new System.Drawing.Size(98, 32);
            this.okbutton.TabIndex = 7;
            this.okbutton.Text = "OK";
            this.okbutton.UseVisualStyleBackColor = true;
            this.okbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // selectfilebutton
            // 
            this.selectfilebutton.Location = new System.Drawing.Point(188, 249);
            this.selectfilebutton.Name = "selectfilebutton";
            this.selectfilebutton.Size = new System.Drawing.Size(265, 61);
            this.selectfilebutton.TabIndex = 8;
            this.selectfilebutton.Text = "SELECT FILE TO SEND";
            this.selectfilebutton.UseVisualStyleBackColor = true;
            this.selectfilebutton.Visible = false;
            this.selectfilebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "SERVER STATUS";
            // 
            // Statustextbox
            // 
            this.Statustextbox.AutoSize = true;
            this.Statustextbox.BackColor = System.Drawing.SystemColors.InfoText;
            this.Statustextbox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Statustextbox.Location = new System.Drawing.Point(529, 165);
            this.Statustextbox.Name = "Statustextbox";
            this.Statustextbox.Size = new System.Drawing.Size(66, 17);
            this.Statustextbox.TabIndex = 10;
            this.Statustextbox.Text = "Unknown";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ClientWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Statustextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectfilebutton);
            this.Controls.Add(this.okbutton);
            this.Controls.Add(this.sendbutton);
            this.Controls.Add(this.porttextbox);
            this.Controls.Add(this.iptextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ClientWindow";
            this.Text = "ClientWindow";
            this.Load += new System.EventHandler(this.ClientWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox iptextbox;
        private System.Windows.Forms.TextBox porttextbox;
        private System.Windows.Forms.Button sendbutton;
        private System.Windows.Forms.Button okbutton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button selectfilebutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Statustextbox;
        private System.Windows.Forms.Button button1;
    }
}