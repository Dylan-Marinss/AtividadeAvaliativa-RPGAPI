using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RpgApi.Controllers;
using RpgApi.Data;
using RpgApi.Models;
using Microsoft.EntityFrameworkCore;

namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
       public class ArmasController : ControllerBase
    {
        private readonly DataContext _context;

        public ArmasController(DataContext context)
        {
            _context = context;
        }

         [HttpGet("GetAll")]
         public async Task<IActionResult> Get()
         {
            try
            {
                List<Arma> lista = await _context.TB_ARMA.ToListAsync();
                return Ok(lista);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
         }

        [HttpPost]
         public async Task<IActionResult> Add(Arma novaArma)
         {
            try
            {
                if(novaArma.Dano > 25)
                {
                    throw new Exception("O dano não pode ser maior que 25");
                }

                Personagem p = await _context.TB_PERSONAGENS.FirstOrDefaultAsync(p => p.Id == novaArma.PersonagemId);

                await _context.TB_ARMA.AddAsync(novaArma);
                await _context.SaveChangesAsync();

                return Ok(novaArma.Id);
            }
            catch (System.Exception ex) 
            {
                
                 return BadRequest(ex.Message);
            }
         }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            try
            {
                Arma a = await _context.TB_ARMA.FirstOrDefaultAsync(aBusca => aBusca.Id == id);

                
                return Ok(a);
            }
            catch (System.Exception ex)
            {
                
                return BadRequest(ex.Message);
            }
        }

          [HttpPut]
          public async Task<IActionResult> Update(Arma novaArma)
          {
            try
            {
                if(novaArma.Dano > 100)
                {
                    throw new Exception("O dano não pode ser maior que 25");
                }
                _context.TB_ARMA.Update(novaArma);
                int linhasAfetadas = await _context.SaveChangesAsync();

                return Ok(linhasAfetadas);
            }
            catch (System.Exception ex)
            {
                
                return BadRequest(ex.Message);
            }
          }

               [HttpDelete("{id}")]
          public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Arma aRemover = await _context.TB_ARMA.FirstOrDefaultAsync(a => a.Id == id);
                _context.TB_ARMA.Remove(aRemover);
                int linhasAfetadas = await _context.SaveChangesAsync();
                return Ok(linhasAfetadas);
            }
            catch (System.Exception ex)
            {
                
                return BadRequest(ex.Message);
            }


        }
    }
}
   

