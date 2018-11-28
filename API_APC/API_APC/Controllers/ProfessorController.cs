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
    [RoutePrefix("api/Professor")]
    public class ProfessorController : ApiController
    {
        UsuarioRepositorio UR = new UsuarioRepositorio();
        ProfessorRepositorio PR = new ProfessorRepositorio();
        // GET api/values
        [Route("")]
        [ActionName("Perfil")]
        public IEnumerable<string> Perfil(String CPF)
        {
            Professor perfilProfessor = new Professor();
            Usuario user = new Usuario();

            user = UR.BuscarTodosComCondicao(u => u.CPF.Equals(CPF)).FirstOrDefault();

            perfilProfessor = PR.BuscarTodosComCondicao(a => a.Usuario == user.Usuario_ID).FirstOrDefault();

            var json = JsonConvert.SerializeObject(perfilProfessor);

            return new string[] { json };
        }

        // GET api/values/5
        [HttpPost]
        [ActionName("CadastrarPerfil")]
        //api/Usuario/Cadastrar/?NewUser="abc"
        public string CadastrarPerfil(String NovoProfessor)
        {
            Professor Professor = new Professor();
            Professor = JsonConvert.DeserializeObject<Professor>(NovoProfessor.ToString());

            var temp = PR.BuscarTodosComCondicao(a => a.Usuario1.CPF.Equals(Professor.Usuario1.CPF));
            if(temp != null)
            {
                return "Cadastro Falhou! Professor já existe!";
            }
            else
            {
                PR.Adicionar(Professor);
            }
           
            return "Success";
        }
    }
}
