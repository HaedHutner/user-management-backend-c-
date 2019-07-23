namespace UserManagement.Dto
{
    public class AddressDto
    {
        public long Id { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public int StreetNumber { get; set; }

        public int PostCode { get; set; }
    }
}