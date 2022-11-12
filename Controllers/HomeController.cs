using FrontToBackKarmaDataBase.DAL;
using FrontToBackKarmaDataBase.Models;
using Microsoft.AspNetCore.Mvc;

namespace FrontToBackKarmaDataBase.Controllers
{
    public class HomeController : Controller
    {

        //private readonly AppDbContext _appDbContext;

        //public HomeController(AppDbContext appDbContext)
        //{
        //    _appDbContext = appDbContext;
        //}
        public IActionResult Index()
        {
            //var products = _appDbContext.Products.ToList();
            //var categories = _appDbContext.Categories.ToList();
            var categories = new List<Category>
            {
                new Category()
                {
                    Id = 1,
                    Name = "Sneaker for Sports",
                    CategoryImage = "c1.jpg"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Sneaker for Couple",
                    CategoryImage = "c2.jpg"
                },
                new Category()
                {
                    Id = 3,
                    Name = "Casual",
                    CategoryImage = "c3.jpg"
                },
                new Category()
                {
                    Id = 4,
                    Name = "Usnisex Sneakers",
                    CategoryImage = "c4.jpg"
                }
            };
            var products = new List<Product>();
            products.Add(new Product()
            {
                Id = 1,
                Name = "Nike",
                ImageURL = "p1.jpg",
                Price  = 150,
                CategoryId = 1,
                
            });
            products.Add(new Product()
            {
                Id = 2,
                Name = "Adidas",
                ImageURL = "p2.jpg",
                Price = 190,
                CategoryId = 1,

            });
            products.Add(new Product()
            {
                Id = 3,
                Name = "Puma",
                ImageURL = "p3.jpg",
                Price = 170,
                CategoryId = 2,

            });
            products.Add(new Product()
            {
                Id = 4,
                Name = "Nike Air",
                ImageURL = "p4.jpg",
                Price = 150,
                CategoryId = 2,

            });
            products.Add(new Product()
            {
                Id = 5,
                Name = "Skeaker",
                ImageURL = "p5.jpg",
                Price = 100,
                CategoryId = 3,

            });

            var homeViewModel = new HomeViewModel
            {
                Categories = categories,
                Products = products
            };
            return View(homeViewModel);


        }
    }
}
