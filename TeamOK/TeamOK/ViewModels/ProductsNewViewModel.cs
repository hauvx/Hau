using TeamOK.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace TeamOK.ViewModels
{
    public class ProductsNewViewModel
    {
        public Product Product { get; set; }
        public IEnumerable<ProductBrand> ProductBrands { get; set; }
        public IEnumerable<ProductType> ProductTypes { get; set; }
        public IEnumerable<Admin> Admins { get; set; }
        public IFormFile Thumbnail {get;set;}
    }
}