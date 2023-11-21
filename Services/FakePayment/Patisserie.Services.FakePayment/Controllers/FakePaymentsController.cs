using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Patisserie.Shared.ControllerBases;
using Patisserie.Shared.Dtos;

namespace Patisserie.Services.FakePayment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FakePaymentsController : CustomBaseController
    {

        [HttpPost]
        public IActionResult ReceivePayment()
        {
            return CreateActionResultInstance(Response<NoContent>.Success(200));
        }
    }
}
