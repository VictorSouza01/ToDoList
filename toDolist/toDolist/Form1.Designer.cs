namespace toDolist
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.data_grid_view_result = new System.Windows.Forms.DataGridView();
            this.numeroTarefa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarefas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.Concluir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_item = new System.Windows.Forms.TextBox();
            this.txt_qtd_tarefas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_view_result)).BeginInit();
            this.SuspendLayout();
            // 
            // data_grid_view_result
            // 
            this.data_grid_view_result.AllowUserToAddRows = false;
            this.data_grid_view_result.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.data_grid_view_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_view_result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroTarefa,
            this.Tarefas,
            this.excluir,
            this.Concluir});
            this.data_grid_view_result.Cursor = System.Windows.Forms.Cursors.Hand;
            this.data_grid_view_result.Location = new System.Drawing.Point(12, 120);
            this.data_grid_view_result.Name = "data_grid_view_result";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_grid_view_result.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data_grid_view_result.Size = new System.Drawing.Size(735, 468);
            this.data_grid_view_result.TabIndex = 4;
            this.data_grid_view_result.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_grid_view_result_CellContentClick);
            // 
            // numeroTarefa
            // 
            this.numeroTarefa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.numeroTarefa.HeaderText = "N°";
            this.numeroTarefa.Name = "numeroTarefa";
            this.numeroTarefa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.numeroTarefa.Visible = false;
            // 
            // Tarefas
            // 
            this.Tarefas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tarefas.HeaderText = "Tarefas";
            this.Tarefas.Name = "Tarefas";
            this.Tarefas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // excluir
            // 
            this.excluir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.excluir.HeaderText = "Excluir";
            this.excluir.Image = ((System.Drawing.Image)(resources.GetObject("excluir.Image")));
            this.excluir.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.excluir.Name = "excluir";
            this.excluir.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.excluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.excluir.Width = 63;
            // 
            // Concluir
            // 
            this.Concluir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Concluir.HeaderText = "Check";
            this.Concluir.Name = "Concluir";
            this.Concluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Concluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Concluir.Width = 63;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "TAREFAS:";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_add.Location = new System.Drawing.Point(430, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(115, 27);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "ADICIONAR";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_save.BackgroundImage")));
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Location = new System.Drawing.Point(715, 13);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(32, 27);
            this.btn_save.TabIndex = 7;
            this.btn_save.Tag = "SAVE";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_item
            // 
            this.txt_item.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_item.Location = new System.Drawing.Point(16, 13);
            this.txt_item.Name = "txt_item";
            this.txt_item.Size = new System.Drawing.Size(408, 26);
            this.txt_item.TabIndex = 8;
            this.txt_item.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_item_KeyUp);
            // 
            // txt_qtd_tarefas
            // 
            this.txt_qtd_tarefas.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qtd_tarefas.Location = new System.Drawing.Point(551, 16);
            this.txt_qtd_tarefas.Name = "txt_qtd_tarefas";
            this.txt_qtd_tarefas.Size = new System.Drawing.Size(79, 23);
            this.txt_qtd_tarefas.TabIndex = 9;
            this.txt_qtd_tarefas.Text = "N°";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 600);
            this.Controls.Add(this.txt_qtd_tarefas);
            this.Controls.Add(this.txt_item);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_grid_view_result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDo List";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_view_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_grid_view_result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_item;
        private System.Windows.Forms.Label txt_qtd_tarefas;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroTarefa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarefas;
        private System.Windows.Forms.DataGridViewImageColumn excluir;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Concluir;
    }
}

