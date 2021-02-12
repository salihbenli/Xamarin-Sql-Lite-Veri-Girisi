using System.Collections.Generic;

using SQLite;


namespace classlar

{
    public interface Database
    {
        SQLiteConnection GetData();

        bool SavePerson(Person persns);

        List<Person> GetPeople();

        bool UpdatePerson(Person persns);
        void DeletePerson(int Id);

    }
}