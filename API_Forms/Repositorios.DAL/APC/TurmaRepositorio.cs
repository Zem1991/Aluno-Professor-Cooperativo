using Repositorios.DAL.Base;
using Repositorio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Web.Mvc;

namespace Repositorio.DAL.Repositorios
{
    public class TurmaRepositorio : Repositorio<Turma>
    {
        APCEntities db = new APCEntities();

        //public List<Candidato_AreaAtuacao> BuscarAreaAtuacaoCandidato(int caid)
        //{
        //    var query = db.Candidato_AreaAtuacao.Where(ca => ca.CAARCandidato == caid).Include("AreaAtuacao"); // Lista de Áreas de Atuação de um Candidato

        //    return query.ToList();
        //}


        //public Candidato_AreaAtuacao BuscarCandidatoAreaPorID(int CAARID)
        //{
        //    return db.Candidato_AreaAtuacao.Where(ca => ca.CAARID.Equals(CAARID)).Include("AreaAtuacao").FirstOrDefault();
        //}

        //public void ExcluirCandidatoAreaAtuacao(Candidato_AreaAtuacao obj)
        //{
        //    db.Set<Candidato_AreaAtuacao>().Remove(obj);
        //    db.SaveChanges();

        //}

        //public void CadastrarAreaAtuacaoPorCandidato(Candidato_AreaAtuacao obj)
        //{
        //    id area atuação + id candidato
        //    db.Set<Candidato_AreaAtuacao>().Add(obj);
        //    db.SaveChanges();
        //}
    }
}
