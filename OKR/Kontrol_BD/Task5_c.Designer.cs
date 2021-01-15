namespace Kontrol_BD
{
    partial class Task5_c
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
            this.названиеОзераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.площадьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.средняяГлубинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.озёраBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ozera_Var4DataSet = new Kontrol_BD.Ozera_Var4DataSet();
            this.ozeraVar4DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.озёраTableAdapter = new Kontrol_BD.Ozera_Var4DataSetTableAdapters.ОзёраTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.озёраBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ozera_Var4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ozeraVar4DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиеОзераDataGridViewTextBoxColumn,
            this.площадьDataGridViewTextBoxColumn,
            this.средняяГлубинаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.озёраBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 203);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DataGridView1_MouseUp);
            // 
            // названиеОзераDataGridViewTextBoxColumn
            // 
            this.названиеОзераDataGridViewTextBoxColumn.DataPropertyName = "Название озера";
            this.названиеОзераDataGridViewTextBoxColumn.HeaderText = "Название озера";
            this.названиеОзераDataGridViewTextBoxColumn.Name = "названиеОзераDataGridViewTextBoxColumn";
            // 
            // площадьDataGridViewTextBoxColumn
            // 
            this.площадьDataGridViewTextBoxColumn.DataPropertyName = "Площадь";
            this.площадьDataGridViewTextBoxColumn.HeaderText = "Площадь";
            this.площадьDataGridViewTextBoxColumn.Name = "площадьDataGridViewTextBoxColumn";
            // 
            // средняяГлубинаDataGridViewTextBoxColumn
            // 
            this.средняяГлубинаDataGridViewTextBoxColumn.DataPropertyName = "Средняя глубина";
            this.средняяГлубинаDataGridViewTextBoxColumn.HeaderText = "Средняя глубина";
            this.средняяГлубинаDataGridViewTextBoxColumn.Name = "средняяГлубинаDataGridViewTextBoxColumn";
            // 
            // озёраBindingSource
            // 
            this.озёраBindingSource.DataMember = "Озёра";
            this.озёраBindingSource.DataSource = this.ozera_Var4DataSet;
            // 
            // ozera_Var4DataSet
            // 
            this.ozera_Var4DataSet.DataSetName = "Ozera_Var4DataSet";
            this.ozera_Var4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ozeraVar4DataSetBindingSource
            // 
            this.ozeraVar4DataSetBindingSource.DataSource = this.ozera_Var4DataSet;
            this.ozeraVar4DataSetBindingSource.Position = 0;
            // 
            // озёраTableAdapter
            // 
            this.озёраTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 230);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(210, 230);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Диапазон от";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "до";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Task5_c
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 307);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Task5_c";
            this.Text = "Task5_c";
            this.Load += new System.EventHandler(this.Task5_c_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.озёраBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ozera_Var4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ozeraVar4DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ozeraVar4DataSetBindingSource;
        private Ozera_Var4DataSet ozera_Var4DataSet;
        private System.Windows.Forms.BindingSource озёраBindingSource;
        private Ozera_Var4DataSetTableAdapters.ОзёраTableAdapter озёраTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеОзераDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn площадьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn средняяГлубинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}