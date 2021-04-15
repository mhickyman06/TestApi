using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authentication.JwtBearer;  
using Microsoft.AspNetCore.Identity;  
using Microsoft.AspNetCore.Authorization; 
using TestApi.Model; 

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private List<Post> _Posts ;
        public PostController()
        {
            _Posts= new List<Post>();
            for (int i = 0; i < 5; i++)
            {
                _Posts.Add(new Post(){Id=Guid.NewGuid().ToString()});
            }
        }
      
        [HttpGet]
        [Route(ApiRoutes.Posts.GetAllPosts)]
        public IActionResult Posts()
        {
            return Ok(_Posts);
        }

       
    }
}
