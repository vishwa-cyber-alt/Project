namespace JobApp.Models
{
    public class Model
    {
        public int userid { get; set; }
        public string username{ get; set; }
        public string password{ get; set; }
    }

    public class Suppliers
    {
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
    }
}
