using System;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1;

// 1. IL CONTESTO DEL DATABASE
public class AppDbContext : DbContext
{
    public DbSet<Tassa> Tasse { get; set; }
    public DbSet<Tipologia> Tipologie { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=database.db");
    }
}

// 2. LA CLASSE TASSA
public class Tassa
{
    public int Id { get; set; }
    public double Prezzo { get; set; }
    public DateTime Data { get; set; }
    public bool Pagata { get; set; }
    public int TipologiaId { get; set; }
}

// 3. LA CLASSE TIPOLIGIA
public class Tipologia
{
    public int Id { get; set; }
    public string Tipo { get; set; } = string.Empty;
}