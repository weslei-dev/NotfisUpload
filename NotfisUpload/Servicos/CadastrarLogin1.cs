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


