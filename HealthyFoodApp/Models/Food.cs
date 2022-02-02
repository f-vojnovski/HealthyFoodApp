using System.Collections.Generic;

namespace HealthyFoodApp.Models
{
    public class Food
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<FoodAdditionalInformation> AdditionalInformation { get; set; }

        public int? Calories { get; set; }

        public float? Choline { get; set; }
        
        public int? FolateDFE { get; set; }

        public int? FolateFood { get; set; }

        public int? FolicAcid { get; set; }

        public float? Niacin { get; set; }

        public float? Riboflavin { get; set; }

        public float? Thiamin { get; set; }

        public int? VitaminARae { get; set; }

        public int? CaroteneAlpha { get; set; }

        public int? CaroteneBeta { get; set; }

        public int? Cryptoxanthin { get; set; }

        public int? LuteinZeaxanthin { get; set; }

        public int? Lycopene { get; set; }

        public int? Retinol { get; set; }

        public float? VitaminB12 { get; set; }

        public float? VitaminB12Added { get; set; }

        public float? VitaminB6 { get; set; }

        public float? VitaminC { get; set; }

        public float? VitaminD { get; set; }

        public float? VitaminE { get; set; }

        public float? VitaminEAdded { get; set; }

        public float? TocopherolAlpha { get; set; }

        public float? VitaminK { get; set; }

        public int? Calcium { get; set; }

        public float? Copper { get; set; }

        public float? Iron { get; set; }

        public float? Magnesium { get; set; }

        public int? Phosphorus { get; set; }

        public int? Potassium { get; set; }

        public int? Selenium { get; set; }

        public int? Sodium { get; set; }

        public float? Zinc { get; set; }

        public float? Protein { get; set; }

        public float? Fat { get; set; }

        public float? SaturatedFattyAcids { get; set; }

        public float? ButanoicAcid { get; set; }

        public float? DecanoicAcid { get; set; }

        public float? DodecanoicAcid { get; set; }

        public float? HexadecanoicAcid { get; set; }

        public float? HexanoicAcid { get; set; }

        public float? OctadecanoicAcid { get; set; }

        public float? OctanoicAcid { get; set; }

        public float? TetradecanoicAcid { get; set; }

        public float? MonounsaturatedFattyAcids { get; set; }

        public float? DocosenoicAcid { get; set; }

        public float? EicosenoicAcid { get; set; }

        public float? HexadecenoicAcid { get; set; }

        public float? OctadecenoicAcid { get; set; }

        public float? PolyunsaturatedFattyAcids { get; set; }

        public float? DocosahexaenoicN3Acid { get; set; }

        public float? DocosapentaenoicN3acid { get; set; }

        public float? EicosapentaenoicN3Acid { get; set; }

        public float? EicosatetraenoicAcid { get; set; }

        public float? OctadecadienoicAcid { get; set; }

        public float? OctadecatetraenoicAcid { get; set; }

        public float? OctadecatrienoicAcid { get; set; }

        public float? Carbohydrate { get; set; }

        public float? Fiber { get; set; }

        public float? Sugar { get; set; }

        public int? Cholesterol { get; set; }

        public int? Alcohol { get; set; }

        public int? Caffeine { get; set; }

        public int? Theobromine { get; set; }

        public float? Water { get; set; }

        public FoodType Type { get; set; }
    }
}
