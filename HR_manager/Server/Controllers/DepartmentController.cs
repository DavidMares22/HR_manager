using AutoMapper;
using HR_manager.Server.IRepository;
using HR_manager.Server.Models;
using HR_manager.Shared.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_manager.Server.Controllers
{
   

    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DepartmentController(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetDepartments()
        {
            try
            {
                var departments = await _unitOfWork.Departments.GetAll();
                var results = _mapper.Map<IList<DepartmentDTO>>(departments);
                return Ok(results);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error. Please Try Again Later.");
            }
        }

        [HttpGet("{id:int}", Name = "GetDepartment")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetDepartment(int id)
        {
            try
            {
                var department = await _unitOfWork.Departments.Get(q => q.Id == id, new List<string> { "Employees" });
                var result = _mapper.Map<DepartmentDTO>(department);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error. Please Try Again Later.");
            }
        }

        [Authorize]
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateDepartment(int id, [FromBody] CreateDepartmentDTO departmentDTO)
        {
            if (!ModelState.IsValid || id < 1)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var department = await _unitOfWork.Departments.Get(q => q.Id == id);
                if (department == null)
                {
                    return BadRequest("Submitted data is invalid");
                }

                _mapper.Map(departmentDTO, department);
                _unitOfWork.Departments.Update(department);
                await _unitOfWork.Save();

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error. Please Try Again Later.");
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateDepartment([FromBody] CreateDepartmentDTO departmentDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var department = _mapper.Map<Department>(departmentDTO);
                await _unitOfWork.Departments.Insert(department);
                await _unitOfWork.Save();

                return CreatedAtRoute("GetDepartment", new { id = department.Id }, department);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error. Please Try Again Later.");
            }
        }

    }
}
