using System.Data.Entity;

namespace Model.EF
{
    public class BookstoreDbContext : DbContext
    {
        public BookstoreDbContext() : base("name=BookstoreDb1")
        {
        }


        public virtual DbSet<ChuDe> ChuDes { get; set; }
    }
}