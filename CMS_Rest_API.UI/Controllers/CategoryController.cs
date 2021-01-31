using AutoMapper;
using CMS_Rest_API.DataAccessLayer.Repository.Interfaces.EntityTypeRepository;
using CMS_Rest_API.EntityLayer.Entities.Concrete;
using CMS_Rest_API.EntityLayer.Enums;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<ActionResult<Category>> PostCategory(Category category)
        {
            await _categoryRepository.Add(category);
            await _categoryRepository.Save();
            return CreatedAtAction(nameof(GetCategories), category);
        
        }
       
    }
}
