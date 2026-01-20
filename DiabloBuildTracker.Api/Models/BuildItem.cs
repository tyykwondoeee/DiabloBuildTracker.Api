namespace DiabloBuildTracker.Api.Models
{
    public class BuildItem
    {
        public int BuildId { get; set; }
        public Build Build { get; set; } = null!;
        public int ItemId { get; set; }
        public Item Item { get; set; } = null!;
    }
}
