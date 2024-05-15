using Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;
using static Common.MyWorldDbContext;

namespace LogAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LogController : ControllerBase
    {

        [HttpGet(Name = "GetAllLogEntries")]
        public IActionResult Get()
        {
            try
            {
                using (SQL sql = new SQL())
                {
                    return Ok(sql.LogEntries.ToList().Take(20));
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Hiba!");
            }
        }

        [HttpGet("GetLogEntry")]
        public IActionResult GetLogById([FromHeader] string id)
        {
            try
            {
                using (SQL sql = new SQL())
                {
                    return Ok(sql.LogEntries.Single(x => x.id == int.Parse(id)));
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("SearchLogEntry")]
        public IActionResult SearchLogEntry([FromBody] string text)
        {
            try
            {
                List<logentries> entries = new List<logentries>();

                using (SQL sql = new SQL())
                {
                    sql.LogEntries.ToList().ForEach(x =>
                    {
                        if (x.Message.Contains(text) || x.Exception.Contains(text) || $"{x.DateUTC}".Contains(text))
                        {
                            entries.Add(x);
                        }
                    });
                    sql.SaveChanges();
                }

                return Ok(entries);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("InsertLogEntry")]
        public IActionResult InsertLogEntry([FromBody] logentries entry)
        {
            try
            {
                using (SQL sql = new SQL())
                {
                    sql.LogEntries.Add(entry);
                    sql.SaveChanges();
                }

                return Ok(entry);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
