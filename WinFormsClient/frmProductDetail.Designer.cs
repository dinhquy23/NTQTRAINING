namespace WinFormsClient
{
    partial class frmProductDetail
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
            this.cbbCategoryId = new System.Windows.Forms.ComboBox();
            this.cbbProductId = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dateTimeUpdate = new System.Windows.Forms.DateTimePicker();
            this.dateTimeCreate = new System.Windows.Forms.DateTimePicker();
            this.txtTagName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProductDetail = new System.Windows.Forms.DataGridView();
            this.dateTimeClosingDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimeStartingDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMadeBy = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbCategoryId
            // 
            this.cbbCategoryId.FormattingEnabled = true;
            this.cbbCategoryId.Location = new System.Drawing.Point(204, 145);
            this.cbbCategoryId.Name = "cbbCategoryId";
            this.cbbCategoryId.Size = new System.Drawing.Size(196, 23);
            this.cbbCategoryId.TabIndex = 58;
            // 
            // cbbProductId
            // 
            this.cbbProductId.AutoSize = true;
            this.cbbProductId.Location = new System.Drawing.Point(105, 151);
            this.cbbProductId.Name = "cbbProductId";
            this.cbbProductId.Size = new System.Drawing.Size(62, 15);
            this.cbbProductId.TabIndex = 57;
            this.cbbProductId.Text = "Product Id";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(578, 237);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 56;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(460, 237);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 55;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(349, 237);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 54;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dateTimeUpdate
            // 
            this.dateTimeUpdate.Location = new System.Drawing.Point(639, 168);
            this.dateTimeUpdate.Name = "dateTimeUpdate";
            this.dateTimeUpdate.Size = new System.Drawing.Size(165, 23);
            this.dateTimeUpdate.TabIndex = 52;
            // 
            // dateTimeCreate
            // 
            this.dateTimeCreate.Location = new System.Drawing.Point(639, 131);
            this.dateTimeCreate.Name = "dateTimeCreate";
            this.dateTimeCreate.Size = new System.Drawing.Size(165, 23);
            this.dateTimeCreate.TabIndex = 51;
            // 
            // txtTagName
            // 
            this.txtTagName.Location = new System.Drawing.Point(204, 112);
            this.txtTagName.Name = "txtTagName";
            this.txtTagName.Size = new System.Drawing.Size(196, 23);
            this.txtTagName.TabIndex = 50;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(204, 79);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(196, 23);
            this.txtPrice.TabIndex = 49;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(204, 46);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(196, 23);
            this.txtId.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(531, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 47;
            this.label6.Text = "UpdateDate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(531, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 46;
            this.label5.Text = "CreateDate";
            // 
            // txtColor
            // 
            this.txtColor.AutoSize = true;
            this.txtColor.Location = new System.Drawing.Point(105, 120);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(36, 15);
            this.txtColor.TabIndex = 44;
            this.txtColor.Text = "Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 43;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "Id";
            // 
            // dgvProductDetail
            // 
            this.dgvProductDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductDetail.Location = new System.Drawing.Point(70, 292);
            this.dgvProductDetail.Name = "dgvProductDetail";
            this.dgvProductDetail.RowTemplate.Height = 25;
            this.dgvProductDetail.Size = new System.Drawing.Size(851, 277);
            this.dgvProductDetail.TabIndex = 41;
            this.dgvProductDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductDetail_CellClick);
            // 
            // dateTimeClosingDate
            // 
            this.dateTimeClosingDate.Location = new System.Drawing.Point(639, 94);
            this.dateTimeClosingDate.Name = "dateTimeClosingDate";
            this.dateTimeClosingDate.Size = new System.Drawing.Size(165, 23);
            this.dateTimeClosingDate.TabIndex = 62;
            // 
            // dateTimeStartingDate
            // 
            this.dateTimeStartingDate.Location = new System.Drawing.Point(639, 57);
            this.dateTimeStartingDate.Name = "dateTimeStartingDate";
            this.dateTimeStartingDate.Size = new System.Drawing.Size(165, 23);
            this.dateTimeStartingDate.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(531, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 60;
            this.label3.Text = "ClosingDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(531, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 59;
            this.label4.Text = "StartingDate";
            // 
            // txtMadeBy
            // 
            this.txtMadeBy.Location = new System.Drawing.Point(204, 178);
            this.txtMadeBy.Name = "txtMadeBy";
            this.txtMadeBy.Size = new System.Drawing.Size(196, 23);
            this.txtMadeBy.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 63;
            this.label7.Text = "Made By";
            // 
            // frmProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 611);
            this.Controls.Add(this.txtMadeBy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimeClosingDate);
            this.Controls.Add(this.dateTimeStartingDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbCategoryId);
            this.Controls.Add(this.cbbProductId);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dateTimeUpdate);
            this.Controls.Add(this.dateTimeCreate);
            this.Controls.Add(this.txtTagName);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProductDetail);
            this.Name = "frmProductDetail";
            this.Text = "frmProductDetail";
            this.Load += new System.EventHandler(this.frmProductDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbbCategoryId;
        private Label cbbProductId;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnCreate;
        private DateTimePicker dateTimeUpdate;
        private DateTimePicker dateTimeCreate;
        private TextBox txtTagName;
        private TextBox txtPrice;
        private TextBox txtId;
        private Label label6;
        private Label label5;
        private Label txtColor;
        private Label label2;
        private Label label1;
        private DataGridView dgvProductDetail;
        private DateTimePicker dateTimeClosingDate;
        private DateTimePicker dateTimeStartingDate;
        private Label label3;
        private Label label4;
        private TextBox txtMadeBy;
        private Label label7;
    }
}