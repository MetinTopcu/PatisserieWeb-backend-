using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Patisserie.Services.PhotoStock.Dtos;
using Patisserie.Shared.ControllerBases;
using Patisserie.Shared.Dtos;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Patisserie.Services.PhotoStock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotosController : CustomBaseController
    {
        [HttpPost]
        public async Task<IActionResult> PhotoSave(IFormFile photo, CancellationToken cancellationToken)
        {
            if(photo !=null && photo.Length> 0)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/photos", photo.FileName);

                using(var stream = new FileStream(path, FileMode.Create))
                {
                    await photo.CopyToAsync(stream,cancellationToken);
                }

                //http://www.photostock.api.com/photos/asdfsh.jpg
                var returnPath = "photos" + photo.FileName;

                PhotoDto photoDto = new() { Url = returnPath };

                return CreateActionResultInstance(Response<PhotoDto>.Success(photoDto, 200));
            }

            return CreateActionResultInstance(Response<PhotoDto>.Fail("photo is empty", 400));
        }

        [HttpDelete]
        public IActionResult PhotoDelete(string photoUrl)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/photos", photoUrl);
            if (!System.IO.File.Exists(path))
            {
                return CreateActionResultInstance(Response<NoContent>.Fail("Photo not found", 404));
            }

            System.IO.File.Delete(path);

            return CreateActionResultInstance(Response<NoContent>.Success(204));
        }


    }
}
