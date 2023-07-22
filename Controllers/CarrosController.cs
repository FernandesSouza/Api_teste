using Api_teste.Models;
using Api_teste.Repositores;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client.Extensions.Msal;
using System.IO;

namespace Api_teste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrosController : ControllerBase
    {

        private readonly IRepositorio _irepositorio;
        public CarrosController(IRepositorio irepositorio)
        {
            _irepositorio = irepositorio;


        }

        [HttpGet]
        public async Task<IEnumerable<CarrosModel>> GetCarros()
        {

            return await _irepositorio.Get();


        }

        [HttpPost]
        public async Task<ActionResult<CarrosModel>> PostCarros([FromBody] CarrosModel carros)
        {

            var Newcarro = await _irepositorio.Create(carros);

            return CreatedAtAction(nameof(GetCarros), new { id = Newcarro.Id }, Newcarro);


        }
        [HttpDelete]

        public async Task<ActionResult> Delete(int id)
        {
            var delete = await _irepositorio.Get(id);
            if (delete == null)
                return NotFound();

            await _irepositorio.Delete(delete.Id);


            return Ok();

            


        }
        [HttpPut]

        public async Task<ActionResult<CarrosModel>> Update(int id,[FromBody]CarrosModel carros)
        {


            if (id != carros.Id)

                return NotFound();


            await _irepositorio.Update(carros);

            return NoContent();

        }

        [HttpGet("{id}")]

        public async Task<ActionResult<CarrosModel>> Get(int id)
        {

            return await _irepositorio.Get(id);


        }



    }
}
