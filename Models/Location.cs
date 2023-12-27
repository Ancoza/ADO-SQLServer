
namespace HR_ADO_SQLServer.Data
{
    public class Location
    {
        public int location_id {  get; set; }
        public string street_address { get; set;}
        public string postal_code { get; set; }
        public string city { get; set; }
        public string state_province { get; set; }
        public char county_id {  get; set; }
    }
}
