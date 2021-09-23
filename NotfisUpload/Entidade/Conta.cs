using Microsoft.Data.SqlClient;
using NotfisUpload.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotfisUpload.Entidade
{
    public class Conta
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }
        public string Cep { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }


        public bool Login()
        {
            var result = false;
            var sql = "SELECT Id, Nome, Senha FROM Usuarios WHERE Email = ''" + this.Email + "'";
            try
            {
                using (var cn = new SqlConnection())
                {
                    cn.Open();
                    using (var cmd = new SqlCommand(sql, cn))
                    {

                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    if (Senha == dr["senha"].ToString())
                                    {
                                        this.Id = Convert.ToInt32(dr["id"]);
                                        this.Nome = dr["nome"].ToString();
                                        result = true;
                                    }
                                }
                            }

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Falha: " + ex.Message);
            }
            return (result);
        }
    }
}
