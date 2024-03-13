using FoodyTekmerEntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodyTekmerDataAccessLayer.AppDbContext
{
    public class FoodyContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-I6R5PF8\\SQLEXPRESS; initial catalog=FoodyTekmerDB; integrated security=true;");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public  DbSet<Testimonial> Testimonials { get; set; }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<CustomerReview> CustomerReviews { get; set; }
        public DbSet<OurFeature> OurFeatures { get; set; }
        public DbSet<VisitOurFirm> visitOurFirms { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }

    }
}
