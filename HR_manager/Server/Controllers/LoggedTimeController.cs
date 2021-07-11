using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HR_manager.Server.IRepository;
using HR_manager.Server.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HR_manager.Server.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace HR_manager.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoggedTimeController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly UserManager<ApiUser> _userManager;


        public LoggedTimeController(IUnitOfWork unitOfWork, IMapper mapper ,UserManager<ApiUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _userManager = userManager;
        }




        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> UpdateLoggedTime(int id, [FromBody] UpdateTimeDTO loggedDTO)
        {
            var currentUserID = "";
            ClaimsPrincipal currentUser = this.User;
             currentUserID = currentUser.FindFirst("UserId").Value;

            

            if (!ModelState.IsValid || id < 1)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var log = await _unitOfWork.LoggedTime.Get(q => q.Id == id);
                if (log == null)
                {
                    return BadRequest("Submitted data is invalid");
                }
                if (User.IsInRole("User"))
                {

                    var empTime = await _unitOfWork.EmployeeTime.Get(q => q.FK_EmployeeTime_to_LoggedTime == id);

                    if (empTime.FK_EmployeeTime_to_Employee != currentUserID)
                    {
                        //Console.WriteLine("not autorized to change");
                        return StatusCode(401, "You are not authorized to change this log");
                    }
                }
               


                _mapper.Map(loggedDTO, log);
                _unitOfWork.LoggedTime.Update(log);
                await _unitOfWork.Save();

                return Ok("Success");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error. Please Try Again Later.");
            }
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllLoggedTime()
        {
            List<int> someItems = new List<int> { 34 };
            try
            {
                var loggedTime = await _unitOfWork.LoggedTime.GetAll(k=> someItems.Contains(k.Id));
                var results = _mapper.Map<IList<LoggedTimeDTO>>(loggedTime);
                return Ok(results);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error. Please Try Again Later.");
            }
        }

        [HttpGet("{id:int}", Name = "GetLoggedTime")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetLoggedTime(int id)
        {
            try
            {
                var loggedTime = await _unitOfWork.LoggedTime.Get(q => q.Id == id);
                var result = _mapper.Map<LoggedTimeDTO>(loggedTime);
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
        public async Task<IActionResult> CreateLoggedTime([FromBody] LoggedTimeDTO loggedDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var logged = _mapper.Map<LoggedTime>(loggedDTO);
                await _unitOfWork.LoggedTime.Insert(logged);
                await _unitOfWork.Save();

                return CreatedAtRoute("GetLoggedTime", new { id = logged.Id }, logged);
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
        public async Task<IActionResult> DeleteLoggedTime(int id)
        {
            if (id < 1)
            {
                return BadRequest();
            }

            try
            {
                var lt = await _unitOfWork.LoggedTime.Get(q => q.Id == id);
                if (lt == null)
                {
                    return BadRequest("Submitted data is invalid");
                }

                await _unitOfWork.LoggedTime.Delete(id);
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
