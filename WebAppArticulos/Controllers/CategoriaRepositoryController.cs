using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebAppArticulos.Models;
using WebAppArticulos.Repositories;

namespace WebAppArticulos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaRepositoryController : ControllerBase
    {
        private ICategoriaRepository _categoriaRepository;

        public CategoriaRepositoryController(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        //get all
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                //obtenemos la informacion
                var categorias = _categoriaRepository.FindAllCategories().ToList();
                return Ok(categorias);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            
        }
        //un post que inserte o modifique una categoria
        [HttpPost]
        public IActionResult Post([FromBody] Categoria categoria)
        {
            try
            {
                if(String.IsNullOrEmpty(categoria.Nombre))
                {
                    return StatusCode(403, "Nombre de categoria vacio");
                }
                _categoriaRepository.Save(categoria);
                return Ok(categoria);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpDelete]
        public IActionResult Delete([FromBody] Categoria categoria)
        {
            try
            {
                _categoriaRepository.DeleteCategoria(categoria);

                return Ok("Eliminado con exito");
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
