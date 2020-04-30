namespace DoodleJump
{
    partial class menuForm
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
            this.recordsBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("VCR OSD Mono [RUS by Daymarius]", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(265, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 83);
            this.button1.TabIndex = 0;
            this.button1.Text = "НАЧАТЬ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // recordsBtn
            // 
            this.recordsBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.recordsBtn.Font = new System.Drawing.Font("VCR OSD Mono [RUS by Daymarius]", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordsBtn.Location = new System.Drawing.Point(265, 196);
            this.recordsBtn.Name = "recordsBtn";
            this.recordsBtn.Size = new System.Drawing.Size(254, 83);
            this.recordsBtn.TabIndex = 1;
            this.recordsBtn.Text = "РЕКОРДЫ";
            this.recordsBtn.UseVisualStyleBackColor = false;
            this.recordsBtn.Click += new System.EventHandler(this.recordsBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.exitBtn.Font = new System.Drawing.Font("VCR OSD Mono [RUS by Daymarius]", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(265, 313);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(254, 83);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "ВЫЙТИ";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoodleJump.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(803, 483);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.recordsBtn);
            this.Controls.Add(this.button1);
            this.Name = "menuForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.menuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button recordsBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}