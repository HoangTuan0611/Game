namespace game
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_diem = new System.Windows.Forms.Label();
            this.lb_loi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_countdown = new System.Windows.Forms.Label();
            this.pic1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_diem
            // 
            this.lb_diem.AutoSize = true;
            this.lb_diem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_diem.Location = new System.Drawing.Point(390, 110);
            this.lb_diem.Name = "lb_diem";
            this.lb_diem.Size = new System.Drawing.Size(73, 20);
            this.lb_diem.TabIndex = 2;
            this.lb_diem.Text = "SCORE";
            // 
            // lb_loi
            // 
            this.lb_loi.AutoSize = true;
            this.lb_loi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_loi.Location = new System.Drawing.Point(390, 226);
            this.lb_loi.Name = "lb_loi";
            this.lb_loi.Size = new System.Drawing.Size(86, 20);
            this.lb_loi.TabIndex = 3;
            this.lb_loi.Text = "ERRORS";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(388, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(388, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_countdown
            // 
            this.lb_countdown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_countdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_countdown.ForeColor = System.Drawing.Color.Aqua;
            this.lb_countdown.Location = new System.Drawing.Point(386, 12);
            this.lb_countdown.Name = "lb_countdown";
            this.lb_countdown.Size = new System.Drawing.Size(90, 50);
            this.lb_countdown.TabIndex = 12;
            this.lb_countdown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic1
            // 
            this.pic1.Image = global::game.Properties.Resources.doctor_doing_a_eyes_test_17_3261058011;
            this.pic1.InitialImage = global::game.Properties.Resources.doctor_doing_a_eyes_test_17_326105801;
            this.pic1.Location = new System.Drawing.Point(509, 12);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(414, 414);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 14;
            this.pic1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_countdown);
            this.Controls.Add(this.lb_loi);
            this.Controls.Add(this.lb_diem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic1);
            this.Name = "Form1";
            this.Text = "TEST YOUR EYES";
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_diem;
        private System.Windows.Forms.Label lb_loi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_countdown;
        private System.Windows.Forms.PictureBox pic1;
    }
}

