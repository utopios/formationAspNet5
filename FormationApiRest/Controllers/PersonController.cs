using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormationApiRest.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FormationApiRest.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        //[Authorize(Policy = "public")]
        public async Task<IActionResult> Get()
        {
            //return await Task<List<Person>>.Run(() =>  new List<Person>() { new Person { FirstName = "toto", LastName = "tata" }, new Person { FirstName = "titi", LastName = "minet" } });

            List<Person> peoples = await Person.GetPersonAsync();

            return Ok(peoples);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await Person.GetPersonAsyncById(id));
        }

        [HttpPost]
        [Authorize(Policy = "admin")]
        public async Task<IActionResult> Post([FromBody] PersonRecord person)
        {
            return Ok(await Person.PostPersonAsync(person));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromBody] PersonRecord person, int id)
        {
            Person personEdit = await Person.GetPersonAsyncById(id);
            if(personEdit == null)
            {
                return NotFound();
            }
            else
            {
                if (personEdit.Update(person))
                {
                    return Ok(new { message = "update ok" });
                }
                else
                {
                    return Ok(new { message = "error update" });
                }
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await Person.DeletePersonAsync(id));
        }
    }

}