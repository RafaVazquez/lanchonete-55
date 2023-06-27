using lanchonete_55.Domain.UseCases.CreateCustomer;
using Microsoft.AspNetCore.Mvc;
namespace Estoque.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CreateCustomer : ControllerBase
    {
        private readonly ICreateCustomer createCustomer;
        private readonly ILogger _logger;

        [HttpPost]
        [ProducesResponseType(typeof(string), 201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> Post([FromBody] CreateCustomerSignature signature)
        {
            try
            {
                await createCustomer.InsertAsync(signature);
                return Created("", "");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error Creating Costumer");
                return BadRequest($"Erro => {ex.Message}");
            }
        }
    }
}