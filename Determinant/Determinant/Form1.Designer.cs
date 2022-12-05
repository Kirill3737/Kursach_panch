namespace Determinant
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.initial_DGV = new System.Windows.Forms.DataGridView();
            this.random_radioButton = new System.Windows.Forms.RadioButton();
            this.manual_radioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initial_DGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(12, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 35);
            this.button1.TabIndex = 17;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(111, 14);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(180, 26);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 419);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Размер:";
            // 
            // initial_DGV
            // 
            this.initial_DGV.AllowUserToAddRows = false;
            this.initial_DGV.AllowUserToDeleteRows = false;
            this.initial_DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.initial_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.initial_DGV.ColumnHeadersVisible = false;
            this.initial_DGV.Location = new System.Drawing.Point(13, 122);
            this.initial_DGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.initial_DGV.Name = "initial_DGV";
            this.initial_DGV.ReadOnly = true;
            this.initial_DGV.RowHeadersVisible = false;
            this.initial_DGV.RowHeadersWidth = 51;
            this.initial_DGV.RowTemplate.Height = 24;
            this.initial_DGV.Size = new System.Drawing.Size(506, 292);
            this.initial_DGV.TabIndex = 12;
            this.initial_DGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.initial_DGV_CellValueChanged);
            this.initial_DGV.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.initial_DGV_EditingControlShowing);
            this.initial_DGV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.initial_DGV_KeyPress);
            // 
            // random_radioButton
            // 
            this.random_radioButton.AutoSize = true;
            this.random_radioButton.Checked = true;
            this.random_radioButton.Location = new System.Drawing.Point(6, 29);
            this.random_radioButton.Name = "random_radioButton";
            this.random_radioButton.Size = new System.Drawing.Size(97, 24);
            this.random_radioButton.TabIndex = 9;
            this.random_radioButton.TabStop = true;
            this.random_radioButton.Text = "случайно";
            this.random_radioButton.UseVisualStyleBackColor = true;
            this.random_radioButton.CheckedChanged += new System.EventHandler(this.random_radioButton_CheckedChanged);
            // 
            // manual_radioButton
            // 
            this.manual_radioButton.AutoSize = true;
            this.manual_radioButton.Location = new System.Drawing.Point(6, 64);
            this.manual_radioButton.Name = "manual_radioButton";
            this.manual_radioButton.Size = new System.Drawing.Size(89, 24);
            this.manual_radioButton.TabIndex = 10;
            this.manual_radioButton.Text = "вручную";
            this.manual_radioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.random_radioButton);
            this.groupBox1.Controls.Add(this.manual_radioButton);
            this.groupBox1.Location = new System.Drawing.Point(298, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.initial_DGV);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Вычисление определителя матрицы N*N";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initial_DGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView initial_DGV;
        private System.Windows.Forms.RadioButton random_radioButton;
        private System.Windows.Forms.RadioButton manual_radioButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

