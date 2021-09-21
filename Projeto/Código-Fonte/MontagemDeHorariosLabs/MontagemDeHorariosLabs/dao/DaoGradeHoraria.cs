using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MontagemDeHorariosLabs.dao
{
    public class DaoGradeHoraria : ConnectionFactory
    {
        private MySqlCommand envelope;
        private MySqlDataReader cursor;
        private DaoLaboratorio daoLab = new DaoLaboratorio();
        private DaoProfessor daoProfessor = new DaoProfessor();
        private DaoDisciplinaTecnica daoDiscTec = new DaoDisciplinaTecnica();

        public DaoGradeHoraria()
        {
            base.estabelecerConexao();
        }

        public int salvarGradeHorariaBD(GradeHoraria gradeHoraria)
        {
            envelope = base.criarCanalConexao();

            envelope.CommandText = "insert into gradehoraria (anosemestre, idlaboratorio, status) values (@anosemestre, @idlaboratorio, 1);";
            envelope.Parameters.AddWithValue("@anosemestre", gradeHoraria.getanoSemestre());
            envelope.Parameters.AddWithValue("@idlaboratorio", gradeHoraria.getLaboratorio().getIdLaboratorio());

            int resultado = base.executarComandoDMLNonQuery(envelope);
            base.fecharCanalConexao(envelope);

            int idGradeHoraria = this.buscarIDGradeHorariaBD(gradeHoraria);

            DaoHorario daoHorario = new DaoHorario();
            foreach (Horario horario in gradeHoraria.GetListaHorarios())
            {
                daoHorario.salvarHorarioBD(horario);
                int idHorario = daoHorario.buscarIDHorarioBD(horario);
                daoHorario.salvarHorario_GradeHorariaBD(idHorario, idGradeHoraria);
            }
            return resultado;
        }

        public int alterarGradeHorariaBD(GradeHoraria gradeHoraria)
        {
            envelope = base.criarCanalConexao();

            envelope.CommandText = "update gradehoraria set anosemestre = @anosemestre, status = @status where idGradeHoraria = @idGradeHoraria;";
            envelope.Parameters.AddWithValue("@anosemestre", gradeHoraria.getanoSemestre());
            int status = 0;
            if (gradeHoraria.isStatus())
                status = 1;
            envelope.Parameters.AddWithValue("@status", status);
            envelope.Parameters.AddWithValue("@idGradeHoraria", gradeHoraria.getIdGradeHoraria());

            int resultado = base.executarComandoDMLNonQuery(envelope);
            base.fecharCanalConexao(envelope);
            return resultado;
        }

        public int buscarIDGradeHorariaBD(GradeHoraria grade)
        {
            envelope = base.criarCanalConexao();
            envelope.CommandText = "select idGradeHoraria from gradehoraria where anosemestre = @anosemestre and idlaboratorio = @idlaboratorio and status = @status;";

            envelope.Parameters.AddWithValue("@anosemestre", grade.getanoSemestre());
            envelope.Parameters.AddWithValue("@idlaboratorio", grade.getLaboratorio().getIdLaboratorio());
            int status = 0;
            if (grade.isStatus())
                status = 1;
            envelope.Parameters.AddWithValue("@status", status);

            cursor = base.executarComandoDMLQuery(envelope);
            int idGradeHoraria = 0;
            while (cursor.Read())
                idGradeHoraria = cursor.GetInt32("idGradeHoraria");
            
            base.fecharCanalConexao(envelope, cursor);
            return idGradeHoraria;
        }

        public GradeHoraria buscaSimplesGradeHoraria(int numeroLab, string anoSemestre)
        {
            envelope = base.criarCanalConexao();

            envelope.CommandText = "select g.* from gradehoraria g, laboratorio l  where l.idLaboratorio = g.idLaboratorio and l.numero = @numero and g.anoSemestre = @anoSemestre;";
            envelope.Parameters.AddWithValue("@numero", numeroLab);
            envelope.Parameters.AddWithValue("@anoSemestre", anoSemestre);

            cursor = base.executarComandoDMLQuery(envelope);
            GradeHoraria gh = null;
            while (cursor.Read())
            {
                bool status = false;
                if (cursor.GetInt32("status") == 1)
                    status = true;
                gh = new GradeHoraria(cursor.GetInt32("idGradeHoraria"), cursor.GetString("anoSemestre"), null, null, status);
            }
            base.fecharCanalConexao(envelope, cursor);
            return gh;
        }

        public GradeHoraria buscarGradeHoraria(int numeroLab, string anoSemestre)
        {
            envelope = base.criarCanalConexao();

            envelope.CommandText = "select g.* from gradehoraria g, laboratorio l  where l.idLaboratorio = g.idLaboratorio and l.numero = @numero and anoSemestre = @anoSemestre;";
            envelope.Parameters.AddWithValue("@numero", numeroLab);
            envelope.Parameters.AddWithValue("@anoSemestre", anoSemestre);

            GradeHoraria gh = null;
            try
            {
                cursor = base.executarComandoDMLQuery(envelope);

                int idGradeHoraria = 0;
                bool status = false;
                Laboratorio lab = null;

                while (cursor.Read())
                {
                    idGradeHoraria = cursor.GetInt32("idGradeHoraria");
                    if (cursor.GetInt32("status") == 1)
                        status = true;
                    lab = daoLab.buscarLaboratorioBD(cursor.GetInt32("idLaboratorio"));
                }
                base.fecharCanalConexao(envelope, cursor);

                envelope = base.criarCanalConexao();

                envelope.CommandText = "select h.* from gradehoraria g, horario h, horario_gradehoraria gh  where g.idgradehoraria = gh.idgradehoraria and h.idhorario = gh.idhorario and gh.idgradehoraria = @idgradehoraria;";
                envelope.Parameters.AddWithValue("@idgradehoraria", idGradeHoraria);

                cursor = base.executarComandoDMLQuery(envelope);

                List<Horario> listaHorarios = new List<Horario>();
                while (cursor.Read())
                {
                    int idHorario = cursor.GetInt32("idHorario");
                    int idProfessor = cursor.GetInt32("idProfessor");
                    int idDisciplinaTecnica = cursor.GetInt32("idDisciplinaTecnica");
                    string intervalorhorario = cursor.GetString("horario");
                    string diaSemana = cursor.GetString("diaSemana");
                    string turma = cursor.GetString("turma");

                    Professor prof = daoProfessor.buscarProfessorBD(idProfessor);
                    DisciplinaTecnica dt = daoDiscTec.buscarDisciplinasTecnicasBD(idDisciplinaTecnica);

                    Horario horario = new Horario(idHorario, diaSemana, intervalorhorario, turma, prof, dt);
                    listaHorarios.Add(horario);
                }

                gh = new GradeHoraria(idGradeHoraria, anoSemestre, listaHorarios, lab, status);
            }
            catch
            {
                return gh;
            }
            base.fecharCanalConexao(envelope, cursor);
            return gh;
        }

        public bool buscarProfEmGHV(Professor prof)
        {
            envelope = base.criarCanalConexao();

            envelope.CommandText = "select h.idHorario from gradehoraria g, horario h, horario_gradehoraria gh where g.idGradeHoraria = gh.idGradeHoraria and gh.idHorario = h.idHorario and g.status = 1 and h.idProfessor = @idProfessor;";
            envelope.Parameters.AddWithValue("@idProfessor", prof.getIdProfessor());

            cursor = base.executarComandoDMLQuery(envelope);
            int idHorario = 0;
            while (cursor.Read())
                idHorario = cursor.GetInt32("idHorario");

            base.fecharCanalConexao(envelope, cursor);
            if(idHorario != 0)
                return true;
            return false;
        }

        public string pegarAnoSemestreMaisRecente(int numeroLab)
        {
            envelope = base.criarCanalConexao();

            envelope.CommandText = "select anoSemestre from gradehoraria gh, laboratorio l where gh.idlaboratorio = l.idlaboratorio and l.numero = @numeroLab and gh.status = 1;";
            envelope.Parameters.AddWithValue("@numeroLab", numeroLab);

            cursor = base.executarComandoDMLQuery(envelope);
            string anoSemestre = null;
            while (cursor.Read())
                anoSemestre = cursor.GetString("anoSemestre");
            
            base.fecharCanalConexao(envelope, cursor);
            return anoSemestre;
        }

        public List<string> buscarLaboratoriosLivres(string horario, string diaSemana)
        {
            List<string> laboratoriosLivres = new List<string>();

            envelope = base.criarCanalConexao();

            envelope.CommandText = "select * from laboratorio;";
            cursor = base.executarComandoDMLQuery(envelope);
            while (cursor.Read())
                laboratoriosLivres.Add(cursor.GetInt32("numero") + ": " + cursor.GetString("localizacao"));
            
            base.fecharCanalConexao(envelope, cursor);

            envelope = base.criarCanalConexao();

            envelope.CommandText = "select l.* from laboratorio l, gradehoraria g, horario_gradehoraria gh, horario h where l.idLaboratorio = g.idLaboratorio and g.idGradeHoraria = gh.idGradeHoraria and gh.idHorario = h.idHorario and h.diaSemana = @diaSemana and h.horario = @horario and g.status = 1;";
            envelope.Parameters.AddWithValue("@diaSemana", diaSemana);
            envelope.Parameters.AddWithValue("@horario", horario);

            cursor = base.executarComandoDMLQuery(envelope);
            while (cursor.Read())
            {
                string lab = cursor.GetInt32("numero") + ": " + cursor.GetString("localizacao");
                laboratoriosLivres.Remove(lab);
            }
            base.fecharCanalConexao(envelope, cursor);

            return laboratoriosLivres;

        }

        public List<string> listarTodosAnosSemestres(Laboratorio lab)
        {
            this.envelope = base.criarCanalConexao();

            this.envelope.CommandText = "select anoSemestre from gradehoraria where idLaboratorio = @idLaboratorio;";
            this.envelope.Parameters.AddWithValue("@idLaboratorio", lab.getIdLaboratorio());

            cursor = base.executarComandoDMLQuery(this.envelope);

            List<string> anosSemestres = new List<string>();
            while (cursor.Read())
            {
                string anoSem = cursor.GetString("anoSemestre");
                if (!anosSemestres.Contains(anoSem))
                {
                    anosSemestres.Add(anoSem);
                }
            }

            base.fecharCanalConexao(envelope, cursor);
            return anosSemestres;
        }

    }
}
