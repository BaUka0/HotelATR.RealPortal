namespace HotelATR.RealPortal.Models
{
    public class TeamsViewModel
    {
        public string ImagePath { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
        public List<Teamlinks> TeamLinks { get; set; }
    }

    public class Teamlinks
    {
        public string URL { get; set; }
        public string LinkType { get; set; }
    }
