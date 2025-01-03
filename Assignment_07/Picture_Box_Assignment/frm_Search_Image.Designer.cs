
namespace Picture_Box_Assignment
{
    partial class frm_Search_Image
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
            this.pb_Image = new System.Windows.Forms.PictureBox();
            this.tb_Image_Description = new System.Windows.Forms.TextBox();
            this.tb_Image_ID = new System.Windows.Forms.TextBox();
            this.btn_Add_Image = new System.Windows.Forms.Button();
            this.btn_Show_Image = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.lbl_Image = new System.Windows.Forms.Label();
            this.lbl_Image_Description = new System.Windows.Forms.Label();
            this.lbl_Image_ID = new System.Windows.Forms.Label();
            this.lbl_Heeader = new System.Windows.Forms.Label();
            this.btn_Show = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Image
            // 
            this.pb_Image.BackColor = System.Drawing.Color.White;
            this.pb_Image.Location = new System.Drawing.Point(721, 190);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(324, 251);
            this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Image.TabIndex = 15;
            this.pb_Image.TabStop = false;
            // 
            // tb_Image_Description
            // 
            this.tb_Image_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Image_Description.Location = new System.Drawing.Point(269, 229);
            this.tb_Image_Description.Multiline = true;
            this.tb_Image_Description.Name = "tb_Image_Description";
            this.tb_Image_Description.Size = new System.Drawing.Size(291, 212);
            this.tb_Image_Description.TabIndex = 13;
            // 
            // tb_Image_ID
            // 
            this.tb_Image_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Image_ID.Location = new System.Drawing.Point(269, 166);
            this.tb_Image_ID.Name = "tb_Image_ID";
            this.tb_Image_ID.Size = new System.Drawing.Size(291, 36);
            this.tb_Image_ID.TabIndex = 14;
            this.tb_Image_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // btn_Add_Image
            // 
            this.btn_Add_Image.BackColor = System.Drawing.Color.White;
            this.btn_Add_Image.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Image.ForeColor = System.Drawing.Color.Red;
            this.btn_Add_Image.Location = new System.Drawing.Point(435, 521);
            this.btn_Add_Image.Name = "btn_Add_Image";
            this.btn_Add_Image.Size = new System.Drawing.Size(221, 51);
            this.btn_Add_Image.TabIndex = 9;
            this.btn_Add_Image.Text = "Add Image";
            this.btn_Add_Image.UseVisualStyleBackColor = false;
            this.btn_Add_Image.Click += new System.EventHandler(this.btn_Add_Image_Click);
            // 
            // btn_Show_Image
            // 
            this.btn_Show_Image.BackColor = System.Drawing.Color.White;
            this.btn_Show_Image.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show_Image.ForeColor = System.Drawing.Color.Red;
            this.btn_Show_Image.Location = new System.Drawing.Point(785, 521);
            this.btn_Show_Image.Name = "btn_Show_Image";
            this.btn_Show_Image.Size = new System.Drawing.Size(213, 51);
            this.btn_Show_Image.TabIndex = 11;
            this.btn_Show_Image.Text = "Show Image";
            this.btn_Show_Image.UseVisualStyleBackColor = false;
            this.btn_Show_Image.Click += new System.EventHandler(this.btn_Show_Image_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.White;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.Red;
            this.btn_Reset.Location = new System.Drawing.Point(80, 521);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(213, 51);
            this.btn_Reset.TabIndex = 12;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // lbl_Image
            // 
            this.lbl_Image.AutoSize = true;
            this.lbl_Image.BackColor = System.Drawing.Color.DarkCyan;
            this.lbl_Image.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Image.Location = new System.Drawing.Point(839, 143);
            this.lbl_Image.Name = "lbl_Image";
            this.lbl_Image.Size = new System.Drawing.Size(96, 29);
            this.lbl_Image.TabIndex = 4;
            this.lbl_Image.Text = "Image ";
            // 
            // lbl_Image_Description
            // 
            this.lbl_Image_Description.AutoSize = true;
            this.lbl_Image_Description.BackColor = System.Drawing.Color.DarkCyan;
            this.lbl_Image_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Image_Description.Location = new System.Drawing.Point(26, 335);
            this.lbl_Image_Description.Name = "lbl_Image_Description";
            this.lbl_Image_Description.Size = new System.Drawing.Size(234, 29);
            this.lbl_Image_Description.TabIndex = 5;
            this.lbl_Image_Description.Text = "Image Description";
            // 
            // lbl_Image_ID
            // 
            this.lbl_Image_ID.AutoSize = true;
            this.lbl_Image_ID.BackColor = System.Drawing.Color.DarkCyan;
            this.lbl_Image_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Image_ID.Location = new System.Drawing.Point(47, 169);
            this.lbl_Image_ID.Name = "lbl_Image_ID";
            this.lbl_Image_ID.Size = new System.Drawing.Size(122, 29);
            this.lbl_Image_ID.TabIndex = 6;
            this.lbl_Image_ID.Text = "Image ID";
            // 
            // lbl_Heeader
            // 
            this.lbl_Heeader.AutoSize = true;
            this.lbl_Heeader.BackColor = System.Drawing.Color.LightBlue;
            this.lbl_Heeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Heeader.Location = new System.Drawing.Point(283, 30);
            this.lbl_Heeader.Name = "lbl_Heeader";
            this.lbl_Heeader.Size = new System.Drawing.Size(461, 76);
            this.lbl_Heeader.TabIndex = 7;
            this.lbl_Heeader.Text = "Search Image";
            // 
            // btn_Show
            // 
            this.btn_Show.BackColor = System.Drawing.Color.White;
            this.btn_Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show.Location = new System.Drawing.Point(595, 169);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(110, 36);
            this.btn_Show.TabIndex = 8;
            this.btn_Show.Text = "Search";
            this.btn_Show.UseVisualStyleBackColor = false;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // frm_Search_Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1082, 603);
            this.Controls.Add(this.pb_Image);
            this.Controls.Add(this.tb_Image_Description);
            this.Controls.Add(this.tb_Image_ID);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.btn_Add_Image);
            this.Controls.Add(this.btn_Show_Image);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.lbl_Image);
            this.Controls.Add(this.lbl_Image_Description);
            this.Controls.Add(this.lbl_Image_ID);
            this.Controls.Add(this.lbl_Heeader);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Search_Image";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Search_Image";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Image;
        private System.Windows.Forms.TextBox tb_Image_Description;
        private System.Windows.Forms.TextBox tb_Image_ID;
        private System.Windows.Forms.Button btn_Add_Image;
        private System.Windows.Forms.Button btn_Show_Image;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label lbl_Image;
        private System.Windows.Forms.Label lbl_Image_Description;
        private System.Windows.Forms.Label lbl_Image_ID;
        private System.Windows.Forms.Label lbl_Heeader;
        private System.Windows.Forms.Button btn_Show;
    }
}