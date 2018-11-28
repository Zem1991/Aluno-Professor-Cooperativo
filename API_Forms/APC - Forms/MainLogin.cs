
using Newtonsoft.Json;
using Repositorio.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APC___Forms
{
    public partial class MainLogin : Form
    {
        private PerfilUsuario perfilForm;

        public MainLogin()
        {
            InitializeComponent();
            
        }

        private void NovoUsuario_Click(object sender, EventArgs e)
        {
            Login_Usuario login = new Login_Usuario(); 
            login.LOLogin = login_txtbox.Text;
            login.LOSenha = senha_txtbox.Text;
            login.LOTipoUsuario = 1; // for now
            string parameter = JsonConvert.SerializeObject(login);
            string url = "http://localhost:52391/api/Usuario/Cadastrar/";

            var data = Encoding.ASCII.GetBytes(parameter);
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = data.Length;

            try
            {
                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
                var response = (HttpWebResponse)request.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            }
            catch (WebException ex)
            {
                WebResponse errorResponse = ex.Response;
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                    String errorText = reader.ReadToEnd();
                    // log errorText
                }
                throw;
            }
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            Login_Usuario login = new Login_Usuario();
            login.LOLogin = login_txtbox.Text;
            login.LOSenha = senha_txtbox.Text;
            login.LOTipoUsuario = 1; // for now
            string parameter = JsonConvert.SerializeObject(login);
            
            string url = "http://localhost:52391/api/Usuario/Login/?usuario=" + parameter;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            try
            {
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    var result = reader.ReadToEnd();
                    Usuario user = new Usuario();
                    
                    if(result.Equals("\"null\""))
                    {
                        //nao terminou o cadastro - chama tela de Perfil
                        perfilForm = new PerfilUsuario();
                        perfilForm.Show();
                        //this.Close();
                    }
                    else
                    {
                        //cadastro de perfil completo: chama tela de perfil com os valores ja preenchidos
                        dynamic jsonData = JsonConvert.DeserializeObject<dynamic>(result);
                        Usuario usuarioExistente = JsonConvert.DeserializeObject<Usuario>(jsonData);
                        perfilForm = new PerfilUsuario(usuarioExistente);
                        perfilForm.Show();
                        //this.Close();

                    }
                }
            }
            catch (WebException ex)
            {
                WebResponse errorResponse = ex.Response;
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                    String errorText = reader.ReadToEnd();
                    // log errorText
                }
                throw;
            }
        }//test
    }
}
