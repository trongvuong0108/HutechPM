using HutechNote.Data.Data.ProjectData;
using HutechPM.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HutechPM.Data.Data.ProjectData.DTO
{
    public class ProjectDTO
    {
        public Guid projectId {  get; set; }
        public string projectName { set; get; }
        public string owner { set; get; }
        public string description { set; get; }
        public DateTime dateStart { set; get; }
        public DateTime dateEnd { set; get; }
        public int quantityTask { set; get; }
        public bool isActive { set; get; }
    }
}
