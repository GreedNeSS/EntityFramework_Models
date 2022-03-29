using CreateIndex;
using CreateIndex.Models;

Console.WriteLine("***** Create Index ******");

using (ApplicationContext db = new ApplicationContext())
{
    db.People.AddRange(
        new Person { Name = "Bob", PassportSeria = "1234", PassportNumber = "567890", Age = 30, PhoneNumber = 312431223 },
        new Person { Name = "Tedd", PassportSeria = "1234", PassportNumber = "567890", PhoneNumber = 124323232 },
        new Person { PassportSeria = "1234", PassportNumber = "567890", PhoneNumber = 314453232 },
        new Person { Name = "Terry", PassportSeria = "1234", PassportNumber = "667890", Age = 45, PhoneNumber = 125434321 }
        );
    db.SaveChanges();

    List<Person> people = db.People.ToList();

    foreach (Person person in people)
    {
        Console.WriteLine(person);
    }
}