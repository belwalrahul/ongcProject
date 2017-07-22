namespace ongcProj
{
    partial class view3
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
            this.ongcProjectdBDataSet = new ongcProj.ongcProjectdBDataSet();
            this.basinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.basinTableAdapter = new ongcProj.ongcProjectdBDataSetTableAdapters.basinTableAdapter();
            this.bidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongcProjectdBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basinBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bidDataGridViewTextBoxColumn,
            this.bnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.basinBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(287, 259);
            this.dataGridView1.TabIndex = 0;
            // 
            // ongcProjectdBDataSet
            // 
            this.ongcProjectdBDataSet.DataSetName = "ongcProjectdBDataSet";
            this.ongcProjectdBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // basinBindingSource
            // 
            this.basinBindingSource.DataMember = "basin";
            this.basinBindingSource.DataSource = this.ongcProjectdBDataSet;
            // 
            // basinTableAdapter
            // 
            this.basinTableAdapter.ClearBeforeFill = true;
            // 
            // bidDataGridViewTextBoxColumn
            // 
            this.bidDataGridViewTextBoxColumn.DataPropertyName = "bid";
            this.bidDataGridViewTextBoxColumn.HeaderText = "bid";
            this.bidDataGridViewTextBoxColumn.Name = "bidDataGridViewTextBoxColumn";
            // 
            // bnameDataGridViewTextBoxColumn
            // 
            this.bnameDataGridViewTextBoxColumn.DataPropertyName = "bname";
            this.bnameDataGridViewTextBoxColumn.HeaderText = "bname";
            this.bnameDataGridViewTextBoxColumn.Name = "bnameDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "<<back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // view3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "view3";
            this.Text = "view3";
            this.Load += new System.EventHandler(this.view3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongcProjectdBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basinBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ongcProjectdBDataSet ongcProjectdBDataSet;
        private System.Windows.Forms.BindingSource basinBindingSource;
        private ongcProjectdBDataSetTableAdapters.basinTableAdapter basinTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}