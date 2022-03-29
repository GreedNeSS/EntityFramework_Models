using CreateKeys;
using CreateKeys.Models;

Console.WriteLine("***** Create Keys *****");

using (ApplicationContext db = new ApplicationContext())
{
    db.People.AddRange(
        new Person { Name = "Bob", PassportSeria = "1234", PassportNumber = "567890"},
        //new Person { Name = "Tedd", PassportSeria = "1234", PassportNumber = "567890"}
        new Person { Name = "Tedd", PassportSeria = "1234", PassportNumber = "667890"}
        );
    db.SaveChanges();

    List<Person> people = db.People.ToList();

    foreach (Person person in people)
    {
        Console.WriteLine(person);
    }
}