using System.Data;
using SQLite;

namespace classlar
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string borc { get; set; }
        public string verilen { get; set; }
        public string kalan { get; set; }


    }
}