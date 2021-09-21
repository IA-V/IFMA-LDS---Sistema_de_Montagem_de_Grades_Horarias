using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MontagemDeHorariosLabs.dao
{
    public class DaoLaboratorio : ConnectionFactory
    {
        private List<Laboratorio> laboratorios;
        private MySqlCommand envelope;
        private MySqlDataReader cursor;

        public DaoLaboratorio()
        {
            base.estabelecerConexao();
        }

        public int salvarLaboratorioBD(Laboratorio lab)
        {
            envelope = base.criarCanalConexao();

            envelope.CommandText = "insert into laboratorio (numero, quantComp, localizacao) values (@numero, @quantComp, @localizacao);";
            envelope.Parameters.AddWithValue("@numero", lab.getNumero());
            envelope.Parameters.AddWithValue("@quantComp", lab.getQuantComp());
            envelope.Parameters.AddWithValue("@localizacao", lab.getLocalizacao());

            int resultado = base.executarComandoDMLNonQuery(envelope);
            base.fecharCanalConexao(envelope);
            return resultado;
        }

        public int alterarLaboratorioBD(Laboratorio lab)
        {
            envelope = base.criarCanalConexao();

            envelope.CommandText = "update laboratorio set numero = @numero, quantComp = @quantComp, localizacao = @localizacao where idLaboratorio = @idLaboratorio;";
            envelope.Parameters.AddWithValue("@numero", lab.getNumero());
            envelope.Parameters.AddWithValue("@quantComp", lab.getQuantComp());
            envelope.Parameters.AddWithValue("@localizacao", lab.getLocalizacao());
            envelope.Parameters.AddWithValue("@idLaboratorio", lab.getIdLaboratorio());

            int resultado = base.executarComandoDMLNonQuery(envelope);
            base.fecharCanalConexao(envelope);
            return resultado;
        }

        public List<Laboratorio> buscarLaboratoriosBD(int filtro)
        {
            envelope = base.criarCanalConexao();

            if (filtro != -1)
            {
                envelope.CommandText = "select * from laboratorio where numero = @numero;";
                envelope.Parameters.AddWithValue("@numero", filtro);
            }
            else
                envelope.CommandText = "select * from laboratorio;";
            

            cursor = base.executarComandoDMLQuery(envelope);
            this.laboratorios = new List<Laboratorio>();

            while (cursor.Read())
            {
                Laboratorio lab = new Laboratorio(cursor.GetInt32("idLaboratorio"), cursor.GetInt32("numero"),
                                                cursor.GetInt32("quantComp"), cursor.GetString("localizacao"));
                this.laboratorios.Add(lab);
            }

            base.fecharCanalConexao(envelope, cursor);
            return this.laboratorios;
        }

        public Laboratorio buscarLaboratorioBD(int idLaboratorio)
        {
            envelope = base.criarCanalConexao();

            envelope.CommandText = "select * from laboratorio where idLaboratorio = @idLaboratorio;";
            envelope.Parameters.AddWithValue("@idLaboratorio", idLaboratorio);

            cursor = base.executarComandoDMLQuery(envelope);
            Laboratorio lab = null;
            while (cursor.Read())
                lab = new Laboratorio(cursor.GetInt32("idLaboratorio"), cursor.GetInt32("numero"),
                                                cursor.GetInt32("quantComp"), cursor.GetString("localizacao"));
            base.fecharCanalConexao(envelope, cursor);
            return lab;
        }

        public Laboratorio buscarLaboratorioPeloNumeroBD(int numero)
        {
            envelope = base.criarCanalConexao();

            envelope.CommandText = "select * from laboratorio where numero = @numero;";
            envelope.Parameters.AddWithValue("@numero", numero);

            cursor = base.executarComandoDMLQuery(envelope);
            Laboratorio lab = null;
            while (cursor.Read())
                lab = new Laboratorio(cursor.GetInt32("idLaboratorio"), cursor.GetInt32("numero"),
                                                cursor.GetInt32("quantComp"), cursor.GetString("localizacao"));
            base.fecharCanalConexao(envelope, cursor);
            return lab;
        }
    }
}
