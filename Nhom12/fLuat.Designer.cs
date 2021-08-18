
namespace Nhom12
{
    partial class fLuat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLaptop = new System.Windows.Forms.DataGridView();
            this.dID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dveTrai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvePhai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbVT = new System.Windows.Forms.ComboBox();
            this.cmbVP = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbVT = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReMove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaptop)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLaptop
            // 
            this.dgvLaptop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLaptop.BackgroundColor = System.Drawing.Color.White;
            this.dgvLaptop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLaptop.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvLaptop.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLaptop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvLaptop.ColumnHeadersHeight = 50;
            this.dgvLaptop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dID,
            this.dveTrai,
            this.dvePhai});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLaptop.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvLaptop.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvLaptop.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvLaptop.Location = new System.Drawing.Point(50, 18);
            this.dgvLaptop.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLaptop.Name = "dgvLaptop";
            this.dgvLaptop.ReadOnly = true;
            this.dgvLaptop.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLaptop.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvLaptop.RowHeadersVisible = false;
            this.dgvLaptop.RowHeadersWidth = 45;
            this.dgvLaptop.RowTemplate.Height = 40;
            this.dgvLaptop.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLaptop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLaptop.Size = new System.Drawing.Size(974, 440);
            this.dgvLaptop.TabIndex = 0;
            this.dgvLaptop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLaptop_CellClick);
            // 
            // dID
            // 
            this.dID.DataPropertyName = "ID";
            this.dID.HeaderText = "ID";
            this.dID.MinimumWidth = 6;
            this.dID.Name = "dID";
            this.dID.ReadOnly = true;
            this.dID.Width = 125;
            // 
            // dveTrai
            // 
            this.dveTrai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dveTrai.DataPropertyName = "VeTrai";
            this.dveTrai.HeaderText = "Vế trái";
            this.dveTrai.MinimumWidth = 6;
            this.dveTrai.Name = "dveTrai";
            this.dveTrai.ReadOnly = true;
            // 
            // dvePhai
            // 
            this.dvePhai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dvePhai.DataPropertyName = "VePhai";
            this.dvePhai.HeaderText = "Vế phải";
            this.dvePhai.MinimumWidth = 6;
            this.dvePhai.Name = "dvePhai";
            this.dvePhai.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnAdd.Location = new System.Drawing.Point(921, 21);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 39);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(-62, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtID.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(153, 14);
            this.txtID.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(220, 29);
            this.txtID.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvLaptop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 186);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 462);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.cmbVT);
            this.panel2.Controls.Add(this.cmbVP);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnReMove);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbVT);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1073, 186);
            this.panel2.TabIndex = 5;
            // 
            // cmbVT
            // 
            this.cmbVT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbVT.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVT.FormattingEnabled = true;
            this.cmbVT.Location = new System.Drawing.Point(606, 27);
            this.cmbVT.Name = "cmbVT";
            this.cmbVT.Size = new System.Drawing.Size(272, 29);
            this.cmbVT.TabIndex = 4;
            // 
            // cmbVP
            // 
            this.cmbVP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbVP.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVP.FormattingEnabled = true;
            this.cmbVP.Location = new System.Drawing.Point(153, 63);
            this.cmbVP.Name = "cmbVP";
            this.cmbVP.Size = new System.Drawing.Size(327, 29);
            this.cmbVP.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnCancel.Location = new System.Drawing.Point(756, 118);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 52);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnThem.Location = new System.Drawing.Point(491, 118);
            this.btnThem.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 52);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnSua.Location = new System.Drawing.Point(221, 118);
            this.btnSua.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(106, 52);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(89, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID";
            // 
            // lbVT
            // 
            this.lbVT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbVT.AutoSize = true;
            this.lbVT.BackColor = System.Drawing.Color.Transparent;
            this.lbVT.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbVT.Location = new System.Drawing.Point(602, 77);
            this.lbVT.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbVT.Name = "lbVT";
            this.lbVT.Size = new System.Drawing.Size(0, 23);
            this.lbVT.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(46, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Vế phải";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(529, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vế trái";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1073, 648);
            this.panel3.TabIndex = 7;
            // 
            // btnReMove
            // 
            this.btnReMove.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.btnReMove.FlatAppearance.BorderSize = 0;
            this.btnReMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReMove.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReMove.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnReMove.Location = new System.Drawing.Point(921, 66);
            this.btnReMove.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnReMove.Name = "btnReMove";
            this.btnReMove.Size = new System.Drawing.Size(103, 39);
            this.btnReMove.TabIndex = 3;
            this.btnReMove.Text = "Remove";
            this.btnReMove.UseVisualStyleBackColor = false;
            this.btnReMove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // fLuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1073, 648);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fLuat";
            this.Text = "LUAT";
            this.Load += new System.EventHandler(this.fLuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaptop)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLaptop;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbVT;
        private System.Windows.Forms.ComboBox cmbVT;
        private System.Windows.Forms.ComboBox cmbVP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dveTrai;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvePhai;
        private System.Windows.Forms.Button btnReMove;
    }
}