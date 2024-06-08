namespace WebAppSQLConnection.Models
{
    public class Group:BaseEntity
    {
        public string Name { get; set; }
        List<Student> Students { get; set; }

    }
}
