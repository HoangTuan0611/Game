namespace game
{
    partial class Form2
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
        public void InitializeComponent()
        {
            this.btn_play = new System.Windows.Forms.Button();
            this.lb_animal = new System.Windows.Forms.Label();
            this.lb_info = new System.Windows.Forms.Label();
            this.lb_point = new System.Windows.Forms.Label();
            this.lb_errors = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.SystemColors.Info;
            this.btn_play.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_play.Location = new System.Drawing.Point(215, 311);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(372, 77);
            this.btn_play.TabIndex = 0;
            this.btn_play.Text = "PLAY AGAIN";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // lb_animal
            // 
            this.lb_animal.AutoSize = true;
            this.lb_animal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_animal.Location = new System.Drawing.Point(309, 30);
            this.lb_animal.Name = "lb_animal";
            this.lb_animal.Size = new System.Drawing.Size(151, 39);
            this.lb_animal.TabIndex = 1;
            this.lb_animal.Text = "ANIMAL";
            this.lb_animal.Click += new System.EventHandler(this.lb_animal_Click);
            // 
            // lb_info
            // 
            this.lb_info.AutoSize = true;
            this.lb_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_info.Location = new System.Drawing.Point(201, 102);
            this.lb_info.Name = "lb_info";
            this.lb_info.Size = new System.Drawing.Size(106, 29);
            this.lb_info.TabIndex = 2;
            this.lb_info.Text = "ANIMAL";
            this.lb_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_info.Click += new System.EventHandler(this.lb_info_Click);
            // 
            // lb_point
            // 
            this.lb_point.AutoSize = true;
            this.lb_point.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_point.Location = new System.Drawing.Point(203, 239);
            this.lb_point.Name = "lb_point";
            this.lb_point.Size = new System.Drawing.Size(81, 29);
            this.lb_point.TabIndex = 3;
            this.lb_point.Text = "label2";
            this.lb_point.Click += new System.EventHandler(this.lb_point_Click);
            // 
            // lb_errors
            // 
            this.lb_errors.AutoSize = true;
            this.lb_errors.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_errors.Location = new System.Drawing.Point(506, 239);
            this.lb_errors.Name = "lb_errors";
            this.lb_errors.Size = new System.Drawing.Size(81, 29);
            this.lb_errors.TabIndex = 4;
            this.lb_errors.Text = "label3";
            this.lb_errors.Click += new System.EventHandler(this.lb_errors_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.lb_errors);
            this.Controls.Add(this.lb_point);
            this.Controls.Add(this.lb_info);
            this.Controls.Add(this.lb_animal);
            this.Controls.Add(this.btn_play);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Label lb_animal;
        private System.Windows.Forms.Label lb_info;
        private System.Windows.Forms.Label lb_point;
        private System.Windows.Forms.Label lb_errors;
    }
}