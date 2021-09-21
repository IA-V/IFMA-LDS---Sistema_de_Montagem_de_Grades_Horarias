using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MontagemDeHorariosLabs.dao
{
    public class DaoProfessor : ConnectionFactory
    {
        private MySqlCommand envelope;
        private MySqlDataReader cursor;

        public DaoProfessor()
        {
            base.estabelecerConexao();
        }

        public int salvarProfessorBD(Professor professor)
        {
            envelope = base.criarCanalConexao();

            envelope.CommandText = "insert into professor (nome, matricula, cpf, status) values (@nome, @matricula, @cpf, @status);";
            int status = 0;
            if (professor.isStatus())
                status = 1;
            envelope.Parameters.AddWithValue("@nome", professor.getNome());
            envelope.Parameters.AddWithValue("@matricula", professor.getMatricula());
            envelope.Parameters.AddWithValue("@cpf", professor.getCpf());
            envelope.Parameters.AddWithValue("@status", status);

            int resultado = base.executarComandoDMLNonQuery(envelope);
            base.fecharCanalConexao(envelope);
            return resultado;
        }

        public int alterarProfessorBD(Professor professor)
        {
            envelope = base.criarCanalConexao();

            envelope.CommandText = "update professor set nome = @nome, matricula = @matricula, cpf = @cpf, status = @status where idProfessor = @idProfessor;";
            int status = 0;
            if (professor.isStatus())
                status = 1;
            envelope.Parameters.AddWithValue("@nome", professor.getNome());
            envelope.Parameters.AddWithValue("@matricula", professor.getMatricula());
            envelope.Parameters.AddWithValue("@cpf", professor.getCpf());
            envelope.Parameters.AddWithValue("@status", status);
            envelope.Parameters.AddWithValue("@idProfessor", professor.getIdProfessor());

            int resultado = base.executarComandoDMLNonQuery(envelope);
            base.fecharCanalConexao(envelope);
            return resultado;
        }

        public List<Professor> buscarProfessorBD(string filtro)
        {
            envelope = base.criarCanalConexao();

            if (filtro != null)
            {
                envelope.CommandText = "select * from professor where matricula = @matricula";
                envelope.Parameters.AddWithValue("@matricula", filtro);
            }
            else
                envelope.CommandText = "select * from professor";

            cursor = base.executarComandoDMLQuery(envelope);
            List<Professor> professores = new List<Professor>();
            while (cursor.Read())
            {
                bool status = false;
                if (cursor.GetInt32("status") == 1)
                    status = true;

                Professor p = new Professor(cursor.GetInt32("idProfessor"), cursor.GetString("matricula"),
                                                cursor.GetString("nome"), cursor.GetString("cpf"), status);
                professores.Add(p);
            }
            base.fecharCanalConexao(envelope, cursor);
            return professores;
        }

        public List<Professor> buscarProfessoresVigentesBD()
        {
            envelope = base.criarCanalConexao();

            envelope.CommandText = "select * from professor where status = 1";

            cursor = base.executarComandoDMLQuery(envelope);
            List<Professor> professores = new List<Professor>();
            while (cursor.Read())
            {
                bool status = false;
                if (cursor.GetInt32("status") == 1)
                    status = true;

                Professor p = new Professor(cursor.GetInt32("idProfessor"), cursor.GetString("matricula"),
                                                cursor.GetString("nome"), cursor.GetString("cpf"), status);
                professores.Add(p);
            }
            base.fecharCanalConexao(envelope, cursor);
            return professores;
        }

        public Professor buscarProfessorBD(int idProfessor)
        {
            envelope = base.criarCanalConexao();

            envelope.CommandText = "select * from professor where idProfessor = @idProfessor";
            envelope.Parameters.AddWithValue("@idProfessor", idProfessor);

            Professor prof = buscarProfessor(envelope);
            base.fecharCanalConexao(envelope, cursor);
            return prof;
        }

        public Professor buscarProfessorPeloNomeBD(string nomeProfessor)
        {
            envelope = base.criarCanalConexao();

            envelope.CommandText = "select * from professor where nome = @nome";
            envelope.Parameters.AddWithValue("@nome", nomeProfessor);

            Professor prof = buscarProfessor(envelope);
            base.fecharCanalConexao(envelope, cursor);
            return prof;
        }

        public Professor buscarProfessorPelaMatriculaBD(string matricula)
        {
            envelope = base.criarCanalConexao();

            envelope.CommandText = "select * from professor where matricula = @matricula";
            envelope.Parameters.AddWithValue("@matricula", matricula);

            Professor prof = buscarProfessor(envelope);
            base.fecharCanalConexao(envelope, cursor);
            return prof;
        }

        public Professor buscarProfessor(MySqlCommand envelope)
        {
            Professor prof = null;
            cursor = base.executarComandoDMLQuery(envelope);
            while (cursor.Read())
            {
                bool status = false;
                if (cursor.GetInt32("status") == 1)
                    status = true;
                prof = new Professor(cursor.GetInt32("idProfessor"), cursor.GetString("matricula"),
                                                cursor.GetString("nome"), cursor.GetString("cpf"), status);
            }
            return prof;
        }

    }
}
