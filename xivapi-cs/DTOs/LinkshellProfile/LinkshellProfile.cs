namespace xivapi_cs.DTOs.LinkshellProfile
{
    public class LinkshellProfile
    {
        public string ID { get; set; }
        public Pagination Pagination { get; set; }
        public Profile Profile { get; set; }
        public CharacterShort[] Results { get; set; }
    }
}