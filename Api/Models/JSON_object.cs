namespace API_Tareadef.Models
{
    public class JSON_object
    {
        public string status { get; set; } = string.Empty;
        public Object result { get; set; }


        public JSON_object(string status, Object result)
        {
            this.status = status;
            this.result = result;
        }
    }
}
