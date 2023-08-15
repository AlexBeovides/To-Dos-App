namespace ToDoApi.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
    }
}
