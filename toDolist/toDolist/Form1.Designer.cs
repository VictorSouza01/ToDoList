﻿namespace toDolist
{
    partial class Janela1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Janela1));
            this.data_grid_view_result = new System.Windows.Forms.DataGridView();
            this.numeroTarefa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarefas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_excluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.selecao = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_item = new System.Windows.Forms.TextBox();
            this.txt_qtd_tarefas = new System.Windows.Forms.Label();
            this.btn_excluir_selecao = new System.Windows.Forms.Button();
            this.btn_excluir_lista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_view_result)).BeginInit();
            this.SuspendLayout();
            // 
            // data_grid_view_result
            // 
            this.data_grid_view_result.AllowUserToAddRows = false;
            this.data_grid_view_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_grid_view_result.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.data_grid_view_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_view_result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroTarefa,
            this.Tarefas,
            this.btn_excluir,
            this.selecao});
            this.data_grid_view_result.Cursor = System.Windows.Forms.Cursors.Hand;
            this.data_grid_view_result.Location = new System.Drawing.Point(12, 120);
            this.data_grid_view_result.Name = "data_grid_view_result";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_grid_view_result.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data_grid_view_result.Size = new System.Drawing.Size(835, 468);
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
            this.Tarefas.ReadOnly = true;
            this.Tarefas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btn_excluir
            // 
            this.btn_excluir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.btn_excluir.HeaderText = "Excluir";
            this.btn_excluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_excluir.Image")));
            this.btn_excluir.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.ReadOnly = true;
            this.btn_excluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_excluir.Width = 44;
            // 
            // selecao
            // 
            this.selecao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.selecao.HeaderText = "Check";
            this.selecao.Name = "selecao";
            this.selecao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.selecao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.selecao.Width = 63;
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
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_save.BackgroundImage")));
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Location = new System.Drawing.Point(809, 13);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(38, 27);
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
            this.txt_qtd_tarefas.Location = new System.Drawing.Point(12, 71);
            this.txt_qtd_tarefas.Name = "txt_qtd_tarefas";
            this.txt_qtd_tarefas.Size = new System.Drawing.Size(412, 23);
            this.txt_qtd_tarefas.TabIndex = 9;
            this.txt_qtd_tarefas.Text = "N°";
            // 
            // btn_excluir_selecao
            // 
            this.btn_excluir_selecao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_excluir_selecao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluir_selecao.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_excluir_selecao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir_selecao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir_selecao.Location = new System.Drawing.Point(686, 87);
            this.btn_excluir_selecao.Name = "btn_excluir_selecao";
            this.btn_excluir_selecao.Size = new System.Drawing.Size(161, 27);
            this.btn_excluir_selecao.TabIndex = 10;
            this.btn_excluir_selecao.Text = "Excluir selecionados";
            this.btn_excluir_selecao.UseVisualStyleBackColor = true;
            this.btn_excluir_selecao.Visible = false;
            this.btn_excluir_selecao.Click += new System.EventHandler(this.btn_excluir_selecao_Click);
            // 
            // btn_excluir_lista
            // 
            this.btn_excluir_lista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_excluir_lista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_excluir_lista.BackgroundImage")));
            this.btn_excluir_lista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_excluir_lista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluir_lista.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_excluir_lista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_excluir_lista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_excluir_lista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir_lista.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir_lista.Location = new System.Drawing.Point(765, 13);
            this.btn_excluir_lista.Name = "btn_excluir_lista";
            this.btn_excluir_lista.Size = new System.Drawing.Size(38, 27);
            this.btn_excluir_lista.TabIndex = 11;
            this.btn_excluir_lista.UseVisualStyleBackColor = true;
            this.btn_excluir_lista.Click += new System.EventHandler(this.btn_excluir_lista_Click);
            // 
            // Janela1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 600);
            this.Controls.Add(this.btn_excluir_lista);
            this.Controls.Add(this.btn_excluir_selecao);
            this.Controls.Add(this.txt_qtd_tarefas);
            this.Controls.Add(this.txt_item);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_grid_view_result);
            this.MinimumSize = new System.Drawing.Size(664, 350);
            this.Name = "Janela1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDo List";
            this.Load += new System.EventHandler(this.Janela1_Load_1);
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
        private System.Windows.Forms.Button btn_excluir_selecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroTarefa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarefas;
        private System.Windows.Forms.DataGridViewImageColumn btn_excluir;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selecao;
        private System.Windows.Forms.Button btn_excluir_lista;
    }
}

