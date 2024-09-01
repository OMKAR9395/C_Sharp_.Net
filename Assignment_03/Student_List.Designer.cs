﻿
namespace Assignment
{
    partial class frm_Student_List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_student_list = new System.Windows.Forms.Label();
            this.btn_add_new_srudent = new System.Windows.Forms.Button();
            this.btn_log_out = new System.Windows.Forms.Button();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.dgv_Show_Data = new System.Windows.Forms.DataGridView();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignment_1System_DBDataSet3 = new Assignment.Assignment_1System_DBDataSet3();
            this.student_DetailsTableAdapter = new Assignment.Assignment_1System_DBDataSet3TableAdapters.Student_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Show_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment_1System_DBDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_student_list
            // 
            this.lbl_student_list.AutoSize = true;
            this.lbl_student_list.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_student_list.Font = new System.Drawing.Font("Modern No. 20", 45F);
            this.lbl_student_list.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_student_list.Location = new System.Drawing.Point(357, -1);
            this.lbl_student_list.Name = "lbl_student_list";
            this.lbl_student_list.Size = new System.Drawing.Size(409, 78);
            this.lbl_student_list.TabIndex = 0;
            this.lbl_student_list.Text = "Student List";
            // 
            // btn_add_new_srudent
            // 
            this.btn_add_new_srudent.BackColor = System.Drawing.Color.White;
            this.btn_add_new_srudent.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_new_srudent.ForeColor = System.Drawing.Color.Black;
            this.btn_add_new_srudent.Location = new System.Drawing.Point(326, 578);
            this.btn_add_new_srudent.Name = "btn_add_new_srudent";
            this.btn_add_new_srudent.Size = new System.Drawing.Size(421, 63);
            this.btn_add_new_srudent.TabIndex = 1;
            this.btn_add_new_srudent.Text = "Add New Student";
            this.btn_add_new_srudent.UseVisualStyleBackColor = false;
            this.btn_add_new_srudent.Click += new System.EventHandler(this.btn_add_new_srudent_Click);
            // 
            // btn_log_out
            // 
            this.btn_log_out.BackColor = System.Drawing.Color.White;
            this.btn_log_out.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log_out.ForeColor = System.Drawing.Color.Red;
            this.btn_log_out.Location = new System.Drawing.Point(892, 12);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(178, 45);
            this.btn_log_out.TabIndex = 2;
            this.btn_log_out.Text = "Log Out";
            this.btn_log_out.UseVisualStyleBackColor = false;
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click);
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.BackColor = System.Drawing.Color.Honeydew;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_Username.Location = new System.Drawing.Point(6, 9);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(142, 33);
            this.lbl_Username.TabIndex = 33;
            this.lbl_Username.Text = "Username";
            // 
            // dgv_Show_Data
            // 
            this.dgv_Show_Data.AllowUserToAddRows = false;
            this.dgv_Show_Data.AllowUserToDeleteRows = false;
            this.dgv_Show_Data.AutoGenerateColumns = false;
            this.dgv_Show_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Show_Data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Show_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Show_Data.ColumnHeadersHeight = 35;
            this.dgv_Show_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dgv_Show_Data.DataSource = this.studentDetailsBindingSource;
            this.dgv_Show_Data.Location = new System.Drawing.Point(12, 80);
            this.dgv_Show_Data.Name = "dgv_Show_Data";
            this.dgv_Show_Data.ReadOnly = true;
            this.dgv_Show_Data.RowHeadersWidth = 51;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Show_Data.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Show_Data.RowTemplate.Height = 24;
            this.dgv_Show_Data.Size = new System.Drawing.Size(1069, 492);
            this.dgv_Show_Data.TabIndex = 3;
            // 
            // rollNoDataGridViewTextBoxColumn
            // 
            this.rollNoDataGridViewTextBoxColumn.DataPropertyName = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.HeaderText = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
            this.rollNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            this.mobileNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "Dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "Dob";
            this.dobDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            this.dobDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentDetailsBindingSource
            // 
            this.studentDetailsBindingSource.DataMember = "Student_Details";
            this.studentDetailsBindingSource.DataSource = this.assignment_1System_DBDataSet3;
            // 
            // assignment_1System_DBDataSet3
            // 
            this.assignment_1System_DBDataSet3.DataSetName = "Assignment_1System_DBDataSet3";
            this.assignment_1System_DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_DetailsTableAdapter
            // 
            this.student_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.dgv_Show_Data);
            this.Controls.Add(this.btn_log_out);
            this.Controls.Add(this.btn_add_new_srudent);
            this.Controls.Add(this.lbl_student_list);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Student_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student List";
            this.Load += new System.EventHandler(this.frm_Student_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Show_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment_1System_DBDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_student_list;
        private System.Windows.Forms.Button btn_add_new_srudent;
        private System.Windows.Forms.Button btn_log_out;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.DataGridView dgv_Show_Data;
        private Assignment_1System_DBDataSet3 assignment_1System_DBDataSet3;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource;
        private Assignment_1System_DBDataSet3TableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
    }
}