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
        private Cloudinary cloudinary;
        private FileUploadService()
        {
            Account account = new Account("dzjmvy2ty", "682162512936223", "***************************");
            cloudinary = new Cloudinary(account);
        }

        public Cloudinary GetInstance()
        {
            return cloudinary;
        }
        public string uploadFile()
        {
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(@"https://upload.wikimedia.org/wikipedia/commons/a/ae/Olympic_flag.jpg"),
                PublicId = "HutechPM_" + DateTime.Now + "_" + new Guid().ToString()
            };
            ImageUploadResult uploadResult = cloudinary.Upload(uploadParams);
            return uploadResult.Url.ToString();
        }
        public string downloadFile()
        {
            return "";
        }

    }
}
