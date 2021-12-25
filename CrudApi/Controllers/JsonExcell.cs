using CrudApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace CrudApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JsonExcellController : Controller
    {
        public IList<Recipe> Index()
        {
            StreamReader r = new StreamReader("C:\\Users\\sample.json");
            string jsonString = r.ReadToEnd();
            IList<Recipe> recList = JsonConvert.DeserializeObject<IList<Recipe>>(jsonString);

            return recList;
        }
    }
}
