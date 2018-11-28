using Repositorio.DAL.Repositorios;
using Repositorio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;

namespace API_APC.Controllers
{
    [RoutePrefix("api/Aluno")]
    public class AlunoController : ApiController
    {
        UsuarioRepositorio UR = new UsuarioRepositorio();
        AlunoRepositorio AR = new AlunoRepositorio();
        // GET api/values
        [Route("")]
        [ActionName("Perfil")]
        public IEnumerable<string> Perfil(String CPF)
        {
            Aluno perfilAluno = new Aluno();
            Usuario user = new Usuario();

            user = UR.BuscarTodosComCondicao(u => u.CPF.Equals(CPF)).FirstOrDefault();

            perfilAluno = AR.BuscarTodosComCondicao(a => a.Usuario == user.Usuario_ID).FirstOrDefault();

            var json = JsonConvert.SerializeObject(perfilAluno);

            return new string[] { json };
        }

        // GET api/values/5
        [HttpPost]
        [ActionName("CadastrarPerfil")]
        //api/Usuario/Cadastrar/?NewUser="abc"
        public string CadastrarPerfil(String NovoAluno)
        {
            Aluno aluno = new Aluno();
            aluno = JsonConvert.DeserializeObject<Aluno>(NovoAluno.ToString());

            var temp = AR.BuscarTodosComCondicao(a => a.Usuario1.CPF.Equals(aluno.Usuario1.CPF));
            if(temp != null)
            {
                return "Cadastro Falhou! Aluno já existe!";
            }
            else
            {
                AR.Adicionar(aluno);
            }
           
            return "Success";
        }
    }
}
