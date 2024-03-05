using System.Windows.Forms;

namespace Herencias_y_polimorfismo
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
            groupBox1 = new GroupBox();
            btnSave = new Button();
            cboContract = new ComboBox();
            label3 = new Label();
            txtSurname = new TextBox();
            txtNames = new TextBox();
            label2 = new Label();
            cboType = new ComboBox();
            label1 = new Label();
            dgvSellers = new DataGridView();
            Type = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            Surname = new DataGridViewTextBoxColumn();
            Contract = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSellers).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(cboContract);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSurname);
            groupBox1.Controls.Add(txtNames);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cboType);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(45, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(585, 319);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(209, 223);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(165, 29);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cboContract
            // 
            cboContract.FormattingEnabled = true;
            cboContract.Items.AddRange(new object[] { "C", "N" });
            cboContract.Location = new Point(128, 150);
            cboContract.Name = "cboContract";
            cboContract.Size = new Size(175, 28);
            cboContract.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 150);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 5;
            label3.Text = "Contract";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(321, 95);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(175, 27);
            txtSurname.TabIndex = 4;
            // 
            // txtNames
            // 
            txtNames.Location = new Point(128, 95);
            txtNames.Name = "txtNames";
            txtNames.Size = new Size(175, 27);
            txtNames.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 95);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // cboType
            // 
            cboType.FormattingEnabled = true;
            cboType.Items.AddRange(new object[] { "seller", "employee", "manager" });
            cboType.Location = new Point(128, 46);
            cboType.Name = "cboType";
            cboType.Size = new Size(175, 28);
            cboType.TabIndex = 1;
            cboType.Text = "seller";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 46);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 0;
            label1.Text = "Type";
            // 
            // dgvSellers
            // 
            dgvSellers.AllowUserToAddRows = false;
            dgvSellers.AllowUserToOrderColumns = true;
            dgvSellers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSellers.Columns.AddRange(new DataGridViewColumn[] { Type, NameColumn, Surname, Contract });
            dgvSellers.Location = new Point(690, 53);
            dgvSellers.Name = "dgvSellers";
            dgvSellers.RowHeadersWidth = 51;
            dgvSellers.Size = new Size(554, 311);
            dgvSellers.TabIndex = 1;
            // 
            // Type
            // 
            Type.HeaderText = "Type";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.Width = 125;
            // 
            // Name
            // 
            NameColumn.HeaderText = "Name";
            NameColumn.MinimumWidth = 6;
            NameColumn.Name = "Name";
            NameColumn.Width = 125;
            // 
            // Surname
            // 
            Surname.HeaderText = "Surname";
            Surname.MinimumWidth = 6;
            Surname.Name = "Surname";
            Surname.Width = 125;
            // 
            // Contract
            // 
            Contract.HeaderText = "Contract";
            Contract.MinimumWidth = 6;
            Contract.Name = "Contract";
            Contract.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 431);
            Controls.Add(dgvSellers);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSellers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cboContract;
        private Label label3;
        private TextBox txtSurname;
        private TextBox txtNames;
        private Label label2;
        private ComboBox cboType;
        private Label label1;
        private Button btnSave;
        private DataGridView dgvSellers;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn Contract;
    }
}
