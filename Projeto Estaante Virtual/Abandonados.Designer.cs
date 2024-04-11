namespace Projeto_Estante_Virtual
{
    partial class Abandonados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DTLivro = new System.Windows.Forms.DataGridView();
            this.btRemover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // DTLivro
            // 
            this.DTLivro.AllowUserToAddRows = false;
            this.DTLivro.AllowUserToDeleteRows = false;
            this.DTLivro.AllowUserToResizeColumns = false;
            this.DTLivro.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.DTLivro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DTLivro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTLivro.BackgroundColor = System.Drawing.Color.LightGray;
            this.DTLivro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTLivro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DTLivro.ColumnHeadersHeight = 35;
            this.DTLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DTLivro.DefaultCellStyle = dataGridViewCellStyle3;
            this.DTLivro.Location = new System.Drawing.Point(3, -1);
            this.DTLivro.Name = "DTLivro";
            this.DTLivro.ReadOnly = true;
            this.DTLivro.RowHeadersWidth = 60;
            this.DTLivro.RowTemplate.Height = 29;
            this.DTLivro.Size = new System.Drawing.Size(867, 530);
            this.DTLivro.TabIndex = 22;
            this.DTLivro.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTLivro_RowEnter_1);
            // 
            // btRemover
            // 
            this.btRemover.BackColor = System.Drawing.Color.Silver;
            this.btRemover.FlatAppearance.BorderSize = 0;
            this.btRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btRemover.Location = new System.Drawing.Point(703, 612);
            this.btRemover.Margin = new System.Windows.Forms.Padding(0);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(159, 49);
            this.btRemover.TabIndex = 23;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = false;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click_1);
            // 
            // Abandonados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(871, 670);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.DTLivro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Abandonados";
            this.Text = "Abandonados";
            this.Shown += new System.EventHandler(this.Abandonados_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DTLivro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView DTLivro;
        private Button btRemover;
    }
}