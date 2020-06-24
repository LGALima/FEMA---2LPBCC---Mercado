using Mercado_Thay_and_Lusca.CAMADAS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado_Thay_and_Lusca.CAMADAS.BLL
{
    public class CategoriaBLL
    {
        public List<MODEL.Categoria> SelectAll()
        {
            DAL.CategoriaDAL catDal = new DAL.CategoriaDAL();
            return catDal.SelectAll();
        }

        public List<MODEL.Categoria> SelectById(int id)
        {
            DAL.CategoriaDAL catDal = new DAL.CategoriaDAL();
            return catDal.SelectById(id);
        }
        public List<MODEL.Categoria> SelectByDescricao(string descricao)
        {
            DAL.CategoriaDAL catDal = new DAL.CategoriaDAL();
            return catDal.SelectByDescricao(descricao);
        }

        public void Insert(MODEL.Categoria categoria)
        {
            DAL.CategoriaDAL catDal = new DAL.CategoriaDAL();
            catDal.Insert(categoria);
        }

        public void Update(MODEL.Categoria categoria)
        {
            DAL.CategoriaDAL catDal = new DAL.CategoriaDAL();
            catDal.Update(categoria);
        }
        public void Delete(MODEL.Categoria categoria)
        {
            DAL.CategoriaDAL catDal = new DAL.CategoriaDAL();
            catDal.Delete(categoria);
        }
    }
}
