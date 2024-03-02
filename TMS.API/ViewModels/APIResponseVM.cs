namespace TMS.API.ViewModels
{
    public class APIResponseVM
    {
        public string code { get; set; }
        public string desc { get; set; }
        public Data data { get; set; }
    }
    public class Data
    {
        public string id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
    }
}
