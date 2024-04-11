namespace Projeto_Estante_Virtual
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHome = new System.Windows.Forms.Panel();
            this.btQueroLer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btFavoritos = new System.Windows.Forms.Button();
            this.btAbandonados = new System.Windows.Forms.Button();
            this.btLidos = new System.Windows.Forms.Button();
            this.btLendo = new System.Windows.Forms.Button();
            this.btLivros = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelForm = new System.Windows.Forms.Panel();
            this.DTLivro = new System.Windows.Forms.DataGridView();
            this.btRemover = new System.Windows.Forms.Button();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.White;
            this.panelHome.Controls.Add(this.btQueroLer);
            this.panelHome.Controls.Add(this.panel2);
            this.panelHome.Controls.Add(this.btAdicionar);
            this.panelHome.Controls.Add(this.btFavoritos);
            this.panelHome.Controls.Add(this.btAbandonados);
            this.panelHome.Controls.Add(this.btLidos);
            this.panelHome.Controls.Add(this.btLendo);
            this.panelHome.Controls.Add(this.btLivros);
            this.panelHome.Controls.Add(this.pictureBox1);
            this.panelHome.Location = new System.Drawing.Point(0, 1);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(187, 679);
            this.panelHome.TabIndex = 0;
            // 
            // btQueroLer
            // 
            this.btQueroLer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btQueroLer.FlatAppearance.BorderSize = 0;
            this.btQueroLer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btQueroLer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQueroLer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btQueroLer.Location = new System.Drawing.Point(3, 530);
            this.btQueroLer.Name = "btQueroLer";
            this.btQueroLer.Size = new System.Drawing.Size(180, 76);
            this.btQueroLer.TabIndex = 8;
            this.btQueroLer.Text = "QUERO LER";
            this.btQueroLer.UseVisualStyleBackColor = true;
            this.btQueroLer.Click += new System.EventHandler(this.btQueroLer_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(189, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 669);
            this.panel2.TabIndex = 7;
            // 
            // btAdicionar
            // 
            this.btAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btAdicionar.FlatAppearance.BorderSize = 0;
            this.btAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btAdicionar.Location = new System.Drawing.Point(3, 600);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(180, 76);
            this.btAdicionar.TabIndex = 6;
            this.btAdicionar.Text = "ADICIONAR LIVRO";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btFavoritos
            // 
            this.btFavoritos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btFavoritos.FlatAppearance.BorderSize = 0;
            this.btFavoritos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btFavoritos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFavoritos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btFavoritos.Location = new System.Drawing.Point(4, 448);
            this.btFavoritos.Name = "btFavoritos";
            this.btFavoritos.Size = new System.Drawing.Size(180, 76);
            this.btFavoritos.TabIndex = 5;
            this.btFavoritos.Text = "FAVORITOS";
            this.btFavoritos.UseVisualStyleBackColor = true;
            this.btFavoritos.Click += new System.EventHandler(this.btFavoritos_Click);
            // 
            // btAbandonados
            // 
            this.btAbandonados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btAbandonados.FlatAppearance.BorderSize = 0;
            this.btAbandonados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btAbandonados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAbandonados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btAbandonados.Location = new System.Drawing.Point(3, 366);
            this.btAbandonados.Name = "btAbandonados";
            this.btAbandonados.Size = new System.Drawing.Size(180, 76);
            this.btAbandonados.TabIndex = 4;
            this.btAbandonados.Text = "ABANDONADOS";
            this.btAbandonados.UseVisualStyleBackColor = true;
            this.btAbandonados.Click += new System.EventHandler(this.btAbandonados_Click);
            // 
            // btLidos
            // 
            this.btLidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btLidos.FlatAppearance.BorderSize = 0;
            this.btLidos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btLidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btLidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btLidos.Location = new System.Drawing.Point(3, 284);
            this.btLidos.Name = "btLidos";
            this.btLidos.Size = new System.Drawing.Size(180, 76);
            this.btLidos.TabIndex = 3;
            this.btLidos.Text = "LIDOS";
            this.btLidos.UseVisualStyleBackColor = true;
            this.btLidos.Click += new System.EventHandler(this.btLidos_Click);
            // 
            // btLendo
            // 
            this.btLendo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btLendo.FlatAppearance.BorderSize = 0;
            this.btLendo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btLendo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLendo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btLendo.Location = new System.Drawing.Point(3, 202);
            this.btLendo.Name = "btLendo";
            this.btLendo.Size = new System.Drawing.Size(180, 76);
            this.btLendo.TabIndex = 2;
            this.btLendo.Text = "LENDO";
            this.btLendo.UseVisualStyleBackColor = true;
            this.btLendo.Click += new System.EventHandler(this.btLendo_Click);
            // 
            // btLivros
            // 
            this.btLivros.BackColor = System.Drawing.Color.Transparent;
            this.btLivros.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btLivros.FlatAppearance.BorderSize = 0;
            this.btLivros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btLivros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btLivros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btLivros.Location = new System.Drawing.Point(3, 120);
            this.btLivros.Name = "btLivros";
            this.btLivros.Size = new System.Drawing.Size(181, 76);
            this.btLivros.TabIndex = 1;
            this.btLivros.Text = "TODOS OS LIVROS";
            this.btLivros.UseVisualStyleBackColor = false;
            this.btLivros.Click += new System.EventHandler(this.btLivros_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.DTLivro);
            this.panelForm.Controls.Add(this.btRemover);
            this.panelForm.Location = new System.Drawing.Point(189, 2);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(871, 670);
            this.panelForm.TabIndex = 1;
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
            this.DTLivro.TabIndex = 21;
            this.DTLivro.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTLivro_RowEnter);
            // 
            // btRemover
            // 
            this.btRemover.BackColor = System.Drawing.Color.Silver;
            this.btRemover.FlatAppearance.BorderSize = 0;
            this.btRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btRemover.Location = new System.Drawing.Point(705, 612);
            this.btRemover.Margin = new System.Windows.Forms.Padding(0);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(159, 49);
            this.btRemover.TabIndex = 20;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = false;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelHome);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Shown += new System.EventHandler(this.Home_Shown);
            this.panelHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DTLivro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelHome;
        private PictureBox pictureBox1;
        private Button btLivros;
        private Button btFavoritos;
        private Button btAbandonados;
        private Button btLidos;
        private Button btLendo;
        private Button btAdicionar;
        private Panel panel2;
        private Panel panelForm;
        private Button btRemover;
        private DataGridView DTLivro;
        private Button btQueroLer;
    }
}