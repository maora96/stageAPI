namespace stageAPI.Models
{
    public class Process
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; 
        public string Description { get; set; } = string.Empty;
        public List<Process>? Processes { get; set; }

        public required Department Department { get; set; }
    }
}
