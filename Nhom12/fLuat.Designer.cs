
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLaptop = new System.Windows.Forms.DataGridView();
            this.dID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dveTrai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvePhai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNotVT = new System.Windows.Forms.Panel();
            this.checkNotVT = new System.Windows.Forms.CheckBox();
            this.checkNotVP = new System.Windows.Forms.CheckBox();
            this.cmbVT = new System.Windows.Forms.ComboBox();
            this.cmbVP = new System.Windows.Forms.ComboBox();
            this.btnLoaiBoLuatThua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnReMove = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbVT = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaptop)).BeginInit();
            this.panel1.SuspendLayout();
            this.btnNotVT.SuspendLayout();
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLaptop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvLaptop.ColumnHeadersHeight = 50;
            this.dgvLaptop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dID,
            this.dveTrai,
            this.dvePhai});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLaptop.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvLaptop.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvLaptop.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvLaptop.Location = new System.Drawing.Point(50, 18);
            this.dgvLaptop.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLaptop.Name = "dgvLaptop";
            this.dgvLaptop.ReadOnly = true;
            this.dgvLaptop.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLaptop.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
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
            this.btnAdd.Location = new System.Drawing.Point(955, 16);
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
            // btnNotVT
            // 
            this.btnNotVT.BackColor = System.Drawing.Color.Transparent;
            this.btnNotVT.Controls.Add(this.checkNotVT);
            this.btnNotVT.Controls.Add(this.checkNotVP);
            this.btnNotVT.Controls.Add(this.cmbVT);
            this.btnNotVT.Controls.Add(this.cmbVP);
            this.btnNotVT.Controls.Add(this.btnLoaiBoLuatThua);
            this.btnNotVT.Controls.Add(this.btnXoa);
            this.btnNotVT.Controls.Add(this.btnCancel);
            this.btnNotVT.Controls.Add(this.btnThem);
            this.btnNotVT.Controls.Add(this.btnReMove);
            this.btnNotVT.Controls.Add(this.btnAdd);
            this.btnNotVT.Controls.Add(this.btnSua);
            this.btnNotVT.Controls.Add(this.label3);
            this.btnNotVT.Controls.Add(this.lbVT);
            this.btnNotVT.Controls.Add(this.label4);
            this.btnNotVT.Controls.Add(this.label2);
            this.btnNotVT.Controls.Add(this.label1);
            this.btnNotVT.Controls.Add(this.txtID);
            this.btnNotVT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotVT.ForeColor = System.Drawing.Color.Black;
            this.btnNotVT.Location = new System.Drawing.Point(0, 0);
            this.btnNotVT.Margin = new System.Windows.Forms.Padding(4);
            this.btnNotVT.Name = "btnNotVT";
            this.btnNotVT.Size = new System.Drawing.Size(1073, 186);
            this.btnNotVT.TabIndex = 5;
            // 
            // checkNotVT
            // 
            this.checkNotVT.AutoSize = true;
            this.checkNotVT.Location = new System.Drawing.Point(871, 14);
            this.checkNotVT.Name = "checkNotVT";
            this.checkNotVT.Size = new System.Drawing.Size(65, 26);
            this.checkNotVT.TabIndex = 5;
            this.checkNotVT.Text = "Not";
            this.checkNotVT.UseVisualStyleBackColor = true;
            // 
            // checkNotVP
            // 
            this.checkNotVP.AutoSize = true;
            this.checkNotVP.Location = new System.Drawing.Point(448, 66);
            this.checkNotVP.Name = "checkNotVP";
            this.checkNotVP.Size = new System.Drawing.Size(65, 26);
            this.checkNotVP.TabIndex = 5;
            this.checkNotVP.Text = "Not";
            this.checkNotVP.UseVisualStyleBackColor = true;
            // 
            // cmbVT
            // 
            this.cmbVT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbVT.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVT.FormattingEnabled = true;
            this.cmbVT.Location = new System.Drawing.Point(593, 14);
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
            this.cmbVP.Size = new System.Drawing.Size(289, 29);
            this.cmbVP.TabIndex = 4;
            // 
            // btnLoaiBoLuatThua
            // 
            this.btnLoaiBoLuatThua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLoaiBoLuatThua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.btnLoaiBoLuatThua.FlatAppearance.BorderSize = 0;
            this.btnLoaiBoLuatThua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoaiBoLuatThua.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaiBoLuatThua.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnLoaiBoLuatThua.Location = new System.Drawing.Point(871, 118);
            this.btnLoaiBoLuatThua.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnLoaiBoLuatThua.Name = "btnLoaiBoLuatThua";
            this.btnLoaiBoLuatThua.Size = new System.Drawing.Size(169, 52);
            this.btnLoaiBoLuatThua.TabIndex = 3;
            this.btnLoaiBoLuatThua.Text = "Loại bỏ luật dư thừa";
            this.btnLoaiBoLuatThua.UseVisualStyleBackColor = false;
            this.btnLoaiBoLuatThua.Click += new System.EventHandler(this.btnLoaiBoLuatThua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnXoa.Location = new System.Drawing.Point(697, 118);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(109, 52);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnCancel.Location = new System.Drawing.Point(493, 118);
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
            this.btnThem.Location = new System.Drawing.Point(302, 118);
            this.btnThem.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 52);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnReMove
            // 
            this.btnReMove.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.btnReMove.FlatAppearance.BorderSize = 0;
            this.btnReMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReMove.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReMove.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnReMove.Location = new System.Drawing.Point(955, 61);
            this.btnReMove.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnReMove.Name = "btnReMove";
            this.btnReMove.Size = new System.Drawing.Size(103, 39);
            this.btnReMove.TabIndex = 3;
            this.btnReMove.Text = "Remove";
            this.btnReMove.UseVisualStyleBackColor = false;
            this.btnReMove.Click += new System.EventHandler(this.btnRemove_Click);
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
            this.btnSua.Location = new System.Drawing.Point(111, 118);
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
            this.lbVT.Location = new System.Drawing.Point(589, 69);
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
            this.label2.Location = new System.Drawing.Point(516, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vế trái";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.btnNotVT);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1073, 648);
            this.panel3.TabIndex = 7;
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
            this.btnNotVT.ResumeLayout(false);
            this.btnNotVT.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLaptop;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel btnNotVT;
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
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLoaiBoLuatThua;
        private System.Windows.Forms.CheckBox checkNotVT;
        private System.Windows.Forms.CheckBox checkNotVP;
    }
}