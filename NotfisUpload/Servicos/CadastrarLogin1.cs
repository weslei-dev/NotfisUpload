using Microsoft.Data.SqlClient;
using NotfisUpload.Entidade;
using NotfisUpload.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotfisUpload.Servicos
{
    public class CadastrarLogin
    {
        private readonly DataBaseContext _context = null;

        public CadastrarLogin(DataBaseContext context)
        {
            _context = context;
        }
        public int AddNewLogin(Usuario usuario)
        {
            var newUsuario = new Usuario()
            {
                Nome = usuario.Nome,
                Senha = usuario.Senha,
                Email = usuario.Email,
                Telefone = usuario.Telefone,
                Cep = usuario.Cep,
                Numero = usuario.Numero,
                Complemento = usuario.Complemento,
                Endereco = usuario.Endereco,
                Bairro = usuario.Bairro,
                Cidade = usuario.Cidade,
                Estado = usuario.Estado
            };

            _context.usuario.Add(newUsuario);
            _context.SaveChanges();

            return newUsuario.Id;

        }
    }
}



//public class RegistrarLogin
//{

//    private readonly DataBaseContext _context;

//    public RegistrarLogin(DataBaseContext context)
//    {
//        _context = context;
//    }

//    public bool Login()
//    {
//        var conta = new Conta();
//        var result = false;
//        var sql = "SELECT Id, Nome, Senha FROM Usuarios WHERE Email = ''" + conta.Email + "'";
//        try
//        {
//            using (var cn = new SqlConnection())
//            {
//                cn.Open();
//                using (var cmd = new SqlCommand(sql, cn))
//                {

//                    using (var dr = cmd.ExecuteReader())
//                    {
//                        if (dr.HasRows)
//                        {
//                            while (dr.Read())
//                            {
//                                if (conta.Senha == dr["senha"].ToString())
//                                {
//                                    conta.Id = Convert.ToInt32(dr["id"]);
//                                    conta.Nome = dr["nome"].ToString();
//                                    result = true;
//                                }
//                            }
//                        }

//                    }

//                }
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("Falha: " + ex.Message);
//        }
//        return (result);
//    }
//}


