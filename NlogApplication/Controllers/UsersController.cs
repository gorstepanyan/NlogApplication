using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NlogApplication.Data.DbModels;

namespace NlogApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserDatabaseContext _dbContext;
        private readonly ILogger<UsersController> _logger;
        public UsersController(UserDatabaseContext dbContext, ILogger<UsersController> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                _logger.LogDebug("This is a debug message");
                _logger.LogInformation("This is an info message");
                _logger.LogWarning("This is a warning message ");
                _logger.LogError(new Exception(), "This is an error message");
                var returnvalue = await _dbContext.Logs.ToListAsync();
                return Ok(returnvalue);
            }
            catch (Exception ex)
            {
                _logger.LogError("Oops!!! Something went wrong!!!!!");
                throw ex;
            }
        }
    }
}




