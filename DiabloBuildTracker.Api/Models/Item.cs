namespace DiabloBuildTracker.Api.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Slot { get; set; } = null!;
        public ICollection<BuildItem> BuildItems { get; set; } = new List<BuildItem>();
    }
 }
