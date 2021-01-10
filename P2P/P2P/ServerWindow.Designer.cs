using System;

namespace P2P
{
    partial class ServerWindow
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
            this.button1 = new System.Windows.Forms.Button();
            this.serverrunlabel = new System.Windows.Forms.Label();
            this.filetransferlabel = new System.Windows.Forms.Label();
            this.Backbutton = new System.Windows.Forms.Button();
            this.closeserverbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Run SERVER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // serverrunlabel
            // 
            this.serverrunlabel.AutoSize = true;
            this.serverrunlabel.Location = new System.Drawing.Point(280, 168);
            this.serverrunlabel.Name = "serverrunlabel";
            this.serverrunlabel.Size = new System.Drawing.Size(188, 17);
            this.serverrunlabel.TabIndex = 1;
            this.serverrunlabel.Text = "SERVER UP AND RUNNING";
            this.serverrunlabel.Visible = false;
            // 
            // filetransferlabel
            // 
            this.filetransferlabel.AutoSize = true;
            this.filetransferlabel.Location = new System.Drawing.Point(270, 233);
            this.filetransferlabel.Name = "filetransferlabel";
            this.filetransferlabel.Size = new System.Drawing.Size(209, 17);
            this.filetransferlabel.TabIndex = 2;
            this.filetransferlabel.Text = "WAITING FOR FILE TRANSFER";
            this.filetransferlabel.Visible = false;
            this.filetransferlabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // Backbutton
            // 
            this.Backbutton.Location = new System.Drawing.Point(81, 337);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(104, 45);
            this.Backbutton.TabIndex = 4;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // closeserverbutton
            // 
            this.closeserverbutton.Enabled = false;
            this.closeserverbutton.Location = new System.Drawing.Point(544, 337);
            this.closeserverbutton.Name = "closeserverbutton";
            this.closeserverbutton.Size = new System.Drawing.Size(187, 45);
            this.closeserverbutton.TabIndex = 5;
            this.closeserverbutton.Text = "Close SERVER";
            this.closeserverbutton.UseVisualStyleBackColor = true;
            this.closeserverbutton.Visible = false;
            this.closeserverbutton.Click += new System.EventHandler(this.closeserverbutton_Click);
            // 
            // ServerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeserverbutton);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.filetransferlabel);
            this.Controls.Add(this.serverrunlabel);
            this.Controls.Add(this.button1);
            this.Name = "ServerWindow";
            this.Text = "ServerWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label serverrunlabel;
        private System.Windows.Forms.Label filetransferlabel;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.Button closeserverbutton;
    }
}