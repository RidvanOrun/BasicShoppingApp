using AutoMapper;
using CMS_Rest_API.DataAccessLayer.Repository.Interfaces.EntityTypeRepository;
using CMS_Rest_API.EntityLayer.Entities.Concrete;
using CMS_Rest_API.EntityLayer.Enums;
using CMS_Rest_API.UI.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_Rest_API.UI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryRepository categoryRepository, IMapper mapper)
        {            
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<Category>> GetCategories() => await _categoryRepository.Get(x => x.Status !=Status.Passive);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpGet("{int:id}", Name = "GetCategoryById")]
        public async Task<ActionResult<Category>> GetCategoryById(int id) 
        {
            await _categoryRepository.GetById(id);

            if (_categoryRepository==null)
            {
                return NotFound();
            }
            return Ok(_categoryRepository);
        
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet("{categorySlug}", Name = "GetCategorySlug")]

        public async Task<ActionResult<Category>> GetCategoryBySlug(string categorySlug)
        {
            await _categoryRepository.FirstOrDefault(x => x.Slug == categorySlug);

            if (_categoryRepository==null)
            {
                return NotFound();
            }
            return Ok(_categoryRepository);        
        }

        [HttpPost]
        public async Task<ActionResult<Category>> PostCategory(CategoryDTO categoryDTO)
        {
            var categoryObject = _mapper.Map<Category>(categoryDTO);
            await _categoryRepository.Add(categoryObject);          
            return CreatedAtAction(nameof(GetCategories), categoryDTO);
        
        }

        [HttpPut("{id}", Name = "PutCategory")]
        public async Task<ActionResult<Category>> PutCategory(int id,CategoryDTO categoryDTO) 
        {
            if (id!=categoryDTO.id)
            {
                return BadRequest();
            }

            var categoryObject = _mapper.Map<Category>(categoryDTO);
            await _categoryRepository.Update(categoryObject);
            return CreatedAtAction(nameof(GetCategories), categoryDTO);

        }

        [HttpDelete("{int:id}", Name = "DeleteCategory")]
        public async Task<ActionResult<Category>> DeleteCategory(int id, CategoryDTO categoryDTO)
        {
            await _categoryRepository.FindByDefault(x => x.Id == id);

            if (_categoryRepository == null)
            {
                NotFound();
            }

            var categoryObject = _mapper.Map<Category>(categoryDTO);
            await _categoryRepository.Delete(categoryObject);
            return NoContent(); // => Status code 204 dönüyor.
        }

    }
}
