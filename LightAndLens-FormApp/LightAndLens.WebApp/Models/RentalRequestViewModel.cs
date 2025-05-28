namespace LightAndLens.WebApp.Models
{
    public class RentalRequestViewModel
    {
        public int RequestId { get; set; }
        public int EquipmentId { get; set; }

        public DateTime RequestStartDate { get; set; }
        public DateTime RequestEndDate { get; set; }
        public DateTime RequestSetDate { get; set; }

        public string EquipmentName { get; set; }
        public string StatusName { get; set; }
        public string UserEmail { get; set; }

        public string EquipmentImagePath { get; set; }



    }


}
