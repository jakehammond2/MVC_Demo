using System;
using System.Data;
using Dapper;
using MVC_Demo.Models;

namespace MVC_Demo
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;

        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("SELECT * FROM PRODUCTS;");
        }
    }
}

