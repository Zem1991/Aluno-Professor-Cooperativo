using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
//using System.Web.WebPages.Html;

namespace Repositorios.DAL.Global
{
    public class ListasRepositorio
    {
        public static List<SelectListItem> AtivoInativo()
        {

            List<SelectListItem> AtivoInativo = new List<SelectListItem>();
            AtivoInativo.AddRange(new[]{
                new SelectListItem() { Text = "Ativo", Value = "A" },
                new SelectListItem() { Text = "Inativo", Value = "I" },
            });

            return AtivoInativo;
        }

        public static string AtivoInativo(string status)
        {
            string retorno = "";

            if (status.Equals("A"))
            {
                retorno = "Ativo";
            }
            else
            {
                retorno = "Inativo";
            }
            return retorno;
        }
    }
}
