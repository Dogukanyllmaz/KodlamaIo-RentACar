using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FindexScoresController : ControllerBase
    {

        IFindexScoreService _findexScoreService;

        public FindexScoresController(IFindexScoreService findexScoreService)
        {
            _findexScoreService = findexScoreService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _findexScoreService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbycustomerid")]
        public IActionResult GetByCustomerId(int customerId)
        {
            var result = _findexScoreService.GetByCustomerId(customerId);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }

}

