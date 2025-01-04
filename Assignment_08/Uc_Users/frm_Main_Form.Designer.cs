
namespace Uc_Users
{
    partial class frm_Main_Form
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
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_Container = new System.Windows.Forms.Panel();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.lbl_User_Name = new System.Windows.Forms.Label();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_User_Management = new System.Windows.Forms.Button();
            this.btn_Staff = new System.Windows.Forms.Button();
            this.btn_Product = new System.Windows.Forms.Button();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_User_Management = new System.Windows.Forms.Label();
            this.pnl_Header.SuspendLayout();
            this.pnl_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.Coral;
            this.pnl_Header.Controls.Add(this.lbl_User_Management);
            this.pnl_Header.Controls.Add(this.panel2);
            this.pnl_Header.Location = new System.Drawing.Point(252, 2);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1171, 151);
            this.pnl_Header.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1164, 394);
            this.panel2.TabIndex = 1;
            // 
            // pnl_Container
            // 
            this.pnl_Container.BackColor = System.Drawing.Color.DarkGray;
            this.pnl_Container.Location = new System.Drawing.Point(252, 150);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Size = new System.Drawing.Size(1182, 620);
            this.pnl_Container.TabIndex = 1;
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.Cornsilk;
            this.pnl_Menu.Controls.Add(this.lbl_User_Name);
            this.pnl_Menu.Controls.Add(this.btn_LogOut);
            this.pnl_Menu.Controls.Add(this.button1);
            this.pnl_Menu.Controls.Add(this.btn_User_Management);
            this.pnl_Menu.Controls.Add(this.btn_Staff);
            this.pnl_Menu.Controls.Add(this.btn_Product);
            this.pnl_Menu.Controls.Add(this.btn_Customer);
            this.pnl_Menu.Location = new System.Drawing.Point(-1, 156);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(257, 614);
            this.pnl_Menu.TabIndex = 0;
            // 
            // lbl_User_Name
            // 
            this.lbl_User_Name.AutoSize = true;
            this.lbl_User_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Name.Location = new System.Drawing.Point(34, 415);
            this.lbl_User_Name.Name = "lbl_User_Name";
            this.lbl_User_Name.Size = new System.Drawing.Size(189, 39);
            this.lbl_User_Name.TabIndex = 0;
            this.lbl_User_Name.Text = "User Name";
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackColor = System.Drawing.Color.Crimson;
            this.btn_LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.ForeColor = System.Drawing.Color.FloralWhite;
            this.btn_LogOut.Location = new System.Drawing.Point(13, 489);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(234, 67);
            this.btn_LogOut.TabIndex = 0;
            this.btn_LogOut.Text = "LogOut";
            this.btn_LogOut.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_User_Management
            // 
            this.btn_User_Management.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_User_Management.Location = new System.Drawing.Point(13, 310);
            this.btn_User_Management.Name = "btn_User_Management";
            this.btn_User_Management.Size = new System.Drawing.Size(234, 67);
            this.btn_User_Management.TabIndex = 0;
            this.btn_User_Management.Text = "User Management";
            this.btn_User_Management.UseVisualStyleBackColor = true;
            this.btn_User_Management.Click += new System.EventHandler(this.btn_User_Management_Click);
            // 
            // btn_Staff
            // 
            this.btn_Staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Staff.Location = new System.Drawing.Point(13, 207);
            this.btn_Staff.Name = "btn_Staff";
            this.btn_Staff.Size = new System.Drawing.Size(234, 67);
            this.btn_Staff.TabIndex = 0;
            this.btn_Staff.Text = "Staff";
            this.btn_Staff.UseVisualStyleBackColor = true;
            // 
            // btn_Product
            // 
            this.btn_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Product.Location = new System.Drawing.Point(13, 109);
            this.btn_Product.Name = "btn_Product";
            this.btn_Product.Size = new System.Drawing.Size(234, 67);
            this.btn_Product.TabIndex = 0;
            this.btn_Product.Text = "Product";
            this.btn_Product.UseVisualStyleBackColor = true;
            // 
            // btn_Customer
            // 
            this.btn_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer.Location = new System.Drawing.Point(13, 17);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(234, 67);
            this.btn_Customer.TabIndex = 0;
            this.btn_Customer.Text = "Customer";
            this.btn_Customer.UseVisualStyleBackColor = true;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Uc_Users.Properties.Resources._89c61ccb20adf71e111b3a843afebc7f;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_User_Management
            // 
            this.lbl_User_Management.AutoSize = true;
            this.lbl_User_Management.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Management.Location = new System.Drawing.Point(220, 22);
            this.lbl_User_Management.Name = "lbl_User_Management";
            this.lbl_User_Management.Size = new System.Drawing.Size(732, 95);
            this.lbl_User_Management.TabIndex = 2;
            this.lbl_User_Management.Text = "User Management";
            // 
            // frm_Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 763);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnl_Menu);
            this.Controls.Add(this.pnl_Container);
            this.Controls.Add(this.pnl_Header);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Main_Form";
            this.Text = "frm_Main_Form";
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_Container;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.Label lbl_User_Name;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button btn_User_Management;
        private System.Windows.Forms.Button btn_Staff;
        private System.Windows.Forms.Button btn_Product;
        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_User_Management;
    }
}