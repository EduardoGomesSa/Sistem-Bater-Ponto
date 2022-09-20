using BaterPonto.Domain.Entities;
using BaterPonto.Infra.Interfaces;
using BaterPonto.Infra.Maps;

namespace BaterPonto.Infra.Repositories
{
    public class CargoRepository : BaseRepository<Cargo, CargoMap>, ICargoRepository
    {
    }
}
