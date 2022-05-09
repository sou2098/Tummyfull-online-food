using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tummyfull.Models;

namespace Tummyfull.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Menu_CardController : ControllerBase
    {
        private readonly Menu_CardContext _Db;
        public Menu_CardController(Menu_CardContext Db)
        {
            _Db = Db;
        }
        [HttpGet]
        [Route("details")]
        public IActionResult GetMenu_CardController()
        {
            var data = _Db.Menu_Card.ToList();
            return Ok(data);
        }
        [HttpPost]
        [Route("create")]
        public IActionResult Create(Menu_Card Menu)
        {
            try
            {
                _Db.Menu_Card.Add(Menu);
                _Db.SaveChanges();
                return Ok("Data Added Successfully");
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status404NotFound, "Failed to Add data");
            }
            return Ok(Menu);
        }
        [HttpPut]
        [Route("Update")]
        public IActionResult Update(Menu_Card Menu)
        {
            try
            {

                _Db.Menu_Card.Update(Menu);
                _Db.SaveChanges();
                return Ok("Data Updated Successfully");

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status404NotFound, "Data Not Matched");
            }

        }
        [HttpDelete]
        [Route("Delete")]
        public IActionResult Delete(int Code)
        {
            try
            {
                var data = _Db.Menu_Card.FirstOrDefault(e => e.Item_Code == Code);
                _Db.Menu_Card.Remove(data);
                _Db.SaveChanges();
                return Ok("Data Deleted Successfully");
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status404NotFound, "ID Not Matched");
            }

        }
    }
}
