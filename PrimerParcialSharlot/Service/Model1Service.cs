using Aplicada1.Core;
using Microsoft.EntityFrameworkCore;
using PrimerParcialSharlot.Context;
using PrimerParcialSharlot.Model;
using System.Linq.Expressions;

namespace PrimerParcialSharlot.Service;

public class Model1Service (IDbContextFactory<Contexto> contextFactory
    ):IService<Model1, int>
{
    public async Task<bool> Guardar(Model1 model1)
    {
        throw new NotImplementedException();
    }
    private async Task<bool> Existe(int modelId)
    {
        throw new NotImplementedException();
    }

    private async Task<bool> Insertar(Model1 model1)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Eliminar(int modelId)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Model1>> GetList(Expression<Func<Model1, bool>> criterio)
    {
        throw new NotImplementedException();
    }

    private async Task<bool> Modificar(Model1 model1)
    {
        throw new NotImplementedException();
    }

    public async Task<Model1?> Buscar(int estudianteId)
    {
        throw new NotImplementedException();
    }
}
