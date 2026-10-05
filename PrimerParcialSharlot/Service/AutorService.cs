using Aplicada1.Core;
using Microsoft.EntityFrameworkCore;
using PrimerParcialSharlot.Context;
using PrimerParcialSharlot.Model;
using System.Linq.Expressions;
using PrimerParcialSharlot.Service;
namespace PrimerParcialSharlot.Service;

public class AutorService (IDbContextFactory<Contexto> contextFactory
    ):IService<Autor, int>
{
    public async Task<bool> Guardar(Autor autor)
    {
        if (await Existe(autor.AutorId))
        {
            return await Insertar(autor);
        }
        else
        {
            return await Modificar(autor);
        }
    }
    private async Task<bool> Existe(int modelId)
    {
        throw new NotImplementedException();

    }

    private async Task<bool> Insertar(Autor model1)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Eliminar(int modelId)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Autor>> GetList(Expression<Func<Autor, bool>> criterio)
    {
        throw new NotImplementedException();
    }

    private async Task<bool> Modificar(Autor model1)
    {
        throw new NotImplementedException();
    }

    public async Task<Autor?> Buscar(int estudianteId)
    {
        throw new NotImplementedException();
    }
}
