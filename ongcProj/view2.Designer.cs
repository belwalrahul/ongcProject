namespace ongcProj
{
    partial class view2
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
            this.subbasinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subbasinTableAdapter = new ongcProj.ongcProjectdBDataSetTableAdapters.subbasinTableAdapter();
            this.subIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongcProjectdBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subbasinBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subIDDataGridViewTextBoxColumn,
            this.subNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.subbasinBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(279, 260);
            this.dataGridView1.TabIndex = 0;
            // 
            // ongcProjectdBDataSet
            // 
            this.ongcProjectdBDataSet.DataSetName = "ongcProjectdBDataSet";
            this.ongcProjectdBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subbasinBindingSource
            // 
            this.subbasinBindingSource.DataMember = "subbasin";
            this.subbasinBindingSource.DataSource = this.ongcProjectdBDataSet;
            // 
            // subbasinTableAdapter
            // 
            this.subbasinTableAdapter.ClearBeforeFill = true;
            // 
            // subIDDataGridViewTextBoxColumn
            // 
            this.subIDDataGridViewTextBoxColumn.DataPropertyName = "sub_ID";
            this.subIDDataGridViewTextBoxColumn.HeaderText = "sub_ID";
            this.subIDDataGridViewTextBoxColumn.Name = "subIDDataGridViewTextBoxColumn";
            // 
            // subNameDataGridViewTextBoxColumn
            // 
            this.subNameDataGridViewTextBoxColumn.DataPropertyName = "sub_Name";
            this.subNameDataGridViewTextBoxColumn.HeaderText = "sub_Name";
            this.subNameDataGridViewTextBoxColumn.Name = "subNameDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "<<back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // view2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "view2";
            this.Text = "view2";
            this.Load += new System.EventHandler(this.view2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongcProjectdBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subbasinBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ongcProjectdBDataSet ongcProjectdBDataSet;
        private System.Windows.Forms.BindingSource subbasinBindingSource;
        private ongcProjectdBDataSetTableAdapters.subbasinTableAdapter subbasinTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn subIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}