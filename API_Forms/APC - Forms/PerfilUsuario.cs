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
    public partial class PerfilUsuario : Form
    {
        public PerfilUsuario()
        {
            InitializeComponent();
        }
        public PerfilUsuario(Usuario user)
        {
            InitializeComponent();
        }

        private void atualizarPerfil_btn_Click(object sender, EventArgs e)
        {
            if (testData())
            {
                Usuario usuario = new Usuario();
                usuario.Nome = nome_txtbox.Text;
                usuario.CPF = cpf_txtbox.Text;
                usuario.Idade = Int32.Parse(idade_txtbox.Text);

                string parameter = JsonConvert.SerializeObject(usuario);

                string url = "http://localhost:52391/api/Usuario/AtualizarPerfil";
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
            
        }
        private bool testData()
        {
            if(nome_txtbox.Text.Equals("") || cpf_txtbox.Equals("") || nome_txtbox.Text.Equals(""))
            {
                string message = "Preencha TODOS os campos";
                string caption = "Erro ao validar campos";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons);

                return false;
            }
            return true;
        }
        private void loginAluno_btn_Click(object sender, EventArgs e)
        {

        }

        private void professorLogin_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
