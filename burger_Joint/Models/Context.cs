using System.Xml;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using burger_Joint.Models;

public class Context : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Store> Stores { get; set; }
    public DbSet<Administrator> Administrators { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseMySql("server=127.0.0.1;port=3306;uid=root;pwd=Dela1234#;database=burger_joint", 
                Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.31-mysql"));
        }
    }
}