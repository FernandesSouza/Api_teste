using Api_teste.Data;
using Api_teste.Models;
using Microsoft.EntityFrameworkCore;

namespace Api_teste.Repositores
{
    public class Repositorio : IRepositorio
    {

        private readonly BancoContext _context;
        public Repositorio( BancoContext context)
        {
            _context = context;
        }
        public async Task<CarrosModel> Create(CarrosModel carros)
        {

            _context.Carros.Add(carros);
          await _context.SaveChangesAsync();
            return carros;
            
        }

        public async Task Delete(int id)
        {
            var carroDelete = await _context.Carros.FindAsync(id);
            if (carroDelete == null) return;
            _context.Carros.Remove(carroDelete);
            await _context.SaveChangesAsync();
            
        }

        public async Task<CarrosModel> Get(int id)
        {
            var carro = await _context.Carros.FindAsync(id);
            return carro!;

        }

        public async Task<IEnumerable<CarrosModel>> Get()
        {
            return await _context.Carros.ToListAsync();
          
        }

        public async Task Update(CarrosModel carros)
        {

            _context.Entry(carros).State = EntityState.Modified;
            await _context.SaveChangesAsync();
           
        }
    }
}
