using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RpgApi.Models;
using RpgApi.Models.Enuns;

namespace RpgApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) //ctor
        {

        }

        public DbSet<Personagem> TB_PERSONAGENS { get; set; } //prop

        public DbSet<Arma> TB_ARMA { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personagem>().ToTable("TB_PERSONAGENS");

            modelBuilder.Entity<Personagem>().HasData
            (
            new Personagem() { Id = 1, Nome = "Jim Carry", PontosVida = 100, Forca = 17, Defesa = 23, Inteligencia = 33, Classe = ClasseEnum.Cavaleiro },
            new Personagem() { Id = 2, Nome = "Valter Costa Junior", PontosVida = 100, Forca = 15, Defesa = 25, Inteligencia = 30, Classe = ClasseEnum.Cavaleiro },
            new Personagem() { Id = 3, Nome = "Kishimoto", PontosVida = 100, Forca = 18, Defesa = 21, Inteligencia = 35, Classe = ClasseEnum.Clerigo },
            new Personagem() { Id = 4, Nome = "Papai noel", PontosVida = 100, Forca = 18, Defesa = 18, Inteligencia = 37, Classe = ClasseEnum.Mago },
            new Personagem() { Id = 5, Nome = "Robson", PontosVida = 100, Forca = 20, Defesa = 17, Inteligencia = 31, Classe = ClasseEnum.Cavaleiro },
            new Personagem() { Id = 6, Nome = "Neymar", PontosVida = 100, Forca = 21, Defesa = 13, Inteligencia = 34, Classe = ClasseEnum.Clerigo },
            new Personagem() { Id = 7, Nome = "Alex o leão", PontosVida = 100, Forca = 25, Defesa = 11, Inteligencia = 35, Classe = ClasseEnum.Mago }
            );

            modelBuilder.Entity<Arma>().ToTable("TB_ARMA");

            modelBuilder.Entity<Arma>().HasData
            (
                new Arma() { Id = 1, Nome = "Ak-47", Dano = 3},
                new Arma() { Id = 2, Nome = "Scar-L", Dano = 5},
                new Arma() { Id = 3, Nome = "Magnum", Dano = 6},
                new Arma() { Id = 4, Nome = ".38", Dano = 4},
                new Arma() { Id = 5, Nome = "Cacetete", Dano = 2},
                new Arma() { Id = 6, Nome = "MP-40", Dano = 7},
                new Arma() { Id = 7, Nome = "Deagle", Dano = 9}
            );


        }

     

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<String>().HaveColumnType("varchar").HaveMaxLength(200);
        }




    }
}