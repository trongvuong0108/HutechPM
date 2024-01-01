namespace HutechPM.Data.ProjectData.DTO
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
