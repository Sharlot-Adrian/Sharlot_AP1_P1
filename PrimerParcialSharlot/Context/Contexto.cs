using Microsoft.EntityFrameworkCore;
using PrimerParcialSharlot.Model;

namespace PrimerParcialSharlot.Context;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }

    public DbSet<Autor> Autores { get; set; }
}
