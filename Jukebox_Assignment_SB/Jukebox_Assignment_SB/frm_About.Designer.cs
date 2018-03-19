namespace jukebox_assignment_SB
{
    partial class frm_About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_About));
            this.txt_About = new System.Windows.Forms.TextBox();
            this.lbl_About_Title = new System.Windows.Forms.Label();
            this.btn_About_Exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_About = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_About)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_About
            // 
            this.txt_About.BackColor = System.Drawing.SystemColors.Control;
            this.txt_About.Location = new System.Drawing.Point(193, 69);
            this.txt_About.Multiline = true;
            this.txt_About.Name = "txt_About";
            this.txt_About.ReadOnly = true;
            this.txt_About.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_About.Size = new System.Drawing.Size(196, 148);
            this.txt_About.TabIndex = 2;
            this.txt_About.Text = resources.GetString("txt_About.Text");
            // 
            // lbl_About_Title
            // 
            this.lbl_About_Title.AutoSize = true;
            this.lbl_About_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_About_Title.Location = new System.Drawing.Point(216, 37);
            this.lbl_About_Title.Name = "lbl_About_Title";
            this.lbl_About_Title.Size = new System.Drawing.Size(147, 20);
            this.lbl_About_Title.TabIndex = 1;
            this.lbl_About_Title.Text = "My Juke Box v1.0";
            // 
            // btn_About_Exit
            // 
            this.btn_About_Exit.Location = new System.Drawing.Point(182, 304);
            this.btn_About_Exit.Name = "btn_About_Exit";
            this.btn_About_Exit.Size = new System.Drawing.Size(72, 26);
            this.btn_About_Exit.TabIndex = 1;
            this.btn_About_Exit.Text = "OK";
            this.btn_About_Exit.UseVisualStyleBackColor = true;
            this.btn_About_Exit.Click += new System.EventHandler(this.btn_About_Exit_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pic_About);
            this.panel1.Controls.Add(this.lbl_About_Title);
            this.panel1.Controls.Add(this.txt_About);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 286);
            this.panel1.TabIndex = 2;
            // 
            // pic_About
            // 
            this.pic_About.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_About.BackgroundImage")));
            this.pic_About.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_About.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_About.Location = new System.Drawing.Point(8, 8);
            this.pic_About.Margin = new System.Windows.Forms.Padding(8);
            this.pic_About.Name = "pic_About";
            this.pic_About.Size = new System.Drawing.Size(170, 266);
            this.pic_About.TabIndex = 3;
            this.pic_About.TabStop = false;
            // 
            // frm_About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 343);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_About_Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_About";
            this.Text = "About";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_About)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_About;
        private System.Windows.Forms.Label lbl_About_Title;
        private System.Windows.Forms.Button btn_About_Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_About;
    }
}