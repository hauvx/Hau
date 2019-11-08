using TeamOK;
using TeamOK.Data;
using TeamOK.Models;
using System.Collections.Generic;
namespace TeamOK.ViewModels
{
    public class ListItemProductsViewModel
    {
        public int CurrentPage { get; set; }
        public int TotalPage {get; set;}
        public IEnumerable<ItemProductsViewModel> ItemProducts {get;set;}

    }
}