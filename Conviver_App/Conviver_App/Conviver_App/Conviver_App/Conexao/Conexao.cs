using Conviver_App.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Conviver_App.Conexao
{
    public class Conexao
    {
        public string PegarConexao()
        {
            string conexao_sql = "Data Source=localhost\\SQLEXPRESS;Database=Conviver_Senior;Trusted_Connection=True;";            
            return conexao_sql;
        }
        
        public void Insere_Cuidador(string nome, string endereco)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(PegarConexao()))
                {
                    SqlCommand Insere_Cuidador = new SqlCommand("Insere_Cuidador", conn);
                    Insere_Cuidador.CommandType = CommandType.StoredProcedure;
                    Insere_Cuidador.Parameters.Add("@nome", SqlDbType.NVarChar, 100).Value = nome;
                    Insere_Cuidador.Parameters.Add("@endereco", SqlDbType.NVarChar, 1000).Value = endereco;
                    conn.Open();
                    Insere_Cuidador.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        public DataTable Mostra_Cuidadores()
        {            
            DataTable da = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(PegarConexao()))
                {
                    SqlCommand Mostra_Cuidadores = new SqlCommand("Mostra_Cuidadores", conn);
                    Mostra_Cuidadores.CommandType = CommandType.StoredProcedure;                                     
                    conn.Open();
                    SqlDataReader reader = Mostra_Cuidadores.ExecuteReader();
                    da.Load(reader);
                }
                return da;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());            
            }
            return da;
        }

        public bool Insere_Paciente( string id_cliente,
                                    string nome,
                                    string endereco,
                                    string flg_ativo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(PegarConexao()))
                {
                    SqlCommand Insere_Paciente = new SqlCommand("INSERE_PACIENTE", conn);
                    Insere_Paciente.CommandType = CommandType.StoredProcedure;
                    Insere_Paciente.Parameters.Add("@ID_CLIENTE", SqlDbType.Int).Value = id_cliente;
                    Insere_Paciente.Parameters.Add("@NOME", SqlDbType.NVarChar, 500).Value = nome;
                    Insere_Paciente.Parameters.Add("@@ENDERECO", SqlDbType.NVarChar, 1000).Value = endereco;
                    Insere_Paciente.Parameters.Add("@ATIVO", SqlDbType.NVarChar, 50).Value = flg_ativo;
                    conn.Open();
                    Insere_Paciente.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.Message);
                return false;
            }
            //catch (SqlException ex)
            //{
            //    MessageBox.Show(ex.ToString());

            //}
        }

        public DataTable Mostra_Pacientes()
        {
            DataTable da = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(PegarConexao()))
                {
                    SqlCommand Mostra_Cuidadores = new SqlCommand("MOSTRA_PACIENTES", conn);
                    Mostra_Cuidadores.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader reader = Mostra_Cuidadores.ExecuteReader();
                    da.Load(reader);
                }
                return da;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return da;
        }

        public DataTable Mostra_Pagamentos_Por_Id(int ID)
        {
            DataTable da = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(PegarConexao()))
                {
                    SqlCommand Mostra_pagamentos = new SqlCommand("BUSCAR_PAGAMENTOS_POR_ID", conn);
                    Mostra_pagamentos.Parameters.Add("@ID_PACIENTE", SqlDbType.Int).Value = ID;
                    Mostra_pagamentos.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader reader = Mostra_pagamentos.ExecuteReader();
                    da.Load(reader);
                }
                return da;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return da;
        }
        public void Atualiza_Pagamento_Paciente(  int id
                                                , string novo_status_pagamento
                                                , string novo_forma_pagamento
                                                , DateTime nova_data_pagamento)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(PegarConexao()))
                {
                    SqlCommand Atualiza_Status = new SqlCommand("ATUALIZAR_PAGAMENTO_PACIENTE", conn);
                    Atualiza_Status.CommandType = CommandType.StoredProcedure;
                    Atualiza_Status.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    Atualiza_Status.Parameters.Add("@STATUS_NOVO", SqlDbType.NVarChar, 100).Value = novo_status_pagamento;
                    Atualiza_Status.Parameters.Add("@FORMA_PAGAMENTO_NOVO", SqlDbType.NVarChar, 100).Value = novo_forma_pagamento;
                    Atualiza_Status.Parameters.Add("@DATA_PAGAMENTO_NOVO", SqlDbType.Date).Value = nova_data_pagamento;
                    conn.Open();
                    Atualiza_Status.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }




    }
}
