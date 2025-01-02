
namespace Assignment
{
    partial class frm_Add_Student_Detail
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
            this.btn_refresh = new System.Windows.Forms.Button();
            this.cb_Course = new System.Windows.Forms.ComboBox();
            this.dtp_Dob = new System.Windows.Forms.DateTimePicker();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Roll_No = new System.Windows.Forms.TextBox();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.lbl_Dob = new System.Windows.Forms.Label();
            this.lbl_Mob_No = new System.Windows.Forms.Label();
            this.lbl_roll_no = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Add_Student_Detail = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.White;
            this.btn_refresh.Font = new System.Drawing.Font("Baskerville Old Face", 20F, System.Drawing.FontStyle.Bold);
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_refresh.Location = new System.Drawing.Point(308, 584);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(169, 57);
            this.btn_refresh.TabIndex = 27;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // cb_Course
            // 
            this.cb_Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Course.FormattingEnabled = true;
            this.cb_Course.Items.AddRange(new object[] {
            "BSC.CS",
            "MSC.CS",
            "BCS",
            "MCS",
            "BCA",
            "MCA"});
            this.cb_Course.Location = new System.Drawing.Point(655, 480);
            this.cb_Course.Name = "cb_Course";
            this.cb_Course.Size = new System.Drawing.Size(316, 37);
            this.cb_Course.TabIndex = 25;
            // 
            // dtp_Dob
            // 
            this.dtp_Dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Dob.Location = new System.Drawing.Point(655, 397);
            this.dtp_Dob.MaxDate = new System.DateTime(2024, 8, 6, 0, 0, 0, 0);
            this.dtp_Dob.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dtp_Dob.Name = "dtp_Dob";
            this.dtp_Dob.Size = new System.Drawing.Size(316, 36);
            this.dtp_Dob.TabIndex = 24;
            this.dtp_Dob.Value = new System.DateTime(2024, 8, 6, 0, 0, 0, 0);
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(652, 325);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(319, 36);
            this.tb_Mobile_No.TabIndex = 23;
            this.tb_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(655, 245);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(316, 36);
            this.tb_Name.TabIndex = 22;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // tb_Roll_No
            // 
            this.tb_Roll_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Roll_No.Location = new System.Drawing.Point(655, 159);
            this.tb_Roll_No.MaxLength = 5;
            this.tb_Roll_No.Name = "tb_Roll_No";
            this.tb_Roll_No.Size = new System.Drawing.Size(316, 36);
            this.tb_Roll_No.TabIndex = 21;
            this.tb_Roll_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.BackColor = System.Drawing.Color.Azure;
            this.lbl_Course.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbl_Course.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.lbl_Course.Location = new System.Drawing.Point(120, 480);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(109, 34);
            this.lbl_Course.TabIndex = 20;
            this.lbl_Course.Text = "Course";
            // 
            // lbl_Dob
            // 
            this.lbl_Dob.AutoSize = true;
            this.lbl_Dob.BackColor = System.Drawing.Color.Azure;
            this.lbl_Dob.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbl_Dob.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.lbl_Dob.Location = new System.Drawing.Point(120, 401);
            this.lbl_Dob.Name = "lbl_Dob";
            this.lbl_Dob.Size = new System.Drawing.Size(73, 34);
            this.lbl_Dob.TabIndex = 19;
            this.lbl_Dob.Text = "Dob";
            // 
            // lbl_Mob_No
            // 
            this.lbl_Mob_No.AutoSize = true;
            this.lbl_Mob_No.BackColor = System.Drawing.Color.Azure;
            this.lbl_Mob_No.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbl_Mob_No.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.lbl_Mob_No.Location = new System.Drawing.Point(120, 325);
            this.lbl_Mob_No.Name = "lbl_Mob_No";
            this.lbl_Mob_No.Size = new System.Drawing.Size(172, 34);
            this.lbl_Mob_No.TabIndex = 18;
            this.lbl_Mob_No.Text = "Mobile No.";
            // 
            // lbl_roll_no
            // 
            this.lbl_roll_no.AutoSize = true;
            this.lbl_roll_no.BackColor = System.Drawing.Color.Azure;
            this.lbl_roll_no.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbl_roll_no.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.lbl_roll_no.Location = new System.Drawing.Point(120, 159);
            this.lbl_roll_no.Name = "lbl_roll_no";
            this.lbl_roll_no.Size = new System.Drawing.Size(135, 34);
            this.lbl_roll_no.TabIndex = 17;
            this.lbl_roll_no.Text = "Roll No.";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.Azure;
            this.lbl_Name.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbl_Name.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.lbl_Name.Location = new System.Drawing.Point(120, 245);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(95, 34);
            this.lbl_Name.TabIndex = 16;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Add_Student_Detail
            // 
            this.lbl_Add_Student_Detail.AutoSize = true;
            this.lbl_Add_Student_Detail.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Add_Student_Detail.Font = new System.Drawing.Font("Modern No. 20", 35F);
            this.lbl_Add_Student_Detail.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_Add_Student_Detail.Location = new System.Drawing.Point(176, 9);
            this.lbl_Add_Student_Detail.Name = "lbl_Add_Student_Detail";
            this.lbl_Add_Student_Detail.Size = new System.Drawing.Size(708, 60);
            this.lbl_Add_Student_Detail.TabIndex = 15;
            this.lbl_Add_Student_Detail.Text = "ADD STUDENT DETAILS";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.White;
            this.btn_Save.Font = new System.Drawing.Font("Baskerville Old Face", 20F, System.Drawing.FontStyle.Bold);
            this.btn_Save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Save.Location = new System.Drawing.Point(603, 584);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(154, 57);
            this.btn_Save.TabIndex = 30;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frm_Add_Student_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.cb_Course);
            this.Controls.Add(this.dtp_Dob);
            this.Controls.Add(this.tb_Mobile_No);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Roll_No);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_Dob);
            this.Controls.Add(this.lbl_Mob_No);
            this.Controls.Add(this.lbl_roll_no);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Add_Student_Detail);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_Student_Detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Add_Student_Detail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.ComboBox cb_Course;
        private System.Windows.Forms.DateTimePicker dtp_Dob;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Roll_No;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.Label lbl_Dob;
        private System.Windows.Forms.Label lbl_Mob_No;
        private System.Windows.Forms.Label lbl_roll_no;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Add_Student_Detail;
        private System.Windows.Forms.Button btn_Save;
    }
}