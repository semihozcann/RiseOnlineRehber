using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RiseOnlineRehber.DataAccess.Mapping;
using RiseOnlineRehber.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiseOnlineRehber.DataAccess.Concrete
{
    public class RiseOnlieRehberContext : IdentityDbContext<User, Role, int, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {


        public RiseOnlieRehberContext()
        {

        }

        //configuration from settings
        public RiseOnlieRehberContext(DbContextOptions<RiseOnlieRehberContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    @"Server=DESKTOP-5R6CJJ3\SQLEXPRESS;Database=RiseOnlineRehberDb;Trusted_Connection=true");

            }
            base.OnConfiguring(optionsBuilder);



        }



        //db kurallarını burada db olusturken veriyoruz. 
        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfiguration(new RoleMap());
            builder.ApplyConfiguration(new UserMap());
            builder.ApplyConfiguration(new UserTokenMap());
            builder.ApplyConfiguration(new UserRoleMap());
            builder.ApplyConfiguration(new UserLoginMap());
            builder.ApplyConfiguration(new RoleClaimMap());
            builder.ApplyConfiguration(new UserClaimMap());



        }

        //public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        //{
        //    //ChangeTracker mekanizması varlıkların durumlarını takip eden bir yapıdır. Bu sayede işlem yaparken varlıklar üzerinde ne işlem yapıldığını anlayabilir. Burada Bundan faydalanarak varlıklar üzerindeki değişime göre işlem esnasında yapılmasını istediğimiz eylemleri gereçekleştirebiliriz.
        //    var datas = ChangeTracker.Entries<BaseEntity>(); // varlığın yakalanması
        //    foreach (var data in datas)
        //    {
        //        _ = data.State switch
        //        {
        //            EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow, //ekleme işlemi ise işlem anındaki tarihi CreatedDate stununa ekle
        //            EntityState.Modified => data.Entity.ModifiedDate = DateTime.UtcNow, //Güncelleme işlemi ise işlem anındaki tarihi UpdatedDate stununa ekle

        //            //Bu kısıma işlem anında yapılmasını istediğiniz şeyleri ekleyebilirsiniz.
        //        };
        //    }
        //    return base.SaveChangesAsync(cancellationToken); //Değişiklikleri kaydet
        //}
    }
}
