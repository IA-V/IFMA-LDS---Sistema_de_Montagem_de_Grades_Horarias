using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MontagemDeHorariosLabs.dao
{
    public class DaoCoordenador : ConnectionFactory
    {
        private MySqlCommand envelope;
        private MySqlDataReader cursor;
        private DaoProfessor daoProf = new DaoProfessor();

        public DaoCoordenador()
        {
            base.estabelecerConexao();
        }

        public int salvarCoordenadorBD(Coordenador coord)
        {
            envelope = base.criarCanalConexao();
            envelope.CommandText = "insert into coordenador (vigencia, senha, idProfessor) values (@vigencia, @senha, @idProfessor);";

            int vigencia = 0;
            if (coord.isVigente())
                vigencia = 1;
            envelope.Parameters.AddWithValue("@vigencia", vigencia);
            envelope.Parameters.AddWithValue("@senha", coord.getSenha());
            envelope.Parameters.AddWithValue("@idProfessor", coord.getProfessor().getIdProfessor());

            int resultado = base.executarComandoDMLNonQuery(envelope);
            base.fecharCanalConexao(envelope);
            return resultado;
        }

        public int alterarCoordenadorBD(Coordenador coord)
        {
            envelope = base.criarCanalConexao();
            envelope.CommandText = "update coordenador set vigencia = @vigencia, senha = @senha where idCoordenador = @idCoordenador;";

            int vigencia = 0;
            if (coord.isVigente())
                vigencia = 1;
            envelope.Parameters.AddWithValue("@vigencia", vigencia);
            envelope.Parameters.AddWithValue("@senha", coord.getSenha());
            envelope.Parameters.AddWithValue("@idCoordenador", coord.getIdCoordenador());

            int resultado = base.executarComandoDMLNonQuery(envelope);
            base.fecharCanalConexao(envelope);
            return resultado;
        }

        public Coordenador buscarCoordenadorBD(string matriculaProfessor)
        {
            envelope = base.criarCanalConexao();

            envelope.CommandText = "select c.* from coordenador c, professor p where c.idProfessor = p.idProfessor and p.matricula = @matriculaProfessor";
            envelope.Parameters.AddWithValue("@matriculaProfessor", matriculaProfessor);

            cursor = base.executarComandoDMLQuery(envelope);

            Coordenador coord = null;
            while (cursor.Read())
            {
                bool vigencia = false;
                if (cursor.GetInt32("vigencia") == 1)
                    vigencia = true;
                coord = new Coordenador(cursor.GetInt32("idCoordenador"), vigencia,
                                        daoProf.buscarProfessorBD(cursor.GetInt32("idProfessor")),
                                        cursor.GetString("senha"));
            }

            base.fecharCanalConexao(envelope, cursor);
            return coord;
        }
    }
}
