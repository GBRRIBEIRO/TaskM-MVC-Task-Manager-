namespace TaskM.Models.WorkItems
{
    public class WorkItem
    {
        public WorkItem(string title,string description)
        {
            Id = new Guid();
            Title = title;
            Description = description;
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }
}
