namespace WinFormsApp_36_Run
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
        protected override void Dispose ( bool disposing )
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
        private void InitializeComponent ()
            {
            BTNrun = new Button();
            BTNbrowse = new Button();
            BTNhelp = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // BTNrun
            // 
            BTNrun.BackColor = Color.FromArgb(255, 224, 192);
            BTNrun.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BTNrun.Location = new Point(26, 50);
            BTNrun.Name = "BTNrun";
            BTNrun.Size = new Size(75, 36);
            BTNrun.TabIndex = 0;
            BTNrun.Text = "Run";
            BTNrun.UseVisualStyleBackColor = false;
            BTNrun.Click += BTNrun_Click;
            // 
            // BTNbrowse
            // 
            BTNbrowse.BackColor = Color.FromArgb(255, 224, 192);
            BTNbrowse.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BTNbrowse.Location = new Point(107, 50);
            BTNbrowse.Name = "BTNbrowse";
            BTNbrowse.Size = new Size(75, 36);
            BTNbrowse.TabIndex = 1;
            BTNbrowse.Text = "Browse";
            BTNbrowse.UseVisualStyleBackColor = false;
            BTNbrowse.Click += BTNbrowse_Click;
            // 
            // BTNhelp
            // 
            BTNhelp.BackColor = Color.FromArgb(255, 224, 192);
            BTNhelp.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BTNhelp.Location = new Point(188, 50);
            BTNhelp.Name = "BTNhelp";
            BTNhelp.Size = new Size(75, 36);
            BTNhelp.TabIndex = 2;
            BTNhelp.Text = "Help";
            BTNhelp.UseVisualStyleBackColor = false;
            BTNhelp.Click += BTNhelp_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(286, 23);
            textBox1.TabIndex = 3;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(316, 99);
            Controls.Add(textBox1);
            Controls.Add(BTNhelp);
            Controls.Add(BTNbrowse);
            Controls.Add(BTNrun);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Run | IPBSES";
            ResumeLayout(false);
            PerformLayout();
            }

        #endregion

        private Button BTNrun;
        private Button BTNbrowse;
        private Button BTNhelp;
        private TextBox textBox1;
        }
    }