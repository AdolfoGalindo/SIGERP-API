﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SIGERP_API.Context;
using SIGERP_API.Models;
using SIGERP_API.Repositories;

namespace SIGERP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CultivoController
    {
        private ICultivoRepository cultivoRepository;

        public CultivoController(ICultivoRepository cultivoRepository)
        {
            this.cultivoRepository = cultivoRepository;
        }

        // GET: api/Cultivo
        [HttpGet]
        public async Task<IEnumerable<Cultivo>> GetCultivos()
        {
            return await cultivoRepository.GetAllAsync();
        }
        
        // GET: api/Cultivo/5
        [HttpGet("{id}")]
        public async Task<Cultivo> GetCultivo(int id)
        {
            var cultivo = await cultivoRepository.GetByIdAsync(id);

            //if (cultivo == null)
            //{
            //    return new NotFoundResult($"No se encontro el cultivo con el {id}.");
            //}
            return cultivo;
        }
        
        // PUT: api/Cultivo/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task PutCultivo(int id, Cultivo cultivo)
        {
            //if (id != cultivo.CultId)
            //{
            //    return BadRequest();
            //}

            //_context.Entry(cultivo).State = EntityState.Modified;

            //try
            //{
            //    await _context.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!CultivoExists(id))
            //    {
            //        return NotFound();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            //return NoContent();
            await cultivoRepository.UpdateAsync(id, cultivo);
        }
        
        // POST: api/Cultivo
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<Cultivo> PostCultivo(Cultivo cultivo)
        {
            //_context.Cultivos.Add(cultivo);
            //try
            //{
            //    await _context.SaveChangesAsync();
            //}
            //catch (DbUpdateException)
            //{
            //    if (CultivoExists(cultivo.CultId))
            //    {
            //        return Conflict();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            //return CreatedAtAction("GetCultivo", new { id = cultivo.CultId }, cultivo);

            return await cultivoRepository.AddAsync(cultivo);
        }
        
        // DELETE: api/Cultivo/5
        [HttpDelete("{id}")]
        public Task DeleteCultivo(int id)
        {
            //var cultivo = await _context.Cultivos.FindAsync(id);
            //if (cultivo == null)
            //{
            //    return NotFound();
            //}

            //_context.Cultivos.Remove(cultivo);
            //await _context.SaveChangesAsync();

            //return NoContent();

            return cultivoRepository.DeleteAsync(id);
        }
        /*
        private bool CultivoExists(int id)
        {
            return _context.Cultivos.Any(e => e.CultId == id);
        }
        */
    }
}
