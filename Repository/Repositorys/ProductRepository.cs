using Domain.Contractss;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositorys
{
    public class ProductRepository :BaseRepository<Product>,IProductRepository
    {
    }
}
