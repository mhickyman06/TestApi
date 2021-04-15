using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;  
using Microsoft.EntityFrameworkCore;
namespace TestApi.Model
{
     public  class UserRoles 
    {  
        public const string Admin = "Admin";  
        public const string User = "User";  
    }   
}