﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SecureController : ControllerBase
    {
        [Authorize]
        [HttpGet("data")]
        public IActionResult GetSecureData()
        {
            return Ok("This is a protected endpoint. You're authorized!");
        }
    }
}
