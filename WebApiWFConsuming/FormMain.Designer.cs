namespace WebApiWFConsuming
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApiUrl = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpAPI = new System.Windows.Forms.TabPage();
            this.tcPut = new System.Windows.Forms.TabControl();
            this.tpSUPPLIER = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSupplierDate = new System.Windows.Forms.TextBox();
            this.btnSaveSupplier = new System.Windows.Forms.Button();
            this.btnGetSupplier = new System.Windows.Forms.Button();
            this.btnEditSupplier = new System.Windows.Forms.Button();
            this.btnNewSupplier = new System.Windows.Forms.Button();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.tpPutBRAND = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGet = new System.Windows.Forms.Button();
            this.dgvGetResult = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGetResult = new System.Windows.Forms.TextBox();
            this.tpDataModel = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sUPPLIERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDSUPPLIERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dSCSUPPLIERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEOFREGISTERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bRANDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpAPI.SuspendLayout();
            this.tcPut.SuspendLayout();
            this.tpSUPPLIER.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.tpPutBRAND.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetResult)).BeginInit();
            this.tpDataModel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtApiUrl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 61);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Api URL Base";
            // 
            // txtApiUrl
            // 
            this.txtApiUrl.Location = new System.Drawing.Point(12, 25);
            this.txtApiUrl.Name = "txtApiUrl";
            this.txtApiUrl.Size = new System.Drawing.Size(466, 20);
            this.txtApiUrl.TabIndex = 3;
            this.txtApiUrl.Text = "http://localhost:51077/";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpAPI);
            this.tabControl1.Controls.Add(this.tpDataModel);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 61);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 435);
            this.tabControl1.TabIndex = 11;
            // 
            // tpAPI
            // 
            this.tpAPI.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tpAPI.Controls.Add(this.tcPut);
            this.tpAPI.Location = new System.Drawing.Point(4, 22);
            this.tpAPI.Name = "tpAPI";
            this.tpAPI.Padding = new System.Windows.Forms.Padding(3);
            this.tpAPI.Size = new System.Drawing.Size(792, 409);
            this.tpAPI.TabIndex = 1;
            this.tpAPI.Text = "APIs";
            // 
            // tcPut
            // 
            this.tcPut.Controls.Add(this.tpSUPPLIER);
            this.tcPut.Controls.Add(this.tpPutBRAND);
            this.tcPut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPut.Location = new System.Drawing.Point(3, 3);
            this.tcPut.Name = "tcPut";
            this.tcPut.SelectedIndex = 0;
            this.tcPut.Size = new System.Drawing.Size(786, 403);
            this.tcPut.TabIndex = 1;
            // 
            // tpSUPPLIER
            // 
            this.tpSUPPLIER.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tpSUPPLIER.Controls.Add(this.btnDelete);
            this.tpSUPPLIER.Controls.Add(this.label7);
            this.tpSUPPLIER.Controls.Add(this.txtSupplierDate);
            this.tpSUPPLIER.Controls.Add(this.btnSaveSupplier);
            this.tpSUPPLIER.Controls.Add(this.btnGetSupplier);
            this.tpSUPPLIER.Controls.Add(this.btnEditSupplier);
            this.tpSUPPLIER.Controls.Add(this.btnNewSupplier);
            this.tpSUPPLIER.Controls.Add(this.dgvSupplier);
            this.tpSUPPLIER.Controls.Add(this.label6);
            this.tpSUPPLIER.Controls.Add(this.label5);
            this.tpSUPPLIER.Controls.Add(this.txtSupplierID);
            this.tpSUPPLIER.Controls.Add(this.txtSupplierName);
            this.tpSUPPLIER.Location = new System.Drawing.Point(4, 22);
            this.tpSUPPLIER.Name = "tpSUPPLIER";
            this.tpSUPPLIER.Padding = new System.Windows.Forms.Padding(3);
            this.tpSUPPLIER.Size = new System.Drawing.Size(778, 377);
            this.tpSUPPLIER.TabIndex = 1;
            this.tpSUPPLIER.Text = "SUPPLIERs";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(302, 28);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete (delete)";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Registration date";
            // 
            // txtSupplierDate
            // 
            this.txtSupplierDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sUPPLIERBindingSource, "DATE_OF_REGISTER", true));
            this.txtSupplierDate.Location = new System.Drawing.Point(10, 163);
            this.txtSupplierDate.Name = "txtSupplierDate";
            this.txtSupplierDate.ReadOnly = true;
            this.txtSupplierDate.Size = new System.Drawing.Size(180, 20);
            this.txtSupplierDate.TabIndex = 9;
            // 
            // btnSaveSupplier
            // 
            this.btnSaveSupplier.Location = new System.Drawing.Point(204, 28);
            this.btnSaveSupplier.Name = "btnSaveSupplier";
            this.btnSaveSupplier.Size = new System.Drawing.Size(95, 23);
            this.btnSaveSupplier.TabIndex = 8;
            this.btnSaveSupplier.Text = "Save New (post)";
            this.btnSaveSupplier.UseVisualStyleBackColor = true;
            this.btnSaveSupplier.Click += new System.EventHandler(this.btnSaveSupplier_Click);
            // 
            // btnGetSupplier
            // 
            this.btnGetSupplier.Location = new System.Drawing.Point(9, 28);
            this.btnGetSupplier.Name = "btnGetSupplier";
            this.btnGetSupplier.Size = new System.Drawing.Size(95, 23);
            this.btnGetSupplier.TabIndex = 7;
            this.btnGetSupplier.Text = "Get";
            this.btnGetSupplier.UseVisualStyleBackColor = true;
            this.btnGetSupplier.Click += new System.EventHandler(this.btnGetSupplier_Click);
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.Location = new System.Drawing.Point(107, 28);
            this.btnEditSupplier.Name = "btnEditSupplier";
            this.btnEditSupplier.Size = new System.Drawing.Size(95, 23);
            this.btnEditSupplier.TabIndex = 6;
            this.btnEditSupplier.Text = "Update (put)";
            this.btnEditSupplier.UseVisualStyleBackColor = true;
            this.btnEditSupplier.Click += new System.EventHandler(this.btnEditSupplier_Click);
            // 
            // btnNewSupplier
            // 
            this.btnNewSupplier.Location = new System.Drawing.Point(10, 207);
            this.btnNewSupplier.Name = "btnNewSupplier";
            this.btnNewSupplier.Size = new System.Drawing.Size(95, 23);
            this.btnNewSupplier.TabIndex = 5;
            this.btnNewSupplier.Text = "New Supplier";
            this.btnNewSupplier.UseVisualStyleBackColor = true;
            this.btnNewSupplier.Click += new System.EventHandler(this.btnNewSupplier_Click);
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSupplier.AutoGenerateColumns = false;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSUPPLIERDataGridViewTextBoxColumn,
            this.dSCSUPPLIERDataGridViewTextBoxColumn,
            this.dATEOFREGISTERDataGridViewTextBoxColumn,
            this.bRANDDataGridViewTextBoxColumn});
            this.dgvSupplier.DataSource = this.sUPPLIERBindingSource;
            this.dgvSupplier.Location = new System.Drawing.Point(404, 3);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.Size = new System.Drawing.Size(371, 371);
            this.dgvSupplier.TabIndex = 4;
            this.dgvSupplier.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvSupplier_RowsAdded);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Id:";
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sUPPLIERBindingSource, "ID_SUPPLIER", true));
            this.txtSupplierID.Location = new System.Drawing.Point(9, 81);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.ReadOnly = true;
            this.txtSupplierID.Size = new System.Drawing.Size(180, 20);
            this.txtSupplierID.TabIndex = 1;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sUPPLIERBindingSource, "DSC_SUPPLIER", true));
            this.txtSupplierName.Location = new System.Drawing.Point(10, 122);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(247, 20);
            this.txtSupplierName.TabIndex = 0;
            // 
            // tpPutBRAND
            // 
            this.tpPutBRAND.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tpPutBRAND.Controls.Add(this.label4);
            this.tpPutBRAND.Controls.Add(this.btnGet);
            this.tpPutBRAND.Controls.Add(this.dgvGetResult);
            this.tpPutBRAND.Controls.Add(this.label2);
            this.tpPutBRAND.Controls.Add(this.txtGetResult);
            this.tpPutBRAND.Location = new System.Drawing.Point(4, 22);
            this.tpPutBRAND.Name = "tpPutBRAND";
            this.tpPutBRAND.Padding = new System.Windows.Forms.Padding(3);
            this.tpPutBRAND.Size = new System.Drawing.Size(778, 377);
            this.tpPutBRAND.TabIndex = 0;
            this.tpPutBRAND.Text = "BRANDs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Api Result as GridView";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(12, 19);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(179, 23);
            this.btnGet.TabIndex = 19;
            this.btnGet.Text = "Get Brands";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // dgvGetResult
            // 
            this.dgvGetResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGetResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGetResult.Location = new System.Drawing.Point(12, 284);
            this.dgvGetResult.Name = "dgvGetResult";
            this.dgvGetResult.Size = new System.Drawing.Size(758, 181);
            this.dgvGetResult.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Api Result as Text";
            // 
            // txtGetResult
            // 
            this.txtGetResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGetResult.Location = new System.Drawing.Point(12, 67);
            this.txtGetResult.Multiline = true;
            this.txtGetResult.Name = "txtGetResult";
            this.txtGetResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGetResult.Size = new System.Drawing.Size(758, 194);
            this.txtGetResult.TabIndex = 17;
            // 
            // tpDataModel
            // 
            this.tpDataModel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tpDataModel.Controls.Add(this.pictureBox1);
            this.tpDataModel.Controls.Add(this.textBox1);
            this.tpDataModel.Location = new System.Drawing.Point(4, 22);
            this.tpDataModel.Name = "tpDataModel";
            this.tpDataModel.Padding = new System.Windows.Forms.Padding(3);
            this.tpDataModel.Size = new System.Drawing.Size(792, 409);
            this.tpDataModel.TabIndex = 2;
            this.tpDataModel.Text = "Data Modeling Representation";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightBlue;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(786, 71);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "The Data modeling representation is just for the academic purpose, to show how th" +
    "e tables connect together.\r\nNotice that in the project \"WebApiModel\" the Entity " +
    "Framework was used as Code First.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(786, 332);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // sUPPLIERBindingSource
            // 
            this.sUPPLIERBindingSource.DataSource = typeof(WebApiEFModel.SUPPLIER);
            // 
            // iDSUPPLIERDataGridViewTextBoxColumn
            // 
            this.iDSUPPLIERDataGridViewTextBoxColumn.DataPropertyName = "ID_SUPPLIER";
            this.iDSUPPLIERDataGridViewTextBoxColumn.HeaderText = "ID_SUPPLIER";
            this.iDSUPPLIERDataGridViewTextBoxColumn.Name = "iDSUPPLIERDataGridViewTextBoxColumn";
            // 
            // dSCSUPPLIERDataGridViewTextBoxColumn
            // 
            this.dSCSUPPLIERDataGridViewTextBoxColumn.DataPropertyName = "DSC_SUPPLIER";
            this.dSCSUPPLIERDataGridViewTextBoxColumn.HeaderText = "DSC_SUPPLIER";
            this.dSCSUPPLIERDataGridViewTextBoxColumn.Name = "dSCSUPPLIERDataGridViewTextBoxColumn";
            // 
            // dATEOFREGISTERDataGridViewTextBoxColumn
            // 
            this.dATEOFREGISTERDataGridViewTextBoxColumn.DataPropertyName = "DATE_OF_REGISTER";
            this.dATEOFREGISTERDataGridViewTextBoxColumn.HeaderText = "DATE_OF_REGISTER";
            this.dATEOFREGISTERDataGridViewTextBoxColumn.Name = "dATEOFREGISTERDataGridViewTextBoxColumn";
            // 
            // bRANDDataGridViewTextBoxColumn
            // 
            this.bRANDDataGridViewTextBoxColumn.DataPropertyName = "BRAND";
            this.bRANDDataGridViewTextBoxColumn.HeaderText = "BRAND";
            this.bRANDDataGridViewTextBoxColumn.Name = "bRANDDataGridViewTextBoxColumn";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "Consuming API in Windows Forms - Gildasio Cardoso (gildasiocardoso@gmail.com)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpAPI.ResumeLayout(false);
            this.tcPut.ResumeLayout(false);
            this.tpSUPPLIER.ResumeLayout(false);
            this.tpSUPPLIER.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.tpPutBRAND.ResumeLayout(false);
            this.tpPutBRAND.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetResult)).EndInit();
            this.tpDataModel.ResumeLayout(false);
            this.tpDataModel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApiUrl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpAPI;
        private System.Windows.Forms.TabControl tcPut;
        private System.Windows.Forms.TabPage tpPutBRAND;
        private System.Windows.Forms.TabPage tpSUPPLIER;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Button btnEditSupplier;
        private System.Windows.Forms.Button btnNewSupplier;
        private System.Windows.Forms.Button btnGetSupplier;
        private System.Windows.Forms.Button btnSaveSupplier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSupplierDate;
        private System.Windows.Forms.BindingSource sUPPLIERBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSUPPLIERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dSCSUPPLIERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEOFREGISTERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bRANDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.DataGridView dgvGetResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGetResult;
        private System.Windows.Forms.TabPage tpDataModel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvSupplier;
    }
}