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

namespace TestApi.Model
{
    public class Post
    {
        public string Id { get; set; }
    }
}
