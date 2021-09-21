namespace MontagemDeHorariosLabs.view
{
    partial class frmRelatorioGrade
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
            this.label1 = new System.Windows.Forms.Label();
            this.anosSemestres = new System.Windows.Forms.ComboBox();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSabado = new System.Windows.Forms.CheckBox();
            this.chkSexta = new System.Windows.Forms.CheckBox();
            this.chkSegunda = new System.Windows.Forms.CheckBox();
            this.chkQuarta = new System.Windows.Forms.CheckBox();
            this.chkQuinta = new System.Windows.Forms.CheckBox();
            this.chkTerca = new System.Windows.Forms.CheckBox();
            this.rbHorario = new System.Windows.Forms.RadioButton();
            this.btnGerar = new System.Windows.Forms.Button();
            this.numerosLabs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHorario = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ano/Semestre:";
            // 
            // anosSemestres
            // 
            this.anosSemestres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.anosSemestres.Enabled = false;
            this.anosSemestres.FormattingEnabled = true;
            this.anosSemestres.Location = new System.Drawing.Point(168, 69);
            this.anosSemestres.Name = "anosSemestres";
            this.anosSemestres.Size = new System.Drawing.Size(134, 21);
            this.anosSemestres.TabIndex = 1;
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTodos.Location = new System.Drawing.Point(80, 25);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(136, 21);
            this.chkTodos.TabIndex = 3;
            this.chkTodos.Text = "Selecionar todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkSabado);
            this.groupBox1.Controls.Add(this.chkSexta);
            this.groupBox1.Controls.Add(this.chkTodos);
            this.groupBox1.Controls.Add(this.chkSegunda);
            this.groupBox1.Controls.Add(this.chkQuarta);
            this.groupBox1.Controls.Add(this.chkQuinta);
            this.groupBox1.Controls.Add(this.chkTerca);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 206);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dias da Semana";
            // 
            // chkSabado
            // 
            this.chkSabado.AutoSize = true;
            this.chkSabado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSabado.Location = new System.Drawing.Point(6, 181);
            this.chkSabado.Name = "chkSabado";
            this.chkSabado.Size = new System.Drawing.Size(71, 20);
            this.chkSabado.TabIndex = 9;
            this.chkSabado.Text = "Sábado";
            this.chkSabado.UseVisualStyleBackColor = true;
            // 
            // chkSexta
            // 
            this.chkSexta.AutoSize = true;
            this.chkSexta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSexta.Location = new System.Drawing.Point(6, 155);
            this.chkSexta.Name = "chkSexta";
            this.chkSexta.Size = new System.Drawing.Size(89, 20);
            this.chkSexta.TabIndex = 8;
            this.chkSexta.Text = "Sexta-feira";
            this.chkSexta.UseVisualStyleBackColor = true;
            // 
            // chkSegunda
            // 
            this.chkSegunda.AutoSize = true;
            this.chkSegunda.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSegunda.Location = new System.Drawing.Point(6, 52);
            this.chkSegunda.Name = "chkSegunda";
            this.chkSegunda.Size = new System.Drawing.Size(106, 20);
            this.chkSegunda.TabIndex = 6;
            this.chkSegunda.Text = "Segunda-feira";
            this.chkSegunda.UseVisualStyleBackColor = true;
            // 
            // chkQuarta
            // 
            this.chkQuarta.AutoSize = true;
            this.chkQuarta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkQuarta.Location = new System.Drawing.Point(6, 103);
            this.chkQuarta.Name = "chkQuarta";
            this.chkQuarta.Size = new System.Drawing.Size(94, 20);
            this.chkQuarta.TabIndex = 7;
            this.chkQuarta.Text = "Quarta-feira";
            this.chkQuarta.UseVisualStyleBackColor = true;
            // 
            // chkQuinta
            // 
            this.chkQuinta.AutoSize = true;
            this.chkQuinta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkQuinta.Location = new System.Drawing.Point(6, 129);
            this.chkQuinta.Name = "chkQuinta";
            this.chkQuinta.Size = new System.Drawing.Size(93, 20);
            this.chkQuinta.TabIndex = 4;
            this.chkQuinta.Text = "Quinta-feira";
            this.chkQuinta.UseVisualStyleBackColor = true;
            // 
            // chkTerca
            // 
            this.chkTerca.AutoSize = true;
            this.chkTerca.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTerca.Location = new System.Drawing.Point(6, 77);
            this.chkTerca.Name = "chkTerca";
            this.chkTerca.Size = new System.Drawing.Size(86, 20);
            this.chkTerca.TabIndex = 5;
            this.chkTerca.Text = "Terça-feira";
            this.chkTerca.UseVisualStyleBackColor = true;
            // 
            // rbHorario
            // 
            this.rbHorario.AutoSize = true;
            this.rbHorario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHorario.Location = new System.Drawing.Point(30, 338);
            this.rbHorario.Name = "rbHorario";
            this.rbHorario.Size = new System.Drawing.Size(165, 22);
            this.rbHorario.TabIndex = 5;
            this.rbHorario.TabStop = true;
            this.rbHorario.Text = "Intervalo de Horário:";
            this.rbHorario.UseVisualStyleBackColor = true;
            this.rbHorario.CheckedChanged += new System.EventHandler(this.rbHorario_CheckedChanged_1);
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(140, 379);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 24);
            this.btnGerar.TabIndex = 7;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click_1);
            // 
            // numerosLabs
            // 
            this.numerosLabs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numerosLabs.FormattingEnabled = true;
            this.numerosLabs.Location = new System.Drawing.Point(168, 23);
            this.numerosLabs.Name = "numerosLabs";
            this.numerosLabs.Size = new System.Drawing.Size(134, 21);
            this.numerosLabs.TabIndex = 9;
            this.numerosLabs.SelectedIndexChanged += new System.EventHandler(this.numerosLabs_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Laboratório:";
            // 
            // cmbHorario
            // 
            this.cmbHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHorario.Enabled = false;
            this.cmbHorario.FormattingEnabled = true;
            this.cmbHorario.Items.AddRange(new object[] {
            "Todos",
            "07:15 - 08:55",
            "08:55 - 10:35",
            "10:50 - 12:30",
            "13:10 - 14:50",
            "14:50 - 16:30"});
            this.cmbHorario.Location = new System.Drawing.Point(196, 338);
            this.cmbHorario.Name = "cmbHorario";
            this.cmbHorario.Size = new System.Drawing.Size(121, 21);
            this.cmbHorario.TabIndex = 11;
            // 
            // frmRelatorioGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 428);
            this.Controls.Add(this.cmbHorario);
            this.Controls.Add(this.numerosLabs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.rbHorario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.anosSemestres);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(365, 466);
            this.MinimumSize = new System.Drawing.Size(365, 466);
            this.Name = "frmRelatorioGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Grade Horária";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox anosSemestres;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkSexta;
        private System.Windows.Forms.CheckBox chkSegunda;
        private System.Windows.Forms.CheckBox chkQuarta;
        private System.Windows.Forms.CheckBox chkQuinta;
        private System.Windows.Forms.CheckBox chkTerca;
        private System.Windows.Forms.RadioButton rbHorario;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.ComboBox numerosLabs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHorario;
        private System.Windows.Forms.CheckBox chkSabado;
    }
}