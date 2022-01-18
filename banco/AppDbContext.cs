using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiBRQ.banco;


namespace ApiBRQ.banco
{
    public class AppDbContext : DbContext
    {
        

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<States> States { get; set; }

        public DbSet<Cities> Cities { get; set;}

        public DbSet<Products> Products { get; set;}

        public DbSet<Clients> Clients { get; set; }

        public DbSet<SellCar> Sell_Car { get; set; }






        //protected override void OnModelCreating(ModelBuilder modelBuilder) 
        //{
        //   modelBuilder.Entity<User>()
        //        .HasData(

        //           new User { Id = 5, Name = "Adolfo", Sobrenome = "core", Funcao = "programador" },
        //           new User { Id = 6, Name = "Ronaldo", Sobrenome = "femo", Funcao = "programador" },
        //           new User { Id = 7, Name = "Gilberto", Sobrenome = "silva", Funcao = "programador" }


        //        ); 
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //    {
        //        modelBuilder.Entity<NotaFiscal>()
        //            .HasData(

        //                new NotaFiscal {Notafiscal_id = 1, Chave_nf = "41210824932919000181550010000308631441208251", Number_nf = 030863, Cnpj_Client = 249329190000181, Natureza_op = "Venda de mercadoria"}

        //            );

        //    }


        //protected override void OnModelCreating(ModelBuilder modelBuilder) 
        //{
        //   modelBuilder.Entity<User>()
        //        .HasData(

        //           new User { Id = 5, Name = "Adolfo", Sobrenome = "core", Funcao = "programador" },
        //           new User { Id = 6, Name = "Ronaldo", Sobrenome = "femo", Funcao = "programador" },
        //           new User { Id = 7, Name = "Gilberto", Sobrenome = "silva", Funcao = "programador" }


        //        ); 
        //}


    }
}
