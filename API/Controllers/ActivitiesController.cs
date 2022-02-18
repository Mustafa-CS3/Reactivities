using Application.Activities;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{


    public class ActivitiesController : BaseApiController
    {
     
        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivites()
        {

            return await Mediator.Send(new List.Query());

        }

        [HttpGet("{id}")] //activity/id

        public async Task<ActionResult<Activity>> GetActivity(Guid id)
        {

            return await Mediator.Send(new Detail.Query { Id = id });
        }

        [HttpPost]
        public async Task<IActionResult> CreateActivity(Activity activity)
        { 
        
          return Ok(await Mediator.Send(new Create.Command {Activity = activity }));
        }
    }
}