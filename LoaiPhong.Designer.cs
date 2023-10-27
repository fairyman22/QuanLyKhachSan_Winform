namespace QuanLyKhachSan
{
    partial class LoaiPhong
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
            this.dataGridViewLoaiPhong = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textTT = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.comboBoxPhong = new System.Windows.Forms.ComboBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.textPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLoaiPhong
            // 
            this.dataGridViewLoaiPhong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewLoaiPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLoaiPhong.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewLoaiPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoaiPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.maPhong,
            this.trangThai});
            this.dataGridViewLoaiPhong.Location = new System.Drawing.Point(76, 295);
            this.dataGridViewLoaiPhong.Name = "dataGridViewLoaiPhong";
            this.dataGridViewLoaiPhong.RowHeadersWidth = 51;
            this.dataGridViewLoaiPhong.RowTemplate.Height = 24;
            this.dataGridViewLoaiPhong.Size = new System.Drawing.Size(650, 216);
            this.dataGridViewLoaiPhong.TabIndex = 0;
            this.dataGridViewLoaiPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLoaiPhong_CellClick);
            this.dataGridViewLoaiPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLoaiPhong_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // maPhong
            // 
            this.maPhong.DataPropertyName = "maPhong";
            this.maPhong.HeaderText = "Mã Phòng";
            this.maPhong.MinimumWidth = 6;
            this.maPhong.Name = "maPhong";
            // 
            // trangThai
            // 
            this.trangThai.DataPropertyName = "trangThai";
            this.trangThai.HeaderText = "Trang Thai";
            this.trangThai.MinimumWidth = 6;
            this.trangThai.Name = "trangThai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Phòng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trạng Thái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "ID";
            // 
            // textID
            // 
            this.textID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.Location = new System.Drawing.Point(186, 63);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(121, 24);
            this.textID.TabIndex = 7;
            // 
            // textTT
            // 
            this.textTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTT.Location = new System.Drawing.Point(186, 164);
            this.textTT.Name = "textTT";
            this.textTT.Size = new System.Drawing.Size(121, 24);
            this.textTT.TabIndex = 8;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(434, 266);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(646, 266);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(541, 266);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // comboBoxPhong
            // 
            this.comboBoxPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPhong.FormattingEnabled = true;
            this.comboBoxPhong.Location = new System.Drawing.Point(186, 116);
            this.comboBoxPhong.Name = "comboBoxPhong";
            this.comboBoxPhong.Size = new System.Drawing.Size(121, 26);
            this.comboBoxPhong.TabIndex = 12;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(313, 216);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(98, 25);
            this.btnOpenFile.TabIndex = 24;
            this.btnOpenFile.Text = "Open file";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // textPath
            // 
            this.textPath.Location = new System.Drawing.Point(186, 216);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(121, 22);
            this.textPath.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Đường dẫn:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(37, 295);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(33, 23);
            this.btnRefresh.TabIndex = 25;
            this.btnRefresh.Text = "button1";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(313, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Xuất Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.textPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxPhong);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.textTT);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewLoaiPhong);
            this.Name = "LoaiPhong";
            this.Text = "LoaiPhong";
            this.Load += new System.EventHandler(this.LoaiPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLoaiPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textTT;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox comboBoxPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button button2;
    }
}