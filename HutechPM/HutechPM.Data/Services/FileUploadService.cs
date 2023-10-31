using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HutechNote.Data.Services
{
    public class FileUploadService
    {
        private readonly Cloudinary cloudinary;
        public FileUploadService()
        {
            Account account = new Account("dzjmvy2ty", "682162512936223", "O9El85LO2lGt5Af1rlZxb8xxRwo");
            cloudinary = new Cloudinary(account);
        }
        public async Task<string> uploadFile(string url, string fileName)
        {
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(url),
                PublicId = "HutechPM_" + DateTime.Now.Year+ "/"+ DateTime.Now.Month + "/" + DateTime.Now.Day + "_" + Guid.NewGuid().ToString(),
                Overwrite = true
            };
            ImageUploadResult uploadResult = await cloudinary.UploadAsync(uploadParams);
            return uploadResult.Url.ToString();
        }
        public string downloadFile()
        {
            return "";
        }

    }
}
