using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MontagemDeHorariosLabs.dao;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace MontagemDeHorariosLabs.view
{
    public partial class frmRelatorioGrade : Form
    {
        public frmRelatorioGrade()
        {
            InitializeComponent();
            montarPreRequisitosRelatorio();
        }

        private void montarPreRequisitosRelatorio()
        {
            DaoLaboratorio daoLab = new DaoLaboratorio();
            List<Laboratorio> labs = daoLab.buscarLaboratoriosBD(-1);

            int[] numeros = new int[labs.Count];
            int i = 0;

            foreach (Laboratorio lab in labs)
            {
                numeros[i] = lab.getNumero();
                i++;
            }

            for (int j = 0; j < numeros.Length; j++)
            {
                numerosLabs.Items.Add(numeros[j]);
            }

            cmbHorario.SelectedIndex = 0;
        }

        private void rbHorario_CheckedChanged_1(object sender, EventArgs e)
        {
            cmbHorario.Enabled = true;
        }

        private void btnGerar_Click_1(object sender, EventArgs e)
        {
            DaoLaboratorio daoLab = new DaoLaboratorio();
            DaoGradeHoraria daoGH = new DaoGradeHoraria();

            int numeroLaboratorio;
            string anoSemestre;

            if (numerosLabs.SelectedItem == null || anosSemestres.SelectedItem == null)
            {
                MessageBox.Show("Selecione o ano/Semestre e/ou o número do laboratório", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                numeroLaboratorio = Int32.Parse(numerosLabs.SelectedItem.ToString());
                anoSemestre = anosSemestres.SelectedItem.ToString();
            }

            GradeHoraria grade = daoGH.buscarGradeHoraria(numeroLaboratorio, anoSemestre);
            List<Horario> horarios = grade.GetListaHorarios();

            int quantDias = 0;
            List<string> dias = new List<string>();
            string diasSelecionados = "";

            if (chkSegunda.Checked)
            {
                quantDias++;
                dias.Add("Segunda");
                diasSelecionados += "Segunda-Feira";
            }

            if (chkTerca.Checked)
            {
                if (quantDias > 0)
                {
                    diasSelecionados += ", Terça-Feira";
                }
                else
                {
                    diasSelecionados += "Terça-Feira";
                }
                quantDias++;
                dias.Add("Terça");
            }

            if (chkQuarta.Checked)
            {
                if (quantDias > 0)
                {
                    diasSelecionados += ", Quarta-Feira";
                }
                else
                {
                    diasSelecionados += "Quarta-Feira";
                }
                quantDias++;
                dias.Add("Quarta");
            }

            if (chkQuinta.Checked)
            {
                if (quantDias > 0)
                {
                    diasSelecionados += ", Quinta-Feira";
                }
                else
                {
                    diasSelecionados += "Quinta-Feira";
                }
                quantDias++;
                dias.Add("Quinta");
            }

            if (chkSexta.Checked)
            {
                if (quantDias > 0)
                {
                    diasSelecionados += ", Sexta-Feira";
                }
                else
                {
                    diasSelecionados += "Sexta-Feira";
                }
                quantDias++;
                dias.Add("Sexta");
            }

            if (chkSabado.Checked)
            {
                if (quantDias > 0)
                {
                    diasSelecionados += ", Sábado";
                }
                else
                {
                    diasSelecionados += "Sábado";
                }
                quantDias++;
                dias.Add("Sábado");
            }

            if (quantDias > 0)
            {
                List<Horario> horariosCompativeis = new List<Horario>();
                if (cmbHorario.SelectedItem.ToString().Equals("Todos"))
                {
                    foreach (Horario h in horarios)
                    {
                        foreach (string s in dias)
                        {
                            if (h.getDiaSemana().Equals(s))
                            {
                                horariosCompativeis.Add(h);
                            }
                        }
                    }
                }
                else
                {
                    foreach (Horario h in horarios)
                    {
                        foreach (string s in dias)
                        {
                            if (h.getDiaSemana().Equals(s) && h.getHorario().Equals(cmbHorario.SelectedItem.ToString()))
                            {
                                horariosCompativeis.Add(h);
                            }
                        }
                    }
                }

                PdfPTable infoTabela = new PdfPTable(5);

                infoTabela.HorizontalAlignment = 1;

                if (horariosCompativeis.Count > 0)
                {
                    PdfPCell head1 = new PdfPCell(new Phrase("Horário"));
                    PdfPCell head2 = new PdfPCell(new Phrase("Disciplina"));
                    PdfPCell head3 = new PdfPCell(new Phrase("Turma"));
                    PdfPCell head4 = new PdfPCell(new Phrase("Professor"));
                    PdfPCell head5 = new PdfPCell(new Phrase("Dia da Semana"));

                    head1.HorizontalAlignment = 1;
                    head2.HorizontalAlignment = 1;
                    head3.HorizontalAlignment = 1;
                    head4.HorizontalAlignment = 1;
                    head5.HorizontalAlignment = 1;

                    infoTabela.AddCell(head1);
                    infoTabela.AddCell(head2);
                    infoTabela.AddCell(head3);
                    infoTabela.AddCell(head4);
                    infoTabela.AddCell(head5);


                    foreach (Horario ho in horariosCompativeis)
                    {
                        Professor prof = ho.getProfessor();
                        DisciplinaTecnica disciplina = ho.getDisciplina();

                        PdfPCell cell1 = new PdfPCell(new Phrase(ho.getHorario()));
                        PdfPCell cell2 = new PdfPCell(new Phrase(disciplina.getNome()));
                        PdfPCell cell3 = new PdfPCell(new Phrase(ho.getTurma()));
                        PdfPCell cell4 = new PdfPCell(new Phrase(prof.getNome()));
                        PdfPCell cell5 = new PdfPCell(new Phrase(ho.getDiaSemana()));

                        cell1.HorizontalAlignment = 1;
                        cell3.HorizontalAlignment = 1;
                        cell4.HorizontalAlignment = 1;
                        cell5.HorizontalAlignment = 1;

                        infoTabela.AddCell(cell1);
                        infoTabela.AddCell(cell2);
                        infoTabela.AddCell(cell3);
                        infoTabela.AddCell(cell4);
                        infoTabela.AddCell(cell5);

                    }

                    Document doc = new Document(PageSize.A4);
                    doc.SetMargins(40, 40, 40, 80);
                    doc.AddCreationDate();

                    Paragraph f = new Paragraph("Filtros utilizados", FontFactory.GetFont("Arial", 11, iTextSharp.text.Font.BOLD));
                    Paragraph filtros = new Paragraph("\nDias: " + diasSelecionados + "\nHorário: " + cmbHorario.SelectedItem.ToString() +
                                                        "\nAno/Semestre: " + anosSemestres.SelectedItem.ToString() + "\nLaboratório: " + numeroLaboratorio, FontFactory.GetFont("Arial", 11));
                    filtros.Alignment = Element.ALIGN_JUSTIFIED;
                    f.Alignment = Element.ALIGN_CENTER;

                    Paragraph titulo = new Paragraph("Relatório", FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD));
                    titulo.Alignment = Element.ALIGN_CENTER;


                    string imgUrl = Environment.CurrentDirectory + "\\ifmaLogo.jpeg";

                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(imgUrl);
                    img.ScaleToFit(140f, 120f);
                    img.SpacingBefore = 10f;
                    img.SpacingAfter = 1f;
                    img.Alignment = Element.ALIGN_CENTER;


                    SaveFileDialog svg = new SaveFileDialog();
                    svg.Filter = "Pdf File|*.pdf";
                    svg.FileName = "Relatorio";
                    svg.ShowDialog();

                    string caminho = svg.FileName;
                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

                    doc.Open();

                    doc.Add(img);
                    doc.Add(f);
                    doc.Add(filtros);
                    doc.Add(titulo);
                    doc.Add(new Phrase(Environment.NewLine));
                    doc.Add(infoTabela);

                    doc.Close();
                }
                else
                {
                    MessageBox.Show("Não existem dados para as configurações definidas!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Selecione ao menos um dia da semana!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void chkTodos_CheckedChanged_1(object sender, EventArgs e)
        {
            chkSegunda.Checked = true;
            chkTerca.Checked = true;
            chkQuarta.Checked = true;
            chkQuinta.Checked = true;
            chkSexta.Checked = true;
            chkSabado.Checked = true;

            if (!chkTodos.Checked)
            {
                chkSegunda.Checked = false;
                chkTerca.Checked = false;
                chkQuarta.Checked = false;
                chkQuinta.Checked = false;
                chkSexta.Checked = false;
                chkSabado.Checked = false;
            }
        }

        private void numerosLabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            anosSemestres.Items.Clear();

            DaoGradeHoraria daoGH = new DaoGradeHoraria();
            DaoLaboratorio daoLab = new DaoLaboratorio();
            Laboratorio lab = daoLab.buscarLaboratorioPeloNumeroBD(Int32.Parse(numerosLabs.SelectedItem.ToString()));

            List<string> aS = daoGH.listarTodosAnosSemestres(lab);
            foreach (string s in aS)
            {
                anosSemestres.Items.Add(s);
            }

            anosSemestres.Enabled = true;
        }
    }
}
