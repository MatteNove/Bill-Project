using System;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1;

// 1. IL CONTESTO DEL DATABASE
public class AppDbContext : DbContext
{
    public DbSet<Bill> Bills { get; set; }
    public DbSet<BillType> BillTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=database.db");
    }
}

// 2. LA CLASSE BILL
public class Bill
{
    public int Id { get; set; }
    public double Prezzo { get; set; }
    public DateTime Data { get; set; }
    public bool Pagata { get; set; }
    public int BillTypeId { get; set; }
}

// 3. LA CLASSE BILLTYPE
public class BillType
{
    public int Id { get; set; }
    public string Tipo { get; set; } = string.Empty;
}