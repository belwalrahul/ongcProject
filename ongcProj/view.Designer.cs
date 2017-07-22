namespace ongcProj
{
    partial class view
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOfAssetBasinInstituteCoDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eORMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eORSubMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportedIssueOnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highlightsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insertDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insertUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservoirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ongcProjectdBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ongcProjectdBDataSet = new ongcProj.ongcProjectdBDataSet();
            this.basinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.basinTableAdapter = new ongcProj.ongcProjectdBDataSetTableAdapters.basinTableAdapter();
            this.fieldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldTableAdapter = new ongcProj.ongcProjectdBDataSetTableAdapters.fieldTableAdapter();
            this.reservoirTableAdapter = new ongcProj.ongcProjectdBDataSetTableAdapters.reservoirTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservoirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongcProjectdBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongcProjectdBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rIDDataGridViewTextBoxColumn,
            this.fieldIDDataGridViewTextBoxColumn,
            this.nameOfAssetBasinInstituteCoDDataGridViewTextBoxColumn,
            this.sandDataGridViewTextBoxColumn,
            this.projectTitleDataGridViewTextBoxColumn,
            this.eORMethodDataGridViewTextBoxColumn,
            this.eORSubMethodDataGridViewTextBoxColumn,
            this.groupNameDataGridViewTextBoxColumn,
            this.stagesDataGridViewTextBoxColumn,
            this.yearDurationDataGridViewTextBoxColumn,
            this.reportedIssueOnDataGridViewTextBoxColumn,
            this.highlightsDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn,
            this.additionalDataDataGridViewTextBoxColumn,
            this.insertDateDataGridViewTextBoxColumn,
            this.insertUserDataGridViewTextBoxColumn,
            this.updateDateDataGridViewTextBoxColumn,
            this.updateUserDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reservoirBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(670, 304);
            this.dataGridView1.TabIndex = 0;
            // 
            // rIDDataGridViewTextBoxColumn
            // 
            this.rIDDataGridViewTextBoxColumn.DataPropertyName = "r_ID";
            this.rIDDataGridViewTextBoxColumn.HeaderText = "r_ID";
            this.rIDDataGridViewTextBoxColumn.Name = "rIDDataGridViewTextBoxColumn";
            // 
            // fieldIDDataGridViewTextBoxColumn
            // 
            this.fieldIDDataGridViewTextBoxColumn.DataPropertyName = "Field_ID";
            this.fieldIDDataGridViewTextBoxColumn.HeaderText = "Field_ID";
            this.fieldIDDataGridViewTextBoxColumn.Name = "fieldIDDataGridViewTextBoxColumn";
            // 
            // nameOfAssetBasinInstituteCoDDataGridViewTextBoxColumn
            // 
            this.nameOfAssetBasinInstituteCoDDataGridViewTextBoxColumn.DataPropertyName = "Name of Asset/Basin/Institute/CoD";
            this.nameOfAssetBasinInstituteCoDDataGridViewTextBoxColumn.HeaderText = "Name of Asset/Basin/Institute/CoD";
            this.nameOfAssetBasinInstituteCoDDataGridViewTextBoxColumn.Name = "nameOfAssetBasinInstituteCoDDataGridViewTextBoxColumn";
            // 
            // sandDataGridViewTextBoxColumn
            // 
            this.sandDataGridViewTextBoxColumn.DataPropertyName = "Sand";
            this.sandDataGridViewTextBoxColumn.HeaderText = "Sand";
            this.sandDataGridViewTextBoxColumn.Name = "sandDataGridViewTextBoxColumn";
            // 
            // projectTitleDataGridViewTextBoxColumn
            // 
            this.projectTitleDataGridViewTextBoxColumn.DataPropertyName = "Project Title";
            this.projectTitleDataGridViewTextBoxColumn.HeaderText = "Project Title";
            this.projectTitleDataGridViewTextBoxColumn.Name = "projectTitleDataGridViewTextBoxColumn";
            // 
            // eORMethodDataGridViewTextBoxColumn
            // 
            this.eORMethodDataGridViewTextBoxColumn.DataPropertyName = "EOR Method";
            this.eORMethodDataGridViewTextBoxColumn.HeaderText = "EOR Method";
            this.eORMethodDataGridViewTextBoxColumn.Name = "eORMethodDataGridViewTextBoxColumn";
            // 
            // eORSubMethodDataGridViewTextBoxColumn
            // 
            this.eORSubMethodDataGridViewTextBoxColumn.DataPropertyName = "EOR Sub-Method";
            this.eORSubMethodDataGridViewTextBoxColumn.HeaderText = "EOR Sub-Method";
            this.eORSubMethodDataGridViewTextBoxColumn.Name = "eORSubMethodDataGridViewTextBoxColumn";
            // 
            // groupNameDataGridViewTextBoxColumn
            // 
            this.groupNameDataGridViewTextBoxColumn.DataPropertyName = "Group Name";
            this.groupNameDataGridViewTextBoxColumn.HeaderText = "Group Name";
            this.groupNameDataGridViewTextBoxColumn.Name = "groupNameDataGridViewTextBoxColumn";
            // 
            // stagesDataGridViewTextBoxColumn
            // 
            this.stagesDataGridViewTextBoxColumn.DataPropertyName = "Stages";
            this.stagesDataGridViewTextBoxColumn.HeaderText = "Stages";
            this.stagesDataGridViewTextBoxColumn.Name = "stagesDataGridViewTextBoxColumn";
            // 
            // yearDurationDataGridViewTextBoxColumn
            // 
            this.yearDurationDataGridViewTextBoxColumn.DataPropertyName = "Year/Duration";
            this.yearDurationDataGridViewTextBoxColumn.HeaderText = "Year/Duration";
            this.yearDurationDataGridViewTextBoxColumn.Name = "yearDurationDataGridViewTextBoxColumn";
            // 
            // reportedIssueOnDataGridViewTextBoxColumn
            // 
            this.reportedIssueOnDataGridViewTextBoxColumn.DataPropertyName = "Reported Issue On";
            this.reportedIssueOnDataGridViewTextBoxColumn.HeaderText = "Reported Issue On";
            this.reportedIssueOnDataGridViewTextBoxColumn.Name = "reportedIssueOnDataGridViewTextBoxColumn";
            // 
            // highlightsDataGridViewTextBoxColumn
            // 
            this.highlightsDataGridViewTextBoxColumn.DataPropertyName = "Highlights";
            this.highlightsDataGridViewTextBoxColumn.HeaderText = "Highlights";
            this.highlightsDataGridViewTextBoxColumn.Name = "highlightsDataGridViewTextBoxColumn";
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            // 
            // additionalDataDataGridViewTextBoxColumn
            // 
            this.additionalDataDataGridViewTextBoxColumn.DataPropertyName = "Additional Data";
            this.additionalDataDataGridViewTextBoxColumn.HeaderText = "Additional Data";
            this.additionalDataDataGridViewTextBoxColumn.Name = "additionalDataDataGridViewTextBoxColumn";
            // 
            // insertDateDataGridViewTextBoxColumn
            // 
            this.insertDateDataGridViewTextBoxColumn.DataPropertyName = "Insert Date";
            this.insertDateDataGridViewTextBoxColumn.HeaderText = "Insert Date";
            this.insertDateDataGridViewTextBoxColumn.Name = "insertDateDataGridViewTextBoxColumn";
            // 
            // insertUserDataGridViewTextBoxColumn
            // 
            this.insertUserDataGridViewTextBoxColumn.DataPropertyName = "Insert User";
            this.insertUserDataGridViewTextBoxColumn.HeaderText = "Insert User";
            this.insertUserDataGridViewTextBoxColumn.Name = "insertUserDataGridViewTextBoxColumn";
            // 
            // updateDateDataGridViewTextBoxColumn
            // 
            this.updateDateDataGridViewTextBoxColumn.DataPropertyName = "Update Date";
            this.updateDateDataGridViewTextBoxColumn.HeaderText = "Update Date";
            this.updateDateDataGridViewTextBoxColumn.Name = "updateDateDataGridViewTextBoxColumn";
            // 
            // updateUserDataGridViewTextBoxColumn
            // 
            this.updateUserDataGridViewTextBoxColumn.DataPropertyName = "Update User";
            this.updateUserDataGridViewTextBoxColumn.HeaderText = "Update User";
            this.updateUserDataGridViewTextBoxColumn.Name = "updateUserDataGridViewTextBoxColumn";
            // 
            // reservoirBindingSource
            // 
            this.reservoirBindingSource.DataMember = "reservoir";
            this.reservoirBindingSource.DataSource = this.ongcProjectdBDataSetBindingSource;
            // 
            // ongcProjectdBDataSetBindingSource
            // 
            this.ongcProjectdBDataSetBindingSource.DataSource = this.ongcProjectdBDataSet;
            this.ongcProjectdBDataSetBindingSource.Position = 0;
            // 
            // ongcProjectdBDataSet
            // 
            this.ongcProjectdBDataSet.DataSetName = "ongcProjectdBDataSet";
            this.ongcProjectdBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // basinBindingSource
            // 
            this.basinBindingSource.DataMember = "basin";
            this.basinBindingSource.DataSource = this.ongcProjectdBDataSetBindingSource;
            // 
            // basinTableAdapter
            // 
            this.basinTableAdapter.ClearBeforeFill = true;
            // 
            // fieldBindingSource
            // 
            this.fieldBindingSource.DataMember = "field";
            this.fieldBindingSource.DataSource = this.ongcProjectdBDataSetBindingSource;
            // 
            // fieldTableAdapter
            // 
            this.fieldTableAdapter.ClearBeforeFill = true;
            // 
            // reservoirTableAdapter
            // 
            this.reservoirTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "<<back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 328);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "view";
            this.Text = "view";
            this.Load += new System.EventHandler(this.view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservoirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongcProjectdBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongcProjectdBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ongcProjectdBDataSetBindingSource;
        private ongcProjectdBDataSet ongcProjectdBDataSet;
        private System.Windows.Forms.BindingSource basinBindingSource;
        private ongcProjectdBDataSetTableAdapters.basinTableAdapter basinTableAdapter;
        private System.Windows.Forms.BindingSource fieldBindingSource;
        private ongcProjectdBDataSetTableAdapters.fieldTableAdapter fieldTableAdapter;
        private System.Windows.Forms.BindingSource reservoirBindingSource;
        private ongcProjectdBDataSetTableAdapters.reservoirTableAdapter reservoirTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfAssetBasinInstituteCoDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eORMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eORSubMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stagesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportedIssueOnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn highlightsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insertDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insertUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}