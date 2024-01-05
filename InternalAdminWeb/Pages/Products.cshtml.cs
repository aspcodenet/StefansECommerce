using BusinessLogic;
using BusinessLogic.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InternalAdminWeb.Pages
{
    public class ProductsModel : PageModel
    {
        public List<Product> AllProducts { get; set; }
        public string StefansName { get; set; }

        public void OnGet()
        {
            StefansName = "Hej";
            var nameService = new NameService();
            AllProducts = nameService.GetAllProducts();
        }
    }
}
