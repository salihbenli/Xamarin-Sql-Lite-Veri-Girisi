using System;
using System.Collections.Generic;
using System.IO;
using Android.Icu.Text;
using classlar.Droid;
using SQLite;
using Xamarin.Essentials;
using Xamarin.Forms;

[assembly: Dependency(typeof(Database_Android))]

namespace classlar.Droid
{
    class Database_Android : Database
    {
        SQLiteConnection con;

        public SQLiteConnection GetData()
        {
            string fileName = "person.db3";
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string path = Path.Combine(documentPath, fileName);
            con = new SQLiteConnection(path);
            con.CreateTable<Person>();
            return con;
        }
        public void DeletePerson(int Id)
        {
            string sql = $"DELETE FROM Person WHERE Id={Id}";
            con.Execute(sql);
        }
        public List<Person> GetPeople()
        {
            string sql = "SELECT * FROM Person";
            List<Person> employees = con.Query<Person>(sql);
            return employees;
        }
        public bool SavePerson(Person savePerson)
        {
            bool res = false;
            try
            {
                con.Insert(savePerson);
                res = true;
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }

        public bool UpdatePerson(Person persns)
        {
            bool res = false;
            try
            {
           
                string sql = $"UPDATE Person SET Name='{persns.Name}',borc='{persns.borc}',verilen='{persns.verilen}' WHERE Id={persns.Id}";

                con.Execute(sql);
                res = true;
            }
            catch (Exception ex)
            {
                
            }
            return res;
        }
    }
}