
namespace Assignment
{
    partial class frm_Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStudentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.courseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCourseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.viewCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.courseToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.updateStudentToolStripMenuItem,
            this.viewStudentListToolStripMenuItem,
            this.updateStudentToolStripMenuItem1});
            this.studentToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(110, 30);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(297, 30);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // updateStudentToolStripMenuItem
            // 
            this.updateStudentToolStripMenuItem.Name = "updateStudentToolStripMenuItem";
            this.updateStudentToolStripMenuItem.Size = new System.Drawing.Size(297, 30);
            this.updateStudentToolStripMenuItem.Text = "Search Student";
            this.updateStudentToolStripMenuItem.Click += new System.EventHandler(this.updateStudentToolStripMenuItem_Click);
            // 
            // viewStudentListToolStripMenuItem
            // 
            this.viewStudentListToolStripMenuItem.Name = "viewStudentListToolStripMenuItem";
            this.viewStudentListToolStripMenuItem.Size = new System.Drawing.Size(297, 30);
            this.viewStudentListToolStripMenuItem.Text = "View Student List";
            this.viewStudentListToolStripMenuItem.Click += new System.EventHandler(this.viewStudentListToolStripMenuItem_Click);
            // 
            // updateStudentToolStripMenuItem1
            // 
            this.updateStudentToolStripMenuItem1.Name = "updateStudentToolStripMenuItem1";
            this.updateStudentToolStripMenuItem1.Size = new System.Drawing.Size(297, 30);
            this.updateStudentToolStripMenuItem1.Text = "Update Student";
            this.updateStudentToolStripMenuItem1.Click += new System.EventHandler(this.updateStudentToolStripMenuItem1_Click_1);
            // 
            // courseToolStripMenuItem
            // 
            this.courseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCourseDetailsToolStripMenuItem,
            this.updateCourseDetailsToolStripMenuItem,
            this.viewCourseToolStripMenuItem});
            this.courseToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            this.courseToolStripMenuItem.Size = new System.Drawing.Size(99, 30);
            this.courseToolStripMenuItem.Text = "Course";
            // 
            // addCourseDetailsToolStripMenuItem
            // 
            this.addCourseDetailsToolStripMenuItem.Name = "addCourseDetailsToolStripMenuItem";
            this.addCourseDetailsToolStripMenuItem.Size = new System.Drawing.Size(256, 30);
            this.addCourseDetailsToolStripMenuItem.Text = "Add Course";
            this.addCourseDetailsToolStripMenuItem.Click += new System.EventHandler(this.addCourseDetailsToolStripMenuItem_Click);
            // 
            // updateCourseDetailsToolStripMenuItem
            // 
            this.updateCourseDetailsToolStripMenuItem.Name = "updateCourseDetailsToolStripMenuItem";
            this.updateCourseDetailsToolStripMenuItem.Size = new System.Drawing.Size(256, 30);
            this.updateCourseDetailsToolStripMenuItem.Text = "Update Course";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(85, 30);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Log_Out.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Red;
            this.btn_Log_Out.Location = new System.Drawing.Point(940, -1);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(130, 35);
            this.btn_Log_Out.TabIndex = 2;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_Username.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbl_Username.Location = new System.Drawing.Point(739, 3);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(121, 26);
            this.lbl_Username.TabIndex = 4;
            this.lbl_Username.Text = "Username";
            // 
            // viewCourseToolStripMenuItem
            // 
            this.viewCourseToolStripMenuItem.Name = "viewCourseToolStripMenuItem";
            this.viewCourseToolStripMenuItem.Size = new System.Drawing.Size(256, 30);
            this.viewCourseToolStripMenuItem.Text = "View Course";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 703);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student App";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentListToolStripMenuItem;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.ToolStripMenuItem courseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStudentToolStripMenuItem1;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.ToolStripMenuItem addCourseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCourseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCourseToolStripMenuItem;
    }
}