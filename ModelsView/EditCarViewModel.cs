namespace WebAppAdvance.ModelsView
{
    public class EditCarViewModel
    {
        public int Id { get; set; }
        public string Brand { get; set; } = null!;
        public string Model { get; set; } = null!;
        public int Year { get; set; }
        public int Pasengers { get; set; }
        public decimal PricePerDay { get; set; }
    }
}
