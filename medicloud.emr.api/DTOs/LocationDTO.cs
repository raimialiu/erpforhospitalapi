namespace medicloud.emr.api.DTOs
{
    public class OptionsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class LocationDTO : OptionsDTO { }


    public class SpecializationDTO : OptionsDTO { }

    public class ProviderDTO : OptionsDTO { }

}
