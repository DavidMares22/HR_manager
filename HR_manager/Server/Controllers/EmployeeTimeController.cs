using AutoMapper;
using HR_manager.Server.Data;
using HR_manager.Server.IRepository;
using HR_manager.Server.Models;
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
    public class EmployeeTimeController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EmployeeTimeController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllEmpTime()
        {
            try
            {
                var empTime = await _unitOfWork.EmployeeTime.GetAll();
                var results = _mapper.Map<IList<EmpTimeDTO>>(empTime);
                return Ok(results);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error. Please Try Again Later.");
            }
        }

        [HttpGet("{id:int}", Name = "GetEmployeeTime")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetEmployeeTime(int id)
        {
            try
            {
                var empTime = await _unitOfWork.EmployeeTime.Get(q => q.Id == id);
                var result = _mapper.Map<EmpTimeDTO>(empTime);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error. Please Try Again Later.");
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateEmployeeTime([FromBody] EmpTimeDTO empTimeDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var empTime = _mapper.Map<EmployeeTime>(empTimeDTO);
                await _unitOfWork.EmployeeTime.Insert(empTime);
                await _unitOfWork.Save();

                return CreatedAtRoute("GetLoggedTime", new { id = empTime.Id }, empTime);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error. Please Try Again Later.");
            }
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteEmpTime(int id)
        {
            if (id < 1)
            {
                return BadRequest();
            }

            try
            {
                var lt = await _unitOfWork.EmployeeTime.Get(q => q.FK_EmployeeTime_to_LoggedTime == id);
                if (lt == null)
                {
                    return BadRequest("Submitted data is invalid");
                }

                await _unitOfWork.EmployeeTime.Delete(lt.Id);
                await _unitOfWork.Save();

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error. Please Try Again Later.");
            }
        }
    }
}
