namespace DigitalClock_Timer
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
            this.components = new System.ComponentModel.Container();
            this.lbl_second = new System.Windows.Forms.Label();
            this.lbl_minute = new System.Windows.Forms.Label();
            this.lbl_hour = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_second
            // 
            this.lbl_second.AutoSize = true;
            this.lbl_second.BackColor = System.Drawing.Color.Transparent;
            this.lbl_second.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_second.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_second.Location = new System.Drawing.Point(228, 108);
            this.lbl_second.Name = "lbl_second";
            this.lbl_second.Size = new System.Drawing.Size(98, 72);
            this.lbl_second.TabIndex = 0;
            this.lbl_second.Text = "00";
            // 
            // lbl_minute
            // 
            this.lbl_minute.AutoSize = true;
            this.lbl_minute.BackColor = System.Drawing.Color.Transparent;
            this.lbl_minute.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_minute.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_minute.Location = new System.Drawing.Point(376, 108);
            this.lbl_minute.Name = "lbl_minute";
            this.lbl_minute.Size = new System.Drawing.Size(98, 72);
            this.lbl_minute.TabIndex = 1;
            this.lbl_minute.Text = "00";
            // 
            // lbl_hour
            // 
            this.lbl_hour.AutoSize = true;
            this.lbl_hour.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hour.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hour.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_hour.Location = new System.Drawing.Point(524, 108);
            this.lbl_hour.Name = "lbl_hour";
            this.lbl_hour.Size = new System.Drawing.Size(98, 72);
            this.lbl_hour.TabIndex = 2;
            this.lbl_hour.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(332, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 57);
            this.label4.TabIndex = 3;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(480, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 57);
            this.label5.TabIndex = 4;
            this.label5.Text = ":";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(843, 280);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_hour);
            this.Controls.Add(this.lbl_minute);
            this.Controls.Add(this.lbl_second);
            this.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_second;
        private System.Windows.Forms.Label lbl_minute;
        private System.Windows.Forms.Label lbl_hour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}

