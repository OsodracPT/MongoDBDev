using System;

namespace MongoDBDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("AddressBook");

            //PersonModel person = new PersonModel
            //{
            //    FirstName = "James",
            //    LastName = "Bond",
            //    PrimaryAddress = new AddressModel
            //    {
            //        StreetAddress = "8 pivet drive",
            //        City = "Norwich",
            //        State = "Cambridge",
            //        ZipCode = "1234"
            //    }
            //};
            //db.InsertRecord("Users", person);

            var recs = db.LoadRecords<NameModel>("Users");

            foreach (var rec in recs)
            {
                Console.WriteLine($"{rec.FirstName} {rec.LastName}");
                Console.WriteLine();
            }

            //var oneRec = db.LoadRecordById<PersonModel>("Users", new Guid("602879cf-d2db-4f1d-9db6-845817322e38"));
            //oneRec.DateOfBirth = new DateTime(1982, 10, 31, 0, 0, 0, DateTimeKind.Utc);
            //db.UpsertRecord("Users", oneRec.Id, oneRec);

            //db.DeleteRecord<PersonModel>("Users", oneRec.Id);
            Console.ReadLine();
        }
    }
}
