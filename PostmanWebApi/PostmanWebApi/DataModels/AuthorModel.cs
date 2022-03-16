namespace PostmanWebApi.DataModels
{
    public class AuthorModel
    {
        public string AuthorId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Phone { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public bool HasContract { get; set; }

        public string SetNewAuthorID()
        {
            var rnd = new Random();
            var rnd3 = rnd.Next(900, 1000); // 900 <= x < 1000 
            var rnd2 = rnd.Next(70, 89); // 70 <= x < 89
            var rnd4 = rnd.Next(0, 10000); // 0 <= x < 10000

            return $"{rnd3}-{rnd2}-{rnd4}";
        }
    }
}
