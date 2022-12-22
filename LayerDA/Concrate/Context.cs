using LayerE.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerDA.Concrate
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-II3JBPE\\SQLEXPRESS01;database=BlogumDB; integrated security=true;"); 
        }
        public DbSet<YAbout> YAbouts { get; set; }
        public DbSet<YBlog> YBlogs { get; set; }
        public DbSet<YCategory> YCategories { get; set; }
        public DbSet<YThought> YThoughts { get; set; }
        public DbSet<YAskUs> YAskUss { get; set; }
        public DbSet<YWriter> YWriters { get; set; }
    }
}
