namespace MontagemDeHorariosLabs.view
{
    partial class frmConsultaGradeHorarioVigente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvGradeHoraria = new System.Windows.Forms.DataGridView();
            this.colHorarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSegunda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTerca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuarta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuinta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSexta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSabado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaHorarioslbl = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.barraPadrao = new System.Windows.Forms.ToolStrip();
            this.btnBarraMudarGHV = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradeHoraria)).BeginInit();
            this.barraPadrao.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGradeHoraria
            // 
            this.dgvGradeHoraria.AllowUserToAddRows = false;
            this.dgvGradeHoraria.AllowUserToDeleteRows = false;
            this.dgvGradeHoraria.AllowUserToResizeColumns = false;
            this.dgvGradeHoraria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGradeHoraria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGradeHoraria.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGradeHoraria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGradeHoraria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHorarios,
            this.colSegunda,
            this.colTerca,
            this.colQuarta,
            this.colQuinta,
            this.colSexta,
            this.colSabado});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGradeHoraria.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvGradeHoraria.Location = new System.Drawing.Point(43, 79);
            this.dgvGradeHoraria.Name = "dgvGradeHoraria";
            this.dgvGradeHoraria.ReadOnly = true;
            this.dgvGradeHoraria.RowHeadersVisible = false;
            this.dgvGradeHoraria.Size = new System.Drawing.Size(947, 286);
            this.dgvGradeHoraria.TabIndex = 3;
            this.dgvGradeHoraria.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGradeHoraria_CellDoubleClick);
            // 
            // colHorarios
            // 
            this.colHorarios.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.colHorarios.DefaultCellStyle = dataGridViewCellStyle1;
            this.colHorarios.HeaderText = "Horários";
            this.colHorarios.Name = "colHorarios";
            this.colHorarios.ReadOnly = true;
            this.colHorarios.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSegunda
            // 
            this.colSegunda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colSegunda.DefaultCellStyle = dataGridViewCellStyle2;
            this.colSegunda.HeaderText = "Segunda";
            this.colSegunda.Name = "colSegunda";
            this.colSegunda.ReadOnly = true;
            this.colSegunda.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTerca
            // 
            this.colTerca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colTerca.DefaultCellStyle = dataGridViewCellStyle3;
            this.colTerca.HeaderText = "Terça";
            this.colTerca.Name = "colTerca";
            this.colTerca.ReadOnly = true;
            this.colTerca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colQuarta
            // 
            this.colQuarta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colQuarta.DefaultCellStyle = dataGridViewCellStyle4;
            this.colQuarta.HeaderText = "Quarta";
            this.colQuarta.Name = "colQuarta";
            this.colQuarta.ReadOnly = true;
            this.colQuarta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colQuinta
            // 
            this.colQuinta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colQuinta.DefaultCellStyle = dataGridViewCellStyle5;
            this.colQuinta.HeaderText = "Quinta";
            this.colQuinta.Name = "colQuinta";
            this.colQuinta.ReadOnly = true;
            this.colQuinta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSexta
            // 
            this.colSexta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colSexta.DefaultCellStyle = dataGridViewCellStyle6;
            this.colSexta.HeaderText = "Sexta";
            this.colSexta.Name = "colSexta";
            this.colSexta.ReadOnly = true;
            this.colSexta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSabado
            // 
            this.colSabado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colSabado.DefaultCellStyle = dataGridViewCellStyle7;
            this.colSabado.HeaderText = "Sábado";
            this.colSabado.Name = "colSabado";
            this.colSabado.ReadOnly = true;
            this.colSabado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // listaHorarioslbl
            // 
            this.listaHorarioslbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listaHorarioslbl.AutoSize = true;
            this.listaHorarioslbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaHorarioslbl.Location = new System.Drawing.Point(413, 34);
            this.listaHorarioslbl.Name = "listaHorarioslbl";
            this.listaHorarioslbl.Size = new System.Drawing.Size(236, 18);
            this.listaHorarioslbl.TabIndex = 2;
            this.listaHorarioslbl.Text = "Lista de Horários [Laboratório X]";
            // 
            // btnListar
            // 
            this.btnListar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(468, 389);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(93, 28);
            this.btnListar.TabIndex = 16;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // barraPadrao
            // 
            this.barraPadrao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBarraMudarGHV});
            this.barraPadrao.Location = new System.Drawing.Point(0, 0);
            this.barraPadrao.Name = "barraPadrao";
            this.barraPadrao.Size = new System.Drawing.Size(1030, 25);
            this.barraPadrao.TabIndex = 18;
            this.barraPadrao.Text = "barraPadrao";
            // 
            // btnBarraMudarGHV
            // 
            this.btnBarraMudarGHV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBarraMudarGHV.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarraMudarGHV.Image = global::MontagemDeHorariosLabs.Properties.Resources.History_32;
            this.btnBarraMudarGHV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBarraMudarGHV.Name = "btnBarraMudarGHV";
            this.btnBarraMudarGHV.Size = new System.Drawing.Size(23, 22);
            this.btnBarraMudarGHV.Text = "btnBarraPadrao";
            this.btnBarraMudarGHV.ToolTipText = "Clique aqui para mudar a grade horária em vigência.";
            this.btnBarraMudarGHV.Click += new System.EventHandler(this.btnBarraMudarGHV_Click);
            // 
            // frmConsultaGradeHorarioVigente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 442);
            this.Controls.Add(this.barraPadrao);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvGradeHoraria);
            this.Controls.Add(this.listaHorarioslbl);
            this.Name = "frmConsultaGradeHorarioVigente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Grade Horária";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradeHoraria)).EndInit();
            this.barraPadrao.ResumeLayout(false);
            this.barraPadrao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGradeHoraria;
        private System.Windows.Forms.Label listaHorarioslbl;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHorarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSegunda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTerca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuarta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuinta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSexta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSabado;
        private System.Windows.Forms.ToolStrip barraPadrao;
        private System.Windows.Forms.ToolStripButton btnBarraMudarGHV;
    }
}