namespace HutechPM.WebClient.Models
{
    public class HtppResponseBase<T> 
    {
        public int ErrorCode { get; set; }
        public bool IsSuccess { get; set; }
        public T? DataObject { get; set; }
    }
}
