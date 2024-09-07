namespace TaksManagement_System.Models
{
    public class Tasks
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime DueDate { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }

}
