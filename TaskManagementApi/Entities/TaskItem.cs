namespace TaskManagementApi.Entities
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Status { get; set; } = "pending";
        public string Priority { get; set; }
        public string? Description { get; set; }
    }
}
