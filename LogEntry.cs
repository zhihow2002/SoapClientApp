using System;
using Microsoft.EntityFrameworkCore;

public class LogEntry
{
    public int Id { get; set; }
    public string Request { get; set; }
    public string Response { get; set; }
    public DateTime Timestamp { get; set; }
}

public class LoggingContext : DbContext
{
    public DbSet<LogEntry> Logs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=SOAPClient;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=True");
    }
}
