using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using Modelo.Modelos;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace ClienteTransporte.Controllers
{
    public class ConductorController : Controller
    {
        // GET: Conductor
        //https://localhost:44358/api/Conductor
        public async Task<ActionResult> Index()
        {
            HttpClient httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://localhost:44358/api/Conductor");
            List<ConductorModel> ConductorModels = JsonConvert.DeserializeObject<List<ConductorModel>>(json);
            return View(ConductorModels);
        }
    }
}