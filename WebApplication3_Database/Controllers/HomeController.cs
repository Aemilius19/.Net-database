using Microsoft.AspNetCore.Mvc;
using WebApplication3_Database.DAL;
using WebApplication3_Database.Models;
using WebApplication3_Database.ViewModel;

namespace WebApplication3_Database.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext _dbcontext;
        public HomeController(AppDbContext dbContext)
        {
            _dbcontext = dbContext;
        }

        public IActionResult Index()
        {
            HomeVM vm = new HomeVM();
            //Slider slider = new Slider()
            //{
            //    Title = "AB105_Logistics",
            //    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Molestie nunc non blandit massa enim nec dui nunc mattis. Dui vivamus arcu felis bibendum ut. Tellus pellentesque eu tincidunt tortor aliquam nulla facilisi cras fermentum. Ut enim blandit volutpat maecenas volutpat blandit aliquam. Eu tincidunt tortor aliquam nulla facilisi cras fermentum. Proin sed libero enim sed faucibus turpis in eu. Aliquam eleifend mi in nulla. Mi sit amet mauris commodo quis imperdiet. Nullam eget felis eget nunc lobortis.",
            //    PhotoUrl = "carousel-1.jpg"
            //};
            //List<Slider> list = new List<Slider>() ;
            //list.Add(slider);
            //list.Add(new Slider() 
            //{ 
            //    Title= "AB106_Logistics",
            //    Description= "Eu turpis egestas pretium aenean pharetra magna ac placerat vestibulum. Mauris augue neque gravida in fermentum et. Justo nec ultrices dui sapien eget mi. Nisl nunc mi ipsum faucibus vitae aliquet. Elementum curabitur vitae nunc sed velit dignissim sodales ut. Lectus proin nibh nisl condimentum id venenatis a condimentum vitae. Maecenas sed enim ut sem viverra. Iaculis nunc sed augue lacus viverra. Magna fermentum iaculis eu non diam phasellus. Duis ultricies lacus sed turpis. Et pharetra pharetra massa massa ultricies. Ut porttitor leo a diam sollicitudin tempor id eu.",
            //    PhotoUrl="carousel-2.jpg"

            //});

            //_dbcontext.Sliders.AddRange(list);
            //_dbcontext.SaveChanges();
            //List<Testimonial> list1= new List<Testimonial>() ;
            //list1.Add(new Testimonial()
            //{ 
            //    Name="Emil",
            //    Position="student",
            //    Commit="lorem ipsum",
            //    PfpUrl="testimonial-1.jpg"

            //});
            //list1.Add(new Testimonial()
            //{
            //    Name = "Leman",
            //    Position = "cleaner",
            //    Commit = "Volutpat ac tincidunt vitae semper quis. Posuere sollicitudin aliquam ultrices sagittis orci a. ",
            //    PfpUrl = "testimonial-2.jpg"

            //});
            //list1.Add(new Testimonial()
            //{
            //    Name = "Orxan",
            //    Position = "voluntuer",
            //    Commit = "Volutpat diam ut venenatis tellus in metus vulputate eu. Volutpat lacus laoreet non curabitur gravida arcu. ",
            //    PfpUrl = "testimonial-3.jpg"

            //});
            //list1.Add(new Testimonial()
            //{
            //    Name = "Resul",
            //    Position = "proffesor",
            //    Commit = "Bibendum at varius vel pharetra vel turpis nunc. Velit dignissim sodales ut eu sem integer. ",
            //    PfpUrl = "testimonial-4.jpg"

            //});
            //_dbcontext.Tests.AddRange(list1);
            //_dbcontext.SaveChanges();

            vm.Slider = _dbcontext.Sliders.ToList();
            vm.Testimonial = _dbcontext.Tests.ToList();
            return View(vm);


        }
    }
}
