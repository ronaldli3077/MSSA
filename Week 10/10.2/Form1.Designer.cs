namespace Mod7CodeFirstdemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            empGrid = new DataGridView();
            textId = new TextBox();
            textName = new TextBox();
            textSalary = new TextBox();
            comboDept = new ComboBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            sqlCommand2 = new Microsoft.Data.SqlClient.SqlCommand();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnSelect = new Button();
            btnSubmit = new Button();
            btnRefresh = new Button();
            btnDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)empGrid).BeginInit();
            SuspendLayout();
            // 
            // empGrid
            // 
            empGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            empGrid.Location = new Point(326, 76);
            empGrid.Name = "empGrid";
            empGrid.RowHeadersWidth = 82;
            empGrid.Size = new Size(1432, 312);
            empGrid.TabIndex = 0;
            // 
            // textId
            // 
            textId.BackColor = Color.PeachPuff;
            textId.Location = new Point(521, 590);
            textId.Name = "textId";
            textId.Size = new Size(200, 39);
            textId.TabIndex = 1;
            // 
            // textName
            // 
            textName.BackColor = Color.MistyRose;
            textName.Location = new Point(521, 656);
            textName.Name = "textName";
            textName.Size = new Size(200, 39);
            textName.TabIndex = 2;
            // 
            // textSalary
            // 
            textSalary.BackColor = Color.LightSalmon;
            textSalary.Location = new Point(521, 723);
            textSalary.Name = "textSalary";
            textSalary.Size = new Size(200, 39);
            textSalary.TabIndex = 3;
            // 
            // comboDept
            // 
            comboDept.BackColor = Color.PeachPuff;
            comboDept.FormattingEnabled = true;
            comboDept.Location = new Point(521, 797);
            comboDept.Name = "comboDept";
            comboDept.Size = new Size(242, 40);
            comboDept.TabIndex = 5;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // sqlCommand2
            // 
            sqlCommand2.CommandTimeout = 30;
            sqlCommand2.EnableOptimizedParameterBinding = false;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1201, 583);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1419, 785);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 46);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(1419, 583);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(273, 46);
            btnSelect.TabIndex = 8;
            btnSelect.Text = "Select to Update";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(1201, 786);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(150, 46);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(1726, 583);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(150, 46);
            btnRefresh.TabIndex = 11;
            btnRefresh.Text = "Refersh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1662, 785);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(248, 582);
            label1.Name = "label1";
            label1.Size = new Size(37, 32);
            label1.TabIndex = 13;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(248, 656);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 14;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(248, 730);
            label3.Name = "label3";
            label3.Size = new Size(77, 32);
            label3.TabIndex = 15;
            label3.Text = "Salary";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(248, 800);
            label4.Name = "label4";
            label4.Size = new Size(142, 32);
            label4.TabIndex = 16;
            label4.Text = "Department";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(2076, 1188);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnRefresh);
            Controls.Add(btnSubmit);
            Controls.Add(btnSelect);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(comboDept);
            Controls.Add(textSalary);
            Controls.Add(textName);
            Controls.Add(textId);
            Controls.Add(empGrid);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)empGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView empGrid;
        private TextBox textId;
        private TextBox textName;
        private TextBox textSalary;
        private ComboBox comboDept;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand2;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnSelect;
        private Button btnSubmit;
        private Button btnRefresh;
        private Button btnDelete;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
