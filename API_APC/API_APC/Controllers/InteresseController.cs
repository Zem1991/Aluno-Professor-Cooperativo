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
    [RoutePrefix("api/interesse")]
    public class InteresseController : ApiController
    {
        UsuarioRepositorio UR = new UsuarioRepositorio();
        AlunoRepositorio AR = new AlunoRepositorio();
        ProfessorRepositorio PR = new ProfessorRepositorio();
        TurmaRepositorio TR = new TurmaRepositorio();
        InteresseRepositorio IR = new InteresseRepositorio();

        // GET api/values
        [Route("")]
        [ActionName("TodosInteresses")]
        public IEnumerable<string> TodosInteresses()
        {
           //Busca todos os interesses que foram cadastrados

            var json = ""; //JsonConvert.SerializeObject(perfilAluno);

            return new string[] { json };
        }
        // GET api/values
        [Route("")]
        [ActionName("MeusInteresses")]
        public IEnumerable<string> MeusInteresses(string perfil)
        {
            //Busca todos os interesses que foram cadastrados

            var json = ""; //JsonConvert.SerializeObject(perfilAluno);

            return new string[] { json };
        }

        // GET api/values/5
        [HttpPost]
        [ActionName("NovoInteresse")]
        //api/Usuario/Cadastrar/?NewUser="abc"
        public string NovoInteresse(String NovoInteresse)
        {
            //Cadastra nova turma

            return "Success";
        }

        // GET api/values/5
        [HttpPost]
        [ActionName("IncluirInteresse")]
        //api/Usuario/Cadastrar/?NewUser="abc"
        public string IncluirInteresse(String InteresseExistente, string perfil)
        {
            //Cadastra nova turma

            return "Success";
        }
    }
}
