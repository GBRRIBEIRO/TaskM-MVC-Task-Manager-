namespace TaskM.Data
{
    public class DatabaseConfiguration
    {
        public string Path { get; set; }

        public DatabaseConfiguration() {
            Path = "D:\\Dev\\Projects\\TaskM\\Database\\TaskM.db";
        }
    }
}
