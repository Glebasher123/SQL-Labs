namespace Kontrol_BD
{
    partial class Task3
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RaionBox = new System.Windows.Forms.TextBox();
            this.SquareBox = new System.Windows.Forms.TextBox();
            this.MaxDepthBox = new System.Windows.Forms.TextBox();
            this.AverageDepthBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(154, 72);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(122, 20);
            this.NameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(71, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавить озеро";
            // 
            // RaionBox
            // 
            this.RaionBox.Location = new System.Drawing.Point(154, 98);
            this.RaionBox.Name = "RaionBox";
            this.RaionBox.Size = new System.Drawing.Size(122, 20);
            this.RaionBox.TabIndex = 2;
            // 
            // SquareBox
            // 
            this.SquareBox.Location = new System.Drawing.Point(154, 124);
            this.SquareBox.Name = "SquareBox";
            this.SquareBox.Size = new System.Drawing.Size(122, 20);
            this.SquareBox.TabIndex = 3;
            // 
            // MaxDepthBox
            // 
            this.MaxDepthBox.Location = new System.Drawing.Point(154, 150);
            this.MaxDepthBox.Name = "MaxDepthBox";
            this.MaxDepthBox.Size = new System.Drawing.Size(122, 20);
            this.MaxDepthBox.TabIndex = 4;
            // 
            // AverageDepthBox
            // 
            this.AverageDepthBox.Location = new System.Drawing.Point(154, 176);
            this.AverageDepthBox.Name = "AverageDepthBox";
            this.AverageDepthBox.Size = new System.Drawing.Size(122, 20);
            this.AverageDepthBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(109, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Название озера";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Район";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Площадь";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Наибольшая глубина";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Средняя глубина";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(2, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Task3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 311);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AverageDepthBox);
            this.Controls.Add(this.MaxDepthBox);
            this.Controls.Add(this.SquareBox);
            this.Controls.Add(this.RaionBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameBox);
            this.Name = "Task3";
            this.Text = "Task3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RaionBox;
        private System.Windows.Forms.TextBox SquareBox;
        private System.Windows.Forms.TextBox MaxDepthBox;
        private System.Windows.Forms.TextBox AverageDepthBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
    }
}