using Api_teste.Models;

namespace Api_teste.Repositores
{
    public interface IRepositorio
    {
        Task<CarrosModel> Create(CarrosModel carros);
        Task Update(CarrosModel carros);

        Task Delete(int id);

        Task<CarrosModel> Get(int id);

        Task<IEnumerable<CarrosModel>> Get();

    }
}
