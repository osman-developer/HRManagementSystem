using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BLC;
using DALC;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using static Entities.Entities;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageUploadController : ControllerBase
    {
        private IConfiguration MyConfig;
        public static IWebHostEnvironment _environment;
        public ImageUploadController(IWebHostEnvironment environment, IConfiguration config)
        {
            _environment = environment;
            this.MyConfig = config;
        }
        public class FileUpload
        {
            public IFormFile files
            {
                get; set;
            }
        }

        [HttpPost]
        public async Task<string> Post([FromForm] FileUpload objfile)
        {

            if (objfile.files.Length > 0)
            {
                try
                {
                    if (!Directory.Exists(_environment.WebRootPath + "\\uploads\\"))
                    {
                        Directory.CreateDirectory(_environment.WebRootPath + "\\uploads\\");
                    }
                    using (FileStream fileStream = System.IO.File.Create(_environment.WebRootPath + "\\uploads\\" + objfile.files.FileName))
                    {
                        objfile.files.CopyTo(fileStream);

                        Person i_person = new Person();
                        i_person.PERSON_ID = 1;
                        i_person.NAME = "Osman";
                        i_person.IMG_URL = "\\uploads\\" + objfile.files.FileName;
                        
                      
                        BLC.BLC oBLC = new BLC.BLC();
                        oBLC.connStr = this.MyConfig["AppSettings:MyDBConnection"];
                        oBLC.Edit_Person(i_person);

                        
                        fileStream.Flush();
                        return "\\uploads\\" + objfile.files.FileName;
                    }
                }
                catch (Exception ex)
                {

                    return ex.ToString();
                }
            }
            else
            {
                return "Failed";
            }
        }

    }
}
