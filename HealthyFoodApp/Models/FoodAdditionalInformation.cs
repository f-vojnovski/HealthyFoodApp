namespace HealthyFoodApp.Models
{
    public class FoodAdditionalInformation
    {
        public int Id { get; set; }

        public FoodAdditionalInformationType InformationType {get; set; }

        public string Information { get; set; }
    }
}
