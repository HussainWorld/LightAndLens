namespace LightAndLens.WebApp.Models
{
    public class CategoryAvailabilityViewModel
    {
        public string CategoryName { get; set; }
        public int Total { get; set; }
        public int Available { get; set; }
        public int PercentageAvailable => Total == 0 ? 0 : (int)((double)Available / Total * 100);

        public string BarColor
        {
            get
            {
                if (PercentageAvailable >= 70)
                    return "bg-success";  // Green
                if (PercentageAvailable >= 30)
                    return "bg-warning";  // Yellow
                return "bg-danger";       // Red
            }
        }

    }
}
