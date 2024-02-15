using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAceessLayer.Repo.IRepo
{
    public interface IProductRepository : IRepository<Product> 
    {
        int Update(Product product);
    }
}
