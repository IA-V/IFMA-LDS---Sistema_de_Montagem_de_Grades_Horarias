using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MontagemDeHorariosLabs.dao
{
    public class DaoHorario : ConnectionFactory
    {
        private MySqlCommand envelope;
        private MySqlDataReader cursor;

        public DaoHorario()
        {
            base.estabelecerConexao();
        }

        public int salvarHorarioBD(Horario horario)
        {
            envelope = base.criarCanalConexao();

            envelope.CommandText = "insert into horario (idProfessor, iddisciplinatecnica, horario, diasemana, turma) values (@idProfessor, @iddisciplinatecnica, @horario, @diasemana, @turma);";
            envelope.Parameters.AddWithValue("@idProfessor", horario.getProfessor().getIdProfessor());
            envelope.Parameters.AddWithValue("@iddisciplinatecnica", horario.getDisciplina().getIdDisciplinaTecnica());
            envelope.Parameters.AddWithValue("@horario", horario.getHorario());
            envelope.Parameters.AddWithValue("@diasemana", horario.getDiaSemana());
            envelope.Parameters.AddWithValue("@turma", horario.getTurma());

            int resultado = base.executarComandoDMLNonQuery(envelope);
            base.fecharCanalConexao(envelope);
            return resultado;
        }

        public int salvarHorario_GradeHorariaBD(int idHorario, int idGradeHoraria)
        {
            envelope = base.criarCanalConexao();

            envelope.CommandText = "insert into horario_gradehoraria (idhorario, idgradehoraria) values (@idhorario, @idgradehoraria);";
            envelope.Parameters.AddWithValue("@idHorario", idHorario);
            envelope.Parameters.AddWithValue("@idGradeHoraria", idGradeHoraria);

            int resultado = base.executarComandoDMLNonQuery(envelope);
            base.fecharCanalConexao(envelope);
            return resultado;
        }

        public int buscarIDHorarioBD(Horario horario)
        {
            envelope = base.criarCanalConexao();

            envelope.CommandText = "select idHorario from horario where idProfessor = @idProfessor and idDisciplinaTecnica = @idDisciplinaTecnica and horario = @horario and diaSemana = @diaSemana and turma = @turma;";
            envelope.Parameters.AddWithValue("@idProfessor", horario.getProfessor().getIdProfessor());
            envelope.Parameters.AddWithValue("@iddisciplinatecnica", horario.getDisciplina().getIdDisciplinaTecnica());
            envelope.Parameters.AddWithValue("@horario", horario.getHorario());
            envelope.Parameters.AddWithValue("@diasemana", horario.getDiaSemana());
            envelope.Parameters.AddWithValue("@turma", horario.getTurma());

            cursor = base.executarComandoDMLQuery(envelope);
            int idHorario = 0;
            while (cursor.Read())
                idHorario = cursor.GetInt32("idHorario");
            
            base.fecharCanalConexao(envelope, cursor);
            return idHorario;
        }

        public int alterarHorarioBD(Horario horario)
        {
            envelope = base.criarCanalConexao();

            envelope.CommandText = "update horario set idProfessor = @idProfessor, iddisciplinatecnica = @iddisciplinatecnica, horario = @horario, diasemana = @diasemana, turma = @turma where idHorario = @idHorario;";
            envelope.Parameters.AddWithValue("@idProfessor", horario.getProfessor().getIdProfessor());
            envelope.Parameters.AddWithValue("@iddisciplinatecnica", horario.getDisciplina().getIdDisciplinaTecnica());
            envelope.Parameters.AddWithValue("@horario", horario.getHorario());
            envelope.Parameters.AddWithValue("@diasemana", horario.getDiaSemana());
            envelope.Parameters.AddWithValue("@turma", horario.getTurma());
            envelope.Parameters.AddWithValue("@idHorario", horario.getIdHorario());

            int resultado = base.executarComandoDMLNonQuery(envelope);
            base.fecharCanalConexao(envelope);
            return resultado;
        }

    }
}
