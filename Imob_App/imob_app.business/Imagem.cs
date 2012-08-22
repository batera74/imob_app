using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using imob_app.business.Contratos;
using imob_app.dao;

namespace imob_app.business
{
    public class Imagem : IEntidade<dao.imagem>
    {
        private imobappEntities _ctx;

        public Imagem()
        {
            _ctx = new imobappEntities();
        }

        public List<dao.imagem> SelecionarTodos()
        {
            return (from i in _ctx.imagem select i).ToList();
        }

        public dao.imagem Selecionar(int id)
        {
            return (from i in _ctx.imagem where i.id_imagem == id select i).FirstOrDefault();
        }

        public List<dao.imagem> SelecionarImagensNaoAssociadas()
        {
            return (from i in _ctx.imagem where i.imovel == null select i).ToList();
        }

        public bool Deletar(int id)
        {
            dao.imagem img = (from i in _ctx.imagem where i.id_imagem == id select i).FirstOrDefault();
            return Deletar(img);
        }

        public bool Deletar(dao.imagem img)
        {
            try
            {
                _ctx.DeleteObject(img);
                _ctx.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void SetPrincipal(int id, int idImovel)
        {
            dao.imagem img = (from i in _ctx.imagem where i.imovel.id_imovel == idImovel && i.ic_principal == true select i).First();
            img.ic_principal = false;

            dao.imagem img2 = (from i in _ctx.imagem where i.id_imagem == id select i).First();
            img2.ic_principal = true;

            _ctx.SaveChanges();
        }

        public bool Adicionar(dao.imagem img)
        {
            try
            {
                _ctx.AddToimagem(img);
                _ctx.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void DeletarImagensNaoAssociadas()
        {
            var query = from i in _ctx.imagem where i.imovel == null select i;

            foreach (var item in query)
            {
                _ctx.DeleteObject(item);                
            }

            _ctx.SaveChanges();
        }
    }
}
