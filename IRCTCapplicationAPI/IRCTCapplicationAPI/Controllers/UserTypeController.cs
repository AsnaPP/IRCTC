﻿using IRCTCapplicationAPI.Request.Command.AddUser;
using IRCTCapplicationAPI.Request.Command.AddUserType;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace IRCTCapplicationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserTypeController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UserTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("AddUserType")]
        public async Task<ActionResult<bool>> AddUserType([FromBody] AddUserTypeCommand command) 
        { return Ok(await _mediator.Send(command)); }
    }
}