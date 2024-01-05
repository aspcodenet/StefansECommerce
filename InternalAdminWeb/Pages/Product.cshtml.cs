using BusinessLogic;
using BusinessLogic.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InternalAdminWeb.Pages
{
    public class ProductModel : PageModel
    {
        public Product TheProduct { get; set; }

        public void OnGet(int productId)
        {
            TheProduct = new NameService().GetAllProducts().First(p => p.ProductId== productId);
        }
    }
}
