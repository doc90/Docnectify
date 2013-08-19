namespace Docnectify
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
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Ssid = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.TextBox();
            this.Pulisci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(222, 12);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(53, 20);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Stop.Enabled = false;
            this.Stop.Location = new System.Drawing.Point(222, 38);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(53, 20);
            this.Stop.TabIndex = 1;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Ssid
            // 
            this.Ssid.Location = new System.Drawing.Point(74, 12);
            this.Ssid.Name = "Ssid";
            this.Ssid.Size = new System.Drawing.Size(132, 20);
            this.Ssid.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(74, 38);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(132, 20);
            this.Password.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome rete";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(15, 64);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Output.Size = new System.Drawing.Size(260, 154);
            this.Output.TabIndex = 6;
            // 
            // Pulisci
            // 
            this.Pulisci.Location = new System.Drawing.Point(15, 224);
            this.Pulisci.Name = "Pulisci";
            this.Pulisci.Size = new System.Drawing.Size(77, 21);
            this.Pulisci.TabIndex = 7;
            this.Pulisci.Text = "Pulisci Log";
            this.Pulisci.UseVisualStyleBackColor = true;
            this.Pulisci.Click += new System.EventHandler(this.Pulisci_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.Start;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Stop;
            this.ClientSize = new System.Drawing.Size(290, 256);
            this.Controls.Add(this.Pulisci);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Ssid);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "DocNectify v.0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.TextBox Ssid;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button Pulisci;
    }
}

