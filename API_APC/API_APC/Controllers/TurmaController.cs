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
    [RoutePrefix("api/Turma")]
    public class TurmaController : ApiController
    {
        UsuarioRepositorio UR = new UsuarioRepositorio();
        AlunoRepositorio AR = new AlunoRepositorio();
        ProfessorRepositorio PR = new ProfessorRepositorio();
        TurmaRepositorio TR = new TurmaRepositorio();

        // GET api/values
        [Route("")]
        [ActionName("TurmasAbertas")]
        public IEnumerable<string> TurmasAbertas(String Interesse)
        {
           //Busca todas as turmas com o interesse que foi passado.

            var json = ""; //JsonConvert.SerializeObject(perfilAluno);

            return new string[] { json };
        }

        // GET api/values/5
        [HttpPost]
        [ActionName("AbrirTurma")]
        //api/Usuario/Cadastrar/?NewUser="abc"
        public string AbrirTurma(String NovaTurma, string perfil)
        {
            //Cadastra nova turma

            return "Success";
        }

        // GET api/values/5
        [HttpPost]
        [ActionName("AderirTurma")]
        //api/Usuario/Cadastrar/?NewUser="abc"
        public string AderirTurma(String TurmaExistente, string perfil)
        {
            //Cadastra nova turma

            return "Success";
        }
    }
}
