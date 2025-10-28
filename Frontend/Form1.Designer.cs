namespace Tarea4._3_Transaccion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridView1 = new DataGridView();
            txtCode = new TextBox();
            btnDescontinuar = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label1.Location = new Point(307, 71);
            label1.Name = "label1";
            label1.Size = new Size(187, 25);
            label1.TabIndex = 0;
            label1.Text = "Codigo del Producto";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(71, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(637, 256);
            dataGridView1.TabIndex = 1;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(500, 73);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(185, 23);
            txtCode.TabIndex = 2;
            // 
            // btnDescontinuar
            // 
            btnDescontinuar.BackColor = Color.DodgerBlue;
            btnDescontinuar.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDescontinuar.ForeColor = Color.White;
            btnDescontinuar.Location = new Point(307, 377);
            btnDescontinuar.Name = "btnDescontinuar";
            btnDescontinuar.Size = new Size(187, 41);
            btnDescontinuar.TabIndex = 4;
            btnDescontinuar.Text = "Descontinuar";
            btnDescontinuar.UseVisualStyleBackColor = false;
            btnDescontinuar.Click += btnDescontinuar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(226, 9);
            label2.Name = "label2";
            label2.Size = new Size(391, 45);
            label2.TabIndex = 5;
            label2.Text = "Produtos a Descontinuar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(btnDescontinuar);
            Controls.Add(txtCode);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txtCode;
        private Button btnDescontinuar;
        private Label label2;
    }
}
