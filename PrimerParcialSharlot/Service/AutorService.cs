using Aplicada1.Core;
using Microsoft.EntityFrameworkCore;
using PrimerParcialSharlot.Context;
using PrimerParcialSharlot.Model;
using System.Linq.Expressions;
using PrimerParcialSharlot.Service;
using Microsoft.IdentityModel.Tokens;
namespace PrimerParcialSharlot.Service;

public class AutorService (IDbContextFactory<Contexto> contextFactory
    ):IService<Autor, int>
{
    public async Task<bool> Guardar(Autor autor)
    {
        if (await ExisteAutor( autor.Nombres,autor.AutorId))
        {
            return false;
        }

        if(! await Existe(autor.AutorId))
        {
            return await Insertar(autor);
        }
        else
        {
            return await Modificar(autor);
        }
    }
    private async Task<bool> Existe(int autorId)
    {
        await using var contexto = await contextFactory.CreateDbContextAsync();
        return await contexto.Autores.AnyAsync(a => a.AutorId == autorId);

    }

    private async Task<bool> Insertar(Autor autorId)
    {
        await using var contexto = await contextFactory.CreateDbContextAsync();
        contexto.Autores.Add(autorId);
        return await contexto.SaveChangesAsync() > 0;
    }

    public async Task<bool> Eliminar(int autorId)
    {
        await using var contexto = await contextFactory.CreateDbContextAsync();
        return await contexto.Autores.Where(a => a.AutorId == autorId).ExecuteDeleteAsync() > 0;
    }

    public async Task<List<Autor>> GetList(Expression<Func<Autor, bool>> criterio)
    {
        await using var contexto = await contextFactory.CreateDbContextAsync();
        return await contexto.Autores
            .Where(criterio)
            .AsNoTracking()
            .ToListAsync();
    }

    private async Task<bool> Modificar(Autor autor)
    {
        await using var contexto = await contextFactory.CreateDbContextAsync();
        contexto.Autores.Update(autor);
        return await contexto.SaveChangesAsync() > 0;   
    }

    public async Task<Autor?> Buscar(int autorId)
    {
        await using var contexto = await contextFactory.CreateDbContextAsync();
        return await contexto.Autores.FirstOrDefaultAsync( a => a.AutorId == autorId);
    }

    private async Task<bool> ExisteAutor(string Autor, int AutorId)
    {
        await using var contexto = await contextFactory.CreateDbContextAsync();
        return await contexto.Autores.AnyAsync(a => a.Nombres.ToLower() == Autor.ToLower() && a.AutorId != AutorId);
    }
}
