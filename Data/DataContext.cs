using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using RpgApi.Models;
using RpgApi.Models.Enuns;
using RpgApi.Utils;

namespace RpgApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) //ctor
        {

        }

        public DbSet<Personagem> TB_PERSONAGENS { get; set; } //prop
        public DbSet<Arma> TB_ARMA { get; set; }
        public DbSet<Usuario> TB_USUARIOS {get; set;}
        public DbSet<Habilidade> TB_HABILIDADES {get; set;}
        public DbSet<PersonagemHabilidade> TB_PERSONAGENS_HABILIDADES {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Personagem>().ToTable("TB_PERSONAGENS");
            modelBuilder.Entity<Arma>().ToTable("TB_ARMA");
            modelBuilder.Entity<Usuario>().ToTable("TB_USUARIO");
            modelBuilder.Entity<Habilidade>().ToTable("TB_HABILIDADES");
            modelBuilder.Entity<PersonagemHabilidade>().ToTable("TB_PERSONAGENS_HABILIDADES");
            
            //Relacionamento One to many ( Um para muitos)
            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Personagens)
                .WithOne(e => e.Usuario)
                .HasForeignKey(e => e.UsuarioId)
                .IsRequired(false);


            modelBuilder.Entity<Personagem>()
                .HasOne(e => e.Arma)
                .WithOne(e => e.Personagem)
                .HasForeignKey<Arma>(e => e.PersonagemId)
                .IsRequired();


            modelBuilder.Entity<Personagem>().HasData
            

            (
            new Personagem() { Id = 1, Nome = "Jim Carry", PontosVida = 100, Forca = 17, Defesa = 23, Inteligencia = 33, Classe = ClasseEnum.Cavaleiro, UsuarioId = 1 },
            new Personagem() { Id = 2, Nome = "Valter Costa Junior", PontosVida = 100, Forca = 15, Defesa = 25, Inteligencia = 30, Classe = ClasseEnum.Cavaleiro, UsuarioId = 1 },
            new Personagem() { Id = 3, Nome = "Kishimoto", PontosVida = 100, Forca = 18, Defesa = 21, Inteligencia = 35, Classe = ClasseEnum.Clerigo, UsuarioId = 1 },
            new Personagem() { Id = 4, Nome = "Papai noel", PontosVida = 100, Forca = 18, Defesa = 18, Inteligencia = 37, Classe = ClasseEnum.Mago, UsuarioId = 1 },
            new Personagem() { Id = 5, Nome = "Robson", PontosVida = 100, Forca = 20, Defesa = 17, Inteligencia = 31, Classe = ClasseEnum.Cavaleiro, UsuarioId = 1 },
            new Personagem() { Id = 6, Nome = "Neymar", PontosVida = 100, Forca = 21, Defesa = 13, Inteligencia = 34, Classe = ClasseEnum.Clerigo, UsuarioId = 1 },
            new Personagem() { Id = 7, Nome = "Alex o leão", PontosVida = 100, Forca = 25, Defesa = 11, Inteligencia = 35, Classe = ClasseEnum.Mago, UsuarioId = 1 }
            );

           

            modelBuilder.Entity<Arma>().HasData
            (
                new Arma() { Id = 1, Nome = "Ak-47", Dano = 3, PersonagemId = 1},
                new Arma() { Id = 2, Nome = "Scar-L", Dano = 5, PersonagemId = 2},
                new Arma() { Id = 3, Nome = "Magnum", Dano = 6, PersonagemId = 3},
                new Arma() { Id = 4, Nome = ".38", Dano = 4, PersonagemId = 4},
                new Arma() { Id = 5, Nome = "Cacetete", Dano = 2, PersonagemId = 5},
                new Arma() { Id = 6, Nome = "MP-40", Dano = 7, PersonagemId = 6},
                new Arma() { Id = 7, Nome = "Deagle", Dano = 9, PersonagemId = 7}
            );

            modelBuilder.Entity<PersonagemHabilidade>()
            .HasKey(ph => new {ph.PersonagemId, ph.HabilidadeId});

            modelBuilder.Entity<Habilidade>().HasData
            ( 
                new Habilidade(){Id=1, Nome="Invocar o pai", Dano = 20 },
                new Habilidade(){Id=2, Nome="Arremeço de pastel", Dano = 10 },
                new Habilidade(){Id=3, Nome="Choque do trovão", Dano = 30 },
                new Habilidade(){Id=4, Nome="Saque de volei", Dano = 15 }
            );

            modelBuilder.Entity<PersonagemHabilidade>().HasData(
                new PersonagemHabilidade() {PersonagemId = 1, HabilidadeId = 1 },
                new PersonagemHabilidade() {PersonagemId = 2, HabilidadeId = 1 },
                new PersonagemHabilidade() {PersonagemId = 3, HabilidadeId = 2 },
                new PersonagemHabilidade() {PersonagemId = 4, HabilidadeId = 3 },
                new PersonagemHabilidade() {PersonagemId = 5, HabilidadeId = 1 },
                new PersonagemHabilidade() {PersonagemId = 6, HabilidadeId = 1 },
                new PersonagemHabilidade() {PersonagemId = 7, HabilidadeId = 4 }
            );

            Usuario user = new Usuario();
            Criptografia.CriarPassowordHash("123456", out byte[] hash, out byte[]salt);
            user.Id = 1;
            user.Username = "UsuarioAdmin";
            user.PasswordString = string.Empty;
            user.PasswordHash = hash;
            user.PasswordSalt = salt;
            user.Perfil = "Admin";
            user.Email = "emailaleatorio@gmail.com";
            user.Latitude = -23.5200241;
            user.Longitude = -46.596498;

            modelBuilder.Entity<Usuario>().HasData(user);
            //

            //Define que se o perfil não for informado, o valor padrão será jogador
            modelBuilder.Entity<Usuario>().Property( u => u.Perfil).HasDefaultValue("Jogador");

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }



        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<String>().HaveColumnType("varchar").HaveMaxLength(200);
        }




    }
}