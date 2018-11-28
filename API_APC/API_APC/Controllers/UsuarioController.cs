using Repositorio.DAL.Repositorios;
using Repositorio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using Repositorios.DAL;

namespace API_APC.Controllers
{
    [RoutePrefix("api/Usuario")]
    public class UsuarioController : ApiController
    {
        UsuarioRepositorio UR = new UsuarioRepositorio();
        LoginUsuarioRepositorio ULR = new LoginUsuarioRepositorio();
        // GET api/values
        //api/Usuario/Login/?usuario="abc"
        [HttpGet]
        [ActionName("Login")]
        public string Login(String usuario)
        {
            string retorno;
            Login_Usuario novoUsuario = new Login_Usuario();
            novoUsuario = JsonConvert.DeserializeObject<Login_Usuario>(usuario.ToString());

            Login_Usuario usuarioExistente = new Login_Usuario();
            usuarioExistente = ULR.BuscarTodosComCondicao(ul => ul.LOLogin.Equals(novoUsuario.LOLogin)
                                                      && ul.LOSenha.Equals(novoUsuario.LOSenha)
                                                      && ul.LOTipoUsuario == novoUsuario.LOTipoUsuario).FirstOrDefault();


            if (usuarioExistente.LOLogin.Equals(""))
            {
                //usuario nao encontrado.
                return "Usuário ou senha Incorretos";
            }
            Usuario perfil = new Usuario();
            perfil = UR.BuscarTodosComCondicao(u => u.Login_Usuario == usuarioExistente.LOID).FirstOrDefault();
            perfil.Login_Usuario1.Usuario = null;
            if (perfil == null)
            {
                retorno = "null";
                return retorno;
            }
            Usuario user = new Usuario();
            user.Idade = perfil.Idade;
            user.Nome = perfil.Nome;
            user.Usuario_ID = perfil.Usuario_ID;
            user.CPF = perfil.CPF;
            user.Foto = perfil.Foto;
            user.Professor = null;
            user.Aluno = null;

            retorno = JsonConvert.SerializeObject(user);

            return retorno;
        }

        // GET api/values/5
        [HttpPost]
        [ActionName("Cadastrar")]
        //api/Usuario/Cadastrar/?NewUser="abc"
        public HttpResponseMessage Cadastrar([FromBody]Login_Usuario NewUser)
        {
            Login_Usuario novoUsuario = new Login_Usuario();

            Login_Usuario usuarioExistente = new Login_Usuario();
            usuarioExistente = ULR.BuscarTodosComCondicao(u => u.LOLogin.Equals(NewUser.LOLogin)
                                                          && u.LOSenha.Equals(NewUser.LOSenha)
                                                          ).FirstOrDefault();


            if (usuarioExistente == null)
            {
                ULR.Adicionar(novoUsuario);
                var response = new HttpResponseMessage(HttpStatusCode.Created);

                return response;
            }
            var failure = new HttpResponseMessage(HttpStatusCode.NotAcceptable);
            return failure;
        }
        // GET api/values/5
        [HttpPost]
        [ActionName("AtualizarPerfil")]
        //api/Usuario/AtualizarPerfil/
        public HttpResponseMessage AtualizarPerfil([FromBody]Usuario user)
        {
            Usuario usuarioExistente = new Usuario();
            usuarioExistente = UR.BuscarTodosComCondicao(u => u.CPF.Equals(user.CPF)
                                                          && u.Nome.Equals(user.Nome)
                                                          ).FirstOrDefault();
            if (usuarioExistente == null)
            {
                UR.Adicionar(user);
                var response = new HttpResponseMessage(HttpStatusCode.Created);

                return response;
            }
            else
            {
                UR.Atualizar(user);
                var response = new HttpResponseMessage(HttpStatusCode.OK);

                return response;
            }
        }
    }
}
