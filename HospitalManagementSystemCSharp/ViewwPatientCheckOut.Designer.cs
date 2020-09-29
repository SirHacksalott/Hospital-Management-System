﻿namespace HospitalManagementSystemCSharp
{
    partial class ViewwPatientCheckOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewwPatientCheckOut));
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkoutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet3 = new HospitalManagementSystemCSharp.hospitalDataSet3();
            this.checkoutTableAdapter = new HospitalManagementSystemCSharp.hospitalDataSet3TableAdapters.checkoutTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diseaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(322, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 29);
            this.label3.TabIndex = 117;
            this.label3.Text = "Patient History";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(450, 152);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 26);
            this.textBox1.TabIndex = 116;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 115;
            this.label1.Text = "Patient Id";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(327, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 118;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(352, 209);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 33);
            this.button1.TabIndex = 161;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.genDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.addrDataGridViewTextBoxColumn,
            this.diseaseDataGridViewTextBoxColumn,
            this.dateinDataGridViewTextBoxColumn,
            this.dateoutDataGridViewTextBoxColumn,
            this.buildDataGridViewTextBoxColumn,
            this.rnoDataGridViewTextBoxColumn,
            this.rtypeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.medpriceDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.eidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.checkoutBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(49, 281);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(685, 290);
            this.dataGridView1.TabIndex = 162;
            // 
            // checkoutBindingSource
            // 
            this.checkoutBindingSource.DataMember = "checkout";
            this.checkoutBindingSource.DataSource = this.hospitalDataSet3;
            // 
            // hospitalDataSet3
            // 
            this.hospitalDataSet3.DataSetName = "hospitalDataSet3";
            this.hospitalDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkoutTableAdapter
            // 
            this.checkoutTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // genDataGridViewTextBoxColumn
            // 
            this.genDataGridViewTextBoxColumn.DataPropertyName = "gen";
            this.genDataGridViewTextBoxColumn.HeaderText = "gen";
            this.genDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genDataGridViewTextBoxColumn.Name = "genDataGridViewTextBoxColumn";
            this.genDataGridViewTextBoxColumn.Width = 125;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "age";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "contact";
            this.contactDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            this.contactDataGridViewTextBoxColumn.Width = 125;
            // 
            // addrDataGridViewTextBoxColumn
            // 
            this.addrDataGridViewTextBoxColumn.DataPropertyName = "addr";
            this.addrDataGridViewTextBoxColumn.HeaderText = "addr";
            this.addrDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addrDataGridViewTextBoxColumn.Name = "addrDataGridViewTextBoxColumn";
            this.addrDataGridViewTextBoxColumn.Width = 125;
            // 
            // diseaseDataGridViewTextBoxColumn
            // 
            this.diseaseDataGridViewTextBoxColumn.DataPropertyName = "disease";
            this.diseaseDataGridViewTextBoxColumn.HeaderText = "disease";
            this.diseaseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diseaseDataGridViewTextBoxColumn.Name = "diseaseDataGridViewTextBoxColumn";
            this.diseaseDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateinDataGridViewTextBoxColumn
            // 
            this.dateinDataGridViewTextBoxColumn.DataPropertyName = "date_in";
            this.dateinDataGridViewTextBoxColumn.HeaderText = "date_in";
            this.dateinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateinDataGridViewTextBoxColumn.Name = "dateinDataGridViewTextBoxColumn";
            this.dateinDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateoutDataGridViewTextBoxColumn
            // 
            this.dateoutDataGridViewTextBoxColumn.DataPropertyName = "date_out";
            this.dateoutDataGridViewTextBoxColumn.HeaderText = "date_out";
            this.dateoutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateoutDataGridViewTextBoxColumn.Name = "dateoutDataGridViewTextBoxColumn";
            this.dateoutDataGridViewTextBoxColumn.Width = 125;
            // 
            // buildDataGridViewTextBoxColumn
            // 
            this.buildDataGridViewTextBoxColumn.DataPropertyName = "build";
            this.buildDataGridViewTextBoxColumn.HeaderText = "build";
            this.buildDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.buildDataGridViewTextBoxColumn.Name = "buildDataGridViewTextBoxColumn";
            this.buildDataGridViewTextBoxColumn.Width = 125;
            // 
            // rnoDataGridViewTextBoxColumn
            // 
            this.rnoDataGridViewTextBoxColumn.DataPropertyName = "r_no";
            this.rnoDataGridViewTextBoxColumn.HeaderText = "r_no";
            this.rnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rnoDataGridViewTextBoxColumn.Name = "rnoDataGridViewTextBoxColumn";
            this.rnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // rtypeDataGridViewTextBoxColumn
            // 
            this.rtypeDataGridViewTextBoxColumn.DataPropertyName = "r_type";
            this.rtypeDataGridViewTextBoxColumn.HeaderText = "r_type";
            this.rtypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rtypeDataGridViewTextBoxColumn.Name = "rtypeDataGridViewTextBoxColumn";
            this.rtypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // medpriceDataGridViewTextBoxColumn
            // 
            this.medpriceDataGridViewTextBoxColumn.DataPropertyName = "med_price";
            this.medpriceDataGridViewTextBoxColumn.HeaderText = "med_price";
            this.medpriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medpriceDataGridViewTextBoxColumn.Name = "medpriceDataGridViewTextBoxColumn";
            this.medpriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.Width = 125;
            // 
            // eidDataGridViewTextBoxColumn
            // 
            this.eidDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.eidDataGridViewTextBoxColumn.HeaderText = "eid";
            this.eidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eidDataGridViewTextBoxColumn.Name = "eidDataGridViewTextBoxColumn";
            this.eidDataGridViewTextBoxColumn.Width = 125;
            // 
            // ViewwPatientCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(897, 792);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ViewwPatientCheckOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewwPatientCheckOut";
            this.Load += new System.EventHandler(this.ViewwPatientCheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private hospitalDataSet3 hospitalDataSet3;
        private System.Windows.Forms.BindingSource checkoutBindingSource;
        private hospitalDataSet3TableAdapters.checkoutTableAdapter checkoutTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diseaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eidDataGridViewTextBoxColumn;
    }
}