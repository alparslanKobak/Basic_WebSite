using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    // InMemoryDb kullanabilmek için projeye sağ tık nuget package manager menüsünü açarak oradan Browse sekmesinden Inmemory paketini ve entity frameworkcore.design paketlerini yüklüyoruz.
    public class UyeContext : DbContext
    {
        // Bu bizim database setimiz
        public DbSet<Uye> Uyes { get; set; }

        // Override yazarak onconfiguring'e tıklayıp elde ettik.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            // EntityFrameworkCore veritabanı işlemleri için yapılandırma ayarları yapabildiğimiz metot.
            optionsBuilder.UseInMemoryDatabase("InMemoryDb"); // Bilgisayarımızın ram belleğini sanal veritabanı olarak kullanmasını sağlayan ayarı yaptık.
            
            // Bu ayardan sonra projemizin program.cs classına gidip bu UyeContext sınıfını servis olarak ekliyoruz.
            base.OnConfiguring(optionsBuilder);
        }

        

        

    }
}
