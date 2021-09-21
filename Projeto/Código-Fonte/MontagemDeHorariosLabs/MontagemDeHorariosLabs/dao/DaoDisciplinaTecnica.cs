using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MontagemDeHorariosLabs.dao
{
    public class DaoDisciplinaTecnica : ConnectionFactory
    {
        private MySqlCommand envelope;
        private MySqlDataReader cursor;

        public DaoDisciplinaTecnica()
        {
            base.estabelecerConexao();
        }

        public int salvarDisciplinaTecnicaBD(DisciplinaTecnica dt)
        {
            envelope = base.criarCanalConexao();

            envelope.CommandText = "insert into disciplinatecnica (nome, cargaHoraria, sigla) values (@nome, @cargaHoraria, @sigla);";
            envelope.Parameters.AddWithValue("@nome", dt.getNome());
            envelope.Parameters.AddWithValue("@cargaHoraria", dt.getCargaHoraria());
            envelope.Parameters.AddWithValue("@sigla", dt.getSigla());

            int resultado = base.executarComandoDMLNonQuery(envelope);
            base.fecharCanalConexao(envelope);
            return resultado;
        }

        public int alterarDisciplinaTecnicaBD(DisciplinaTecnica dt)
        {
            envelope = base.criarCanalConexao();

            envelope.CommandText = "update disciplinatecnica set nome = @nome, cargaHoraria = @cargaHoraria, sigla = @sigla where idDisciplinaTecnica = @idDisciplinaTecnica;";
            envelope.Parameters.AddWithValue("@nome", dt.getNome());
            envelope.Parameters.AddWithValue("@cargaHoraria", dt.getCargaHoraria());
            envelope.Parameters.AddWithValue("@sigla", dt.getSigla());
            envelope.Parameters.AddWithValue("@idDisciplinaTecnica", dt.getIdDisciplinaTecnica());

            int resultado = base.executarComandoDMLNonQuery(envelope);
            base.fecharCanalConexao(envelope);
            return resultado;
        }

        public List<DisciplinaTecnica> buscarDisciplinasTecnicasBD(string filtro)
        {
            envelope = base.criarCanalConexao();

            if (filtro != null)
            {
                envelope.CommandText = "select * from disciplinatecnica where sigla = @filtro;";
                envelope.Parameters.AddWithValue("@filtro", filtro);
            }
            else
                envelope.CommandText = "select * from disciplinatecnica";
            
            cursor = base.executarComandoDMLQuery(envelope);
            List<DisciplinaTecnica> disciplinas = new List<DisciplinaTecnica>();

            while (cursor.Read())
            {
                DisciplinaTecnica dt = new DisciplinaTecnica(cursor.GetInt32("idDisciplinaTecnica"), cursor.GetString("nome"),
                                                cursor.GetString("sigla"), cursor.GetInt32("cargaHoraria"));
                disciplinas.Add(dt);
            }

            base.fecharCanalConexao(envelope, cursor);
            return disciplinas;
        }

        public DisciplinaTecnica buscarDisciplinasTecnicasBD(int idDisciplina)
        {
            envelope = base.criarCanalConexao();

            if (idDisciplina != -1)
            {
                envelope.CommandText = "select * from disciplinatecnica where idDisciplinaTecnica = @idDisciplinaTecnica;";
                envelope.Parameters.AddWithValue("@idDisciplinaTecnica", idDisciplina);
            }
            else
                envelope.CommandText = "select * from disciplinatecnica;";
            
            cursor = base.executarComandoDMLQuery(envelope);
            DisciplinaTecnica dt = null;
            while (cursor.Read())
                dt = new DisciplinaTecnica(cursor.GetInt32("idDisciplinaTecnica"), cursor.GetString("nome"),
                                                cursor.GetString("sigla"), cursor.GetInt32("cargaHoraria"));
            
            base.fecharCanalConexao(envelope, cursor);
            return dt;
        }

        public DisciplinaTecnica buscarDisciplinaTecnicaBD(string sigla)
        {
            envelope = base.criarCanalConexao();
            envelope.CommandText = "select * from disciplinatecnica where sigla = @sigla;";
            envelope.Parameters.AddWithValue("@sigla", sigla);
            
            cursor = base.executarComandoDMLQuery(envelope);
            DisciplinaTecnica dt = null;
            while (cursor.Read())
                dt = new DisciplinaTecnica(cursor.GetInt32("idDisciplinaTecnica"), cursor.GetString("nome"),
                                                cursor.GetString("sigla"), cursor.GetInt32("cargaHoraria"));
            
            base.fecharCanalConexao(envelope, cursor);
            return dt;
        }
    }
}
