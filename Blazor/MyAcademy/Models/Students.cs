namespace MyAcademy.Models
{
    public class Students
    {
        public int stud_id { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
        public string? middle_name { get; set; }
        public string birth_date { get; set; }
        public string? email { get; set; }
        public string? phone { get; set; }
        public string? photo { get; set; }
        public int group_number { get; set; }
    }
}
