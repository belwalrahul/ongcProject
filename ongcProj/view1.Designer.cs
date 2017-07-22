namespace ongcProj
{
    partial class view1
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ongcProjectdBDataSet = new ongcProj.ongcProjectdBDataSet();
            this.fieldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldTableAdapter = new ongcProj.ongcProjectdBDataSetTableAdapters.fieldTableAdapter();
            this.fIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongcProjectdBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fIDDataGridViewTextBoxColumn,
            this.fNameDataGridViewTextBoxColumn,
            this.subIDDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.fieldBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(403, 296);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // ongcProjectdBDataSet
            // 
            this.ongcProjectdBDataSet.DataSetName = "ongcProjectdBDataSet";
            this.ongcProjectdBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldBindingSource
            // 
            this.fieldBindingSource.DataMember = "field";
            this.fieldBindingSource.DataSource = this.ongcProjectdBDataSet;
            // 
            // fieldTableAdapter
            // 
            this.fieldTableAdapter.ClearBeforeFill = true;
            // 
            // fIDDataGridViewTextBoxColumn
            // 
            this.fIDDataGridViewTextBoxColumn.DataPropertyName = "f_ID";
            this.fIDDataGridViewTextBoxColumn.HeaderText = "f_ID";
            this.fIDDataGridViewTextBoxColumn.Name = "fIDDataGridViewTextBoxColumn";
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "f_Name";
            this.fNameDataGridViewTextBoxColumn.HeaderText = "f_Name";
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            // 
            // subIDDataGridViewTextBoxColumn
            // 
            this.subIDDataGridViewTextBoxColumn.DataPropertyName = "sub_ID";
            this.subIDDataGridViewTextBoxColumn.HeaderText = "sub_ID";
            this.subIDDataGridViewTextBoxColumn.Name = "subIDDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "<<back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // view1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 295);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "view1";
            this.Text = "view1";
            this.Load += new System.EventHandler(this.view1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongcProjectdBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private ongcProjectdBDataSet ongcProjectdBDataSet;
        private System.Windows.Forms.BindingSource fieldBindingSource;
        private ongcProjectdBDataSetTableAdapters.fieldTableAdapter fieldTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}