using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Core.Utilities.Helpers;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadsController : ControllerBase
    {
        private IWebHostEnvironment _webHostEnvironment;

        public UploadsController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        [HttpGet("uploadTest")]
        public IActionResult UploadTest()
        {
            var result = _webHostEnvironment.WebRootPath;
            string path = Path.Combine(result, "uploads");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return Ok(path);
        }

        //[HttpPost("upload")]
        //public async Task<IActionResult> Upload(List<IFormFile> files)
        //{
        //    var wwWebRootPath = _webHostEnvironment.WebRootPath;

        //    //if (files.Count>5)
        //    //{
        //    //    Console.WriteLine("En fazla 5 resim yükleneebili");
        //    //}
        //    await FileUploadHelper.Upload(files, wwWebRootPath);

        //    return Ok();
        //}
    }
}
