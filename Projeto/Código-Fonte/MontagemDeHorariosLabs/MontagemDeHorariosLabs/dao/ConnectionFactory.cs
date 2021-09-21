using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MontagemDeHorariosLabs.dao
{
    public class ConnectionFactory
    {
        private MySqlConnection conexao;

        public void estabelecerConexao()
        {
            conexao = new MySqlConnection("server=localhost;userid=root;password=;database=montagemhorarios"); 
        }

        public MySqlCommand criarCanalConexao()
        {
            if(conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }
            MySqlCommand envelope = new MySqlCommand();
            envelope.Connection = conexao;
            return envelope;
        }

        public void fecharCanalConexao(MySqlCommand envelope)
        {
            envelope.Cancel();
            conexao.Close();
        }

        public void fecharCanalConexao(MySqlCommand envelope, MySqlDataReader cursorExterno)
        {
            envelope.Cancel();
            conexao.Close();
        }

        public int executarComandoDMLNonQuery(MySqlCommand envelope)
        {
            envelope.Prepare();
            try
            {
                return envelope.ExecuteNonQuery();
            }
            catch
            {
                return 0;
            }
        }

        public MySqlDataReader executarComandoDMLQuery(MySqlCommand envelope)
        {
            envelope.Prepare();
            try
            {
                 return envelope.ExecuteReader();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

    }
}
