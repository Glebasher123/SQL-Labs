namespace Kontrol_BD
{
    partial class Task4
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
            this.ozera_Var4DataSet = new Kontrol_BD.Ozera_Var4DataSet();
            this.ozeraVar4DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ozera_Var4DataSet1 = new Kontrol_BD.Ozera_Var4DataSet();
            this.озёраBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.озёраTableAdapter = new Kontrol_BD.Ozera_Var4DataSetTableAdapters.ОзёраTableAdapter();
            this.tableAdapterManager = new Kontrol_BD.Ozera_Var4DataSetTableAdapters.TableAdapterManager();
            this.озёраDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ozera_Var4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ozeraVar4DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ozera_Var4DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.озёраBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.озёраDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // ozera_Var4DataSet1
            // 
            this.ozera_Var4DataSet1.DataSetName = "Ozera_Var4DataSet";
            this.ozera_Var4DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // озёраBindingSource
            // 
            this.озёраBindingSource.DataMember = "Озёра";
            this.озёраBindingSource.DataSource = this.ozera_Var4DataSet;
            // 
            // озёраTableAdapter
            // 
            this.озёраTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Kontrol_BD.Ozera_Var4DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ОзёраTableAdapter = this.озёраTableAdapter;
            // 
            // озёраDataGridView
            // 
            this.озёраDataGridView.AutoGenerateColumns = false;
            this.озёраDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.озёраDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.озёраDataGridView.DataSource = this.озёраBindingSource;
            this.озёраDataGridView.Location = new System.Drawing.Point(2, 3);
            this.озёраDataGridView.Name = "озёраDataGridView";
            this.озёраDataGridView.Size = new System.Drawing.Size(635, 268);
            this.озёраDataGridView.TabIndex = 0;
            this.озёраDataGridView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ОзёраDataGridView_MouseUp);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID Озера";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Озера";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Название озера";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название озера";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Район";
            this.dataGridViewTextBoxColumn3.HeaderText = "Район";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Площадь";
            this.dataGridViewTextBoxColumn4.HeaderText = "Площадь";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Наибольшая глубина";
            this.dataGridViewTextBoxColumn5.HeaderText = "Наибольшая глубина";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Средняя глубина";
            this.dataGridViewTextBoxColumn6.HeaderText = "Средняя глубина";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(267, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Task4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 338);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.озёраDataGridView);
            this.Name = "Task4";
            this.Text = "Task4";
            this.Load += new System.EventHandler(this.Task4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ozera_Var4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ozeraVar4DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ozera_Var4DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.озёраBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.озёраDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource ozeraVar4DataSetBindingSource;
        private Ozera_Var4DataSet ozera_Var4DataSet;
        private Ozera_Var4DataSet ozera_Var4DataSet1;
        private System.Windows.Forms.BindingSource озёраBindingSource;
        private Ozera_Var4DataSetTableAdapters.ОзёраTableAdapter озёраTableAdapter;
        private Ozera_Var4DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView озёраDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}