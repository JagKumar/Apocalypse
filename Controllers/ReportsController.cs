using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Apocalypse.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace Apocalypse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly ApocalyseDbContext _context;

        public ReportsController(ApocalyseDbContext context)
        {
            _context = context;
        }


        [HttpGet("infectedsurvivors/{infected}")]
        public async Task<ActionResult<IEnumerable<Survivor>>> infectedsurvivors(bool infected)
        {
            var survivor = await _context.survivors.Where(x => x.asinfected == infected).ToListAsync();

            if (survivor == null)
            {
                return NotFound();
            }

            return survivor;
        }
        [HttpGet("Percentage/{infected}")]
        public async Task<ActionResult<IEnumerable<Survivor>>> infectedPercentage(bool infected)
        {
            if (infected)
            {
                var infectedsurvivor = await _context.survivors.Where(x => x.asinfected == infected).ToListAsync();
                var infectedsurvivorCount = infectedsurvivor.Count;
                var percentage = infectedsurvivorCount / 100 * 100;
                return Ok(percentage);
            }
            else
            {
                var noninfectedsurvivor = await _context.survivors.Where(x => x.asinfected == infected).ToListAsync();
                var noninfectedsurvivorCount = noninfectedsurvivor.Count;
                var percentage = noninfectedsurvivorCount / 100 * 100;
                return Ok(percentage);
            }

            return Ok();
        }
        [HttpGet()]
        [Route("RobotsList")]
        public async Task<ActionResult<IEnumerable<Robots>>> RobotsList()
        {
            List<Robots> robotsList = new List<Robots>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://robotstakeover20210903110417.azurewebsites.net/robotcpu"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    robotsList = JsonConvert.DeserializeObject<List<Robots>>(apiResponse);
                    robotsList.OrderByDescending(b => b.category);

                }
            }
            return robotsList;
        }
    }
}
