namespace BlogApp.Entity
{
    public class Tag
    {
        public enum TagColors
        {
            primary,danger,warning,success,secondary
        }
        public int TagId { get; set; }
        public string? Text { get; set; }
        public string? Url { get; set; }
        public TagColors Color { get; set; }
        public List<Post> Posts { get; set; } = new List<Post>();
        //public object User { get; internal set; }

        public User? User { get; set; }
        public int? UserId { get; set; }
    }
}
