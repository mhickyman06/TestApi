using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApi.Model
{
     public static class ApiRoutes  
    {  
        public static class Posts{
            public const string GetAllPosts ="v1/Posts";
            public const string Create ="v1/Posts";
            public const string Get ="v1/GetAllPost/{id}";


        }
    }  
}