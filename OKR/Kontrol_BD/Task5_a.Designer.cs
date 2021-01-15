namespace Kontrol_BD
{
    partial class Task5_a
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
            this.ozera_Var4DataSet1 = new Kontrol_BD.Ozera_Var4DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.названиеОзераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.районDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наибольшаяГлубинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.озёраBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ozeraVar4DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.озёраTableAdapter = new Kontrol_BD.Ozera_Var4DataSetTableAdapters.ОзёраTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ozera_Var4DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.озёраBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ozeraVar4DataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ozera_Var4DataSet1
            // 
            this.ozera_Var4DataSet1.DataSetName = "Ozera_Var4DataSet";
            this.ozera_Var4DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиеОзераDataGridViewTextBoxColumn,
            this.районDataGridViewTextBoxColumn,
            this.наибольшаяГлубинаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.озёраBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 213);
            this.dataGridView1.TabIndex = 0;
            // 
            // названиеОзераDataGridViewTextBoxColumn
            // 
            this.названиеОзераDataGridViewTextBoxColumn.DataPropertyName = "Название озера";
            this.названиеОзераDataGridViewTextBoxColumn.HeaderText = "Название озера";
            this.названиеОзераDataGridViewTextBoxColumn.Name = "названиеОзераDataGridViewTextBoxColumn";
            // 
            // районDataGridViewTextBoxColumn
            // 
            this.районDataGridViewTextBoxColumn.DataPropertyName = "Район";
            this.районDataGridViewTextBoxColumn.HeaderText = "Район";
            this.районDataGridViewTextBoxColumn.Name = "районDataGridViewTextBoxColumn";
            // 
            // наибольшаяГлубинаDataGridViewTextBoxColumn
            // 
            this.наибольшаяГлубинаDataGridViewTextBoxColumn.DataPropertyName = "Наибольшая глубина";
            this.наибольшаяГлубинаDataGridViewTextBoxColumn.HeaderText = "Наибольшая глубина";
            this.наибольшаяГлубинаDataGridViewTextBoxColumn.Name = "наибольшаяГлубинаDataGridViewTextBoxColumn";
            // 
            // озёраBindingSource
            // 
            this.озёраBindingSource.DataMember = "Озёра";
            this.озёраBindingSource.DataSource = this.ozeraVar4DataSet1BindingSource;
            // 
            // ozeraVar4DataSet1BindingSource
            // 
            this.ozeraVar4DataSet1BindingSource.DataSource = this.ozera_Var4DataSet1;
            this.ozeraVar4DataSet1BindingSource.Position = 0;
            // 
            // озёраTableAdapter
            // 
            this.озёраTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Task5_a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 278);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Task5_a";
            this.Text = "Task5_a";
            this.Load += new System.EventHandler(this.Task5_a_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ozera_Var4DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.озёраBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ozeraVar4DataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Ozera_Var4DataSet ozera_Var4DataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ozeraVar4DataSet1BindingSource;
        private System.Windows.Forms.BindingSource озёраBindingSource;
        private Ozera_Var4DataSetTableAdapters.ОзёраTableAdapter озёраTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеОзераDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn районDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наибольшаяГлубинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}