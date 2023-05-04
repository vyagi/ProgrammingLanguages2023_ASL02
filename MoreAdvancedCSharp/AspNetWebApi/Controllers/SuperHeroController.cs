using AspNetWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<SuperHero> Get()
        {
            return SuperHero.Heroes;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            var hero = SuperHero.Heroes.FirstOrDefault(x => x.Id == id);

            if (hero == null)
            {
                return NotFound();
            }

            return Ok(hero);
        }

        [HttpPost]
        public IActionResult Post(SuperHeroCreate newHero)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);//here you can add some more info if needed
            }

            var hero = new SuperHero(SuperHero.Heroes.Max(x => x.Id) + 1, newHero.Name, newHero.Age,
                newHero.Powers.Split(",").ToList());

            SuperHero.Heroes.Add(hero);

            return Ok(hero);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Put(int id, SuperHeroUpdate updatedHero)
        {
            var heroToBeUpdated = SuperHero.Heroes.FirstOrDefault(x=>x.Id == id);
            if (heroToBeUpdated == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);//here you can add some more info if needed
            }

            heroToBeUpdated.Age = updatedHero.Age;
            heroToBeUpdated.Powers = updatedHero.Powers.Split(",").ToList();
                
            return Ok(heroToBeUpdated);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            var heroToBeDeleted = SuperHero.Heroes.FirstOrDefault(x => x.Id == id);

            SuperHero.Heroes.Remove(heroToBeDeleted);

            return Ok();
        }
    }
}
