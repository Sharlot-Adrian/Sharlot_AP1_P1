using Aplicada1.Core;
using Microsoft.EntityFrameworkCore;
using PrimerParcialSharlot.Context;
using PrimerParcialSharlot.Model;

namespace PrimerParcialSharlot.Service;

public class Model1Service (IDbContextFactory<Contexto> contextFactory
    ):IService<Model1, int>
{
}
