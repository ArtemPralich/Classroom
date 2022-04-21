using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Classroom.BusinessLayer.Interfaces.Common;
using Classroom.Entities.Models;
using Classroom.Entities.RequestFeatures;

namespace Classroom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;
        public GroupController(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
        //public PageList<Group> GetAllProducts(int kindId, ProductParameters productParameters, bool trackChange)
        //{
        //    var products = await ReturnDistinct(e => (e.KindId.Equals(kindId)), trackChange).Include(u => u.Shipper)
        //        .FilterProduct(productParameters.MinPrice, productParameters.MaxPrice)
        //        .Search(productParameters.SearchTerm).OrderBy(e => e.Name)
        //        .Sort(productParameters.OrderBy).ToListAsync();

        //    return PagedList<Product>.ToPagedList(products, productParameters.PageNumber,
        //        productParameters.PageSize);
        //}
        //public async Task<Product> GetProductAsync(int kindId, int productId, bool trackChange) =>
        //    await ReturnDistinct(c => c.ProductId.Equals(productId) && c.KindId.Equals(kindId), trackChange).SingleOrDefaultAsync();

        //public Product GetProduct(int kindId, int productId, bool trackChange) =>
        //    ReturnDistinct(c => c.ProductId.Equals(productId) && c.KindId.Equals(kindId), trackChange).SingleOrDefault();

        //public void CreateProduct(int kindId, Product product)
        //{
        //    product.KindId = kindId;
        //    Create(product);
        //}
        //public void DeleteProduct(Product product)
        //{
        //    Delete(product);
        //}
    }
}
