using DataAccsesLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussiniesLayer.Concreate
{
    public class CategoryManager
    {
        GenericRepositry<Category> repo = new GenericRepositry<Category>();

        public List<Category> GetAll()
        {
            return repo.Liste();
        }

        public void CategoryAddBl(Category p)
        {
            if (p.CategoryName=="" || p.CategoryName.Length<=3)
            {
                //hata mesajı
            }
            else
            {
                repo.Insert(p);
            }
        }
    }
}
