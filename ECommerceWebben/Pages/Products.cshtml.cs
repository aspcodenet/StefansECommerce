using BusinessLogic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECommerceWebben.Pages
{
    public class ProductsModel : PageModel
    {
        public string ProductName{get;set; }
        public List<string> AllProducts { get; set; }
        public void OnGet()
        {
            var nameService = new NameService();
            ProductName = nameService.GetName(12);
            AllProducts = nameService.GetAllNames();
        }
    }
}
