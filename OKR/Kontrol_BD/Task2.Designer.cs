namespace Kontrol_BD
{
    partial class Task2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task2));
            System.Windows.Forms.Label iD_ОзераLabel;
            System.Windows.Forms.Label название_озераLabel;
            System.Windows.Forms.Label районLabel;
            System.Windows.Forms.Label площадьLabel;
            System.Windows.Forms.Label наибольшая_глубинаLabel;
            System.Windows.Forms.Label средняя_глубинаLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.ozera_Var4DataSet = new Kontrol_BD.Ozera_Var4DataSet();
            this.озёраBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.озёраTableAdapter = new Kontrol_BD.Ozera_Var4DataSetTableAdapters.ОзёраTableAdapter();
            this.tableAdapterManager = new Kontrol_BD.Ozera_Var4DataSetTableAdapters.TableAdapterManager();
            this.озёраBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.озёраBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_ОзераTextBox = new System.Windows.Forms.TextBox();
            this.название_озераTextBox = new System.Windows.Forms.TextBox();
            this.районTextBox = new System.Windows.Forms.TextBox();
            this.площадьTextBox = new System.Windows.Forms.TextBox();
            this.наибольшая_глубинаTextBox = new System.Windows.Forms.TextBox();
            this.средняя_глубинаTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            iD_ОзераLabel = new System.Windows.Forms.Label();
            название_озераLabel = new System.Windows.Forms.Label();
            районLabel = new System.Windows.Forms.Label();
            площадьLabel = new System.Windows.Forms.Label();
            наибольшая_глубинаLabel = new System.Windows.Forms.Label();
            средняя_глубинаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ozera_Var4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.озёраBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.озёраBindingNavigator)).BeginInit();
            this.озёраBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица \"Озера\"";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // ozera_Var4DataSet
            // 
            this.ozera_Var4DataSet.DataSetName = "Ozera_Var4DataSet";
            this.ozera_Var4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // озёраBindingNavigator
            // 
            this.озёраBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.озёраBindingNavigator.BindingSource = this.озёраBindingSource;
            this.озёраBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.озёраBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.озёраBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.озёраBindingNavigatorSaveItem});
            this.озёраBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.озёраBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.озёраBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.озёраBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.озёраBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.озёраBindingNavigator.Name = "озёраBindingNavigator";
            this.озёраBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.озёраBindingNavigator.Size = new System.Drawing.Size(341, 25);
            this.озёраBindingNavigator.TabIndex = 6;
            this.озёраBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // озёраBindingNavigatorSaveItem
            // 
            this.озёраBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.озёраBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("озёраBindingNavigatorSaveItem.Image")));
            this.озёраBindingNavigatorSaveItem.Name = "озёраBindingNavigatorSaveItem";
            this.озёраBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.озёраBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.озёраBindingNavigatorSaveItem.Click += new System.EventHandler(this.ОзёраBindingNavigatorSaveItem_Click);
            // 
            // iD_ОзераLabel
            // 
            iD_ОзераLabel.AutoSize = true;
            iD_ОзераLabel.Location = new System.Drawing.Point(18, 101);
            iD_ОзераLabel.Name = "iD_ОзераLabel";
            iD_ОзераLabel.Size = new System.Drawing.Size(56, 13);
            iD_ОзераLabel.TabIndex = 7;
            iD_ОзераLabel.Text = "ID Озера:";
            // 
            // iD_ОзераTextBox
            // 
            this.iD_ОзераTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.озёраBindingSource, "ID Озера", true));
            this.iD_ОзераTextBox.Location = new System.Drawing.Point(141, 98);
            this.iD_ОзераTextBox.Name = "iD_ОзераTextBox";
            this.iD_ОзераTextBox.Size = new System.Drawing.Size(146, 20);
            this.iD_ОзераTextBox.TabIndex = 8;
            // 
            // название_озераLabel
            // 
            название_озераLabel.AutoSize = true;
            название_озераLabel.Location = new System.Drawing.Point(18, 127);
            название_озераLabel.Name = "название_озераLabel";
            название_озераLabel.Size = new System.Drawing.Size(93, 13);
            название_озераLabel.TabIndex = 9;
            название_озераLabel.Text = "Название озера:";
            // 
            // название_озераTextBox
            // 
            this.название_озераTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.озёраBindingSource, "Название озера", true));
            this.название_озераTextBox.Location = new System.Drawing.Point(141, 124);
            this.название_озераTextBox.Name = "название_озераTextBox";
            this.название_озераTextBox.Size = new System.Drawing.Size(146, 20);
            this.название_озераTextBox.TabIndex = 10;
            // 
            // районLabel
            // 
            районLabel.AutoSize = true;
            районLabel.Location = new System.Drawing.Point(18, 153);
            районLabel.Name = "районLabel";
            районLabel.Size = new System.Drawing.Size(41, 13);
            районLabel.TabIndex = 11;
            районLabel.Text = "Район:";
            // 
            // районTextBox
            // 
            this.районTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.озёраBindingSource, "Район", true));
            this.районTextBox.Location = new System.Drawing.Point(141, 150);
            this.районTextBox.Name = "районTextBox";
            this.районTextBox.Size = new System.Drawing.Size(146, 20);
            this.районTextBox.TabIndex = 12;
            // 
            // площадьLabel
            // 
            площадьLabel.AutoSize = true;
            площадьLabel.Location = new System.Drawing.Point(18, 179);
            площадьLabel.Name = "площадьLabel";
            площадьLabel.Size = new System.Drawing.Size(57, 13);
            площадьLabel.TabIndex = 13;
            площадьLabel.Text = "Площадь:";
            // 
            // площадьTextBox
            // 
            this.площадьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.озёраBindingSource, "Площадь", true));
            this.площадьTextBox.Location = new System.Drawing.Point(141, 176);
            this.площадьTextBox.Name = "площадьTextBox";
            this.площадьTextBox.Size = new System.Drawing.Size(146, 20);
            this.площадьTextBox.TabIndex = 14;
            // 
            // наибольшая_глубинаLabel
            // 
            наибольшая_глубинаLabel.AutoSize = true;
            наибольшая_глубинаLabel.Location = new System.Drawing.Point(18, 205);
            наибольшая_глубинаLabel.Name = "наибольшая_глубинаLabel";
            наибольшая_глубинаLabel.Size = new System.Drawing.Size(117, 13);
            наибольшая_глубинаLabel.TabIndex = 15;
            наибольшая_глубинаLabel.Text = "Наибольшая глубина:";
            // 
            // наибольшая_глубинаTextBox
            // 
            this.наибольшая_глубинаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.озёраBindingSource, "Наибольшая глубина", true));
            this.наибольшая_глубинаTextBox.Location = new System.Drawing.Point(141, 202);
            this.наибольшая_глубинаTextBox.Name = "наибольшая_глубинаTextBox";
            this.наибольшая_глубинаTextBox.Size = new System.Drawing.Size(146, 20);
            this.наибольшая_глубинаTextBox.TabIndex = 16;
            // 
            // средняя_глубинаLabel
            // 
            средняя_глубинаLabel.AutoSize = true;
            средняя_глубинаLabel.Location = new System.Drawing.Point(18, 231);
            средняя_глубинаLabel.Name = "средняя_глубинаLabel";
            средняя_глубинаLabel.Size = new System.Drawing.Size(96, 13);
            средняя_глубинаLabel.TabIndex = 17;
            средняя_глубинаLabel.Text = "Средняя глубина:";
            // 
            // средняя_глубинаTextBox
            // 
            this.средняя_глубинаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.озёраBindingSource, "Средняя глубина", true));
            this.средняя_глубинаTextBox.Location = new System.Drawing.Point(141, 228);
            this.средняя_глубинаTextBox.Name = "средняя_глубинаTextBox";
            this.средняя_глубинаTextBox.Size = new System.Drawing.Size(146, 20);
            this.средняя_глубинаTextBox.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 349);
            this.Controls.Add(this.button1);
            this.Controls.Add(iD_ОзераLabel);
            this.Controls.Add(this.iD_ОзераTextBox);
            this.Controls.Add(название_озераLabel);
            this.Controls.Add(this.название_озераTextBox);
            this.Controls.Add(районLabel);
            this.Controls.Add(this.районTextBox);
            this.Controls.Add(площадьLabel);
            this.Controls.Add(this.площадьTextBox);
            this.Controls.Add(наибольшая_глубинаLabel);
            this.Controls.Add(this.наибольшая_глубинаTextBox);
            this.Controls.Add(средняя_глубинаLabel);
            this.Controls.Add(this.средняя_глубинаTextBox);
            this.Controls.Add(this.озёраBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Task2";
            this.Text = "Task2";
            this.Load += new System.EventHandler(this.Task2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ozera_Var4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.озёраBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.озёраBindingNavigator)).EndInit();
            this.озёраBindingNavigator.ResumeLayout(false);
            this.озёраBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Ozera_Var4DataSet ozera_Var4DataSet;
        private System.Windows.Forms.BindingSource озёраBindingSource;
        private Ozera_Var4DataSetTableAdapters.ОзёраTableAdapter озёраTableAdapter;
        private Ozera_Var4DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator озёраBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton озёраBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_ОзераTextBox;
        private System.Windows.Forms.TextBox название_озераTextBox;
        private System.Windows.Forms.TextBox районTextBox;
        private System.Windows.Forms.TextBox площадьTextBox;
        private System.Windows.Forms.TextBox наибольшая_глубинаTextBox;
        private System.Windows.Forms.TextBox средняя_глубинаTextBox;
        private System.Windows.Forms.Button button1;
    }
}