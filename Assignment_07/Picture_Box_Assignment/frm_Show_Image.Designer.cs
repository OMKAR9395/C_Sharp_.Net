
namespace Picture_Box_Assignment
{
    partial class frm_Show_Image
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
            this.btn_Search_Image = new System.Windows.Forms.Button();
            this.btn_Add_Image = new System.Windows.Forms.Button();
            this.lbl_Image_ = new System.Windows.Forms.Label();
            this.lbl_Image_List = new System.Windows.Forms.Label();
            this.lbl_Heeader = new System.Windows.Forms.Label();
            this.dgv_Image_List = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Image_List)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Image
            // 
            this.pb_Image.BackColor = System.Drawing.Color.White;
            this.pb_Image.Location = new System.Drawing.Point(60, 192);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(376, 286);
            this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Image.TabIndex = 27;
            this.pb_Image.TabStop = false;
            this.pb_Image.Click += new System.EventHandler(this.pb_Image_Click);
            // 
            // btn_Search_Image
            // 
            this.btn_Search_Image.BackColor = System.Drawing.Color.White;
            this.btn_Search_Image.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Image.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Search_Image.Location = new System.Drawing.Point(149, 500);
            this.btn_Search_Image.Name = "btn_Search_Image";
            this.btn_Search_Image.Size = new System.Drawing.Size(193, 51);
            this.btn_Search_Image.TabIndex = 22;
            this.btn_Search_Image.Text = "Search Images";
            this.btn_Search_Image.UseVisualStyleBackColor = false;
            this.btn_Search_Image.Click += new System.EventHandler(this.btn_Search_Image_Click);
            // 
            // btn_Add_Image
            // 
            this.btn_Add_Image.BackColor = System.Drawing.Color.White;
            this.btn_Add_Image.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Image.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Add_Image.Location = new System.Drawing.Point(728, 514);
            this.btn_Add_Image.Name = "btn_Add_Image";
            this.btn_Add_Image.Size = new System.Drawing.Size(180, 51);
            this.btn_Add_Image.TabIndex = 23;
            this.btn_Add_Image.Text = "Add Image";
            this.btn_Add_Image.UseVisualStyleBackColor = false;
            this.btn_Add_Image.Click += new System.EventHandler(this.btn_Add_Image_Click);
            // 
            // lbl_Image_
            // 
            this.lbl_Image_.AutoSize = true;
            this.lbl_Image_.BackColor = System.Drawing.Color.DarkCyan;
            this.lbl_Image_.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Image_.Location = new System.Drawing.Point(203, 145);
            this.lbl_Image_.Name = "lbl_Image_";
            this.lbl_Image_.Size = new System.Drawing.Size(96, 29);
            this.lbl_Image_.TabIndex = 16;
            this.lbl_Image_.Text = "Image ";
            // 
            // lbl_Image_List
            // 
            this.lbl_Image_List.AutoSize = true;
            this.lbl_Image_List.BackColor = System.Drawing.Color.DarkCyan;
            this.lbl_Image_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Image_List.Location = new System.Drawing.Point(756, 155);
            this.lbl_Image_List.Name = "lbl_Image_List";
            this.lbl_Image_List.Size = new System.Drawing.Size(140, 29);
            this.lbl_Image_List.TabIndex = 18;
            this.lbl_Image_List.Text = "Image List";
            // 
            // lbl_Heeader
            // 
            this.lbl_Heeader.AutoSize = true;
            this.lbl_Heeader.BackColor = System.Drawing.Color.LightBlue;
            this.lbl_Heeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Heeader.Location = new System.Drawing.Point(315, 29);
            this.lbl_Heeader.Name = "lbl_Heeader";
            this.lbl_Heeader.Size = new System.Drawing.Size(414, 76);
            this.lbl_Heeader.TabIndex = 19;
            this.lbl_Heeader.Text = "Show Image";
            // 
            // dgv_Image_List
            // 
            this.dgv_Image_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Image_List.Location = new System.Drawing.Point(627, 212);
            this.dgv_Image_List.Name = "dgv_Image_List";
            this.dgv_Image_List.RowHeadersWidth = 51;
            this.dgv_Image_List.RowTemplate.Height = 24;
            this.dgv_Image_List.Size = new System.Drawing.Size(387, 266);
            this.dgv_Image_List.TabIndex = 28;
            this.dgv_Image_List.SelectionChanged += new System.EventHandler(this.dgv_Image_List_SelectionChanged_1);
            // 
            // frm_Show_Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1082, 603);
            this.Controls.Add(this.dgv_Image_List);
            this.Controls.Add(this.pb_Image);
            this.Controls.Add(this.btn_Search_Image);
            this.Controls.Add(this.btn_Add_Image);
            this.Controls.Add(this.lbl_Image_);
            this.Controls.Add(this.lbl_Image_List);
            this.Controls.Add(this.lbl_Heeader);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Show_Image";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Show_Image";
            this.Load += new System.EventHandler(this.frm_Show_Image_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Image_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Image;
        private System.Windows.Forms.Button btn_Search_Image;
        private System.Windows.Forms.Button btn_Add_Image;
        private System.Windows.Forms.Label lbl_Image_;
        private System.Windows.Forms.Label lbl_Image_List;
        private System.Windows.Forms.Label lbl_Heeader;
        private System.Windows.Forms.DataGridView dgv_Image_List;
    }
}