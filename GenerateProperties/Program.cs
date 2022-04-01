using GenerateProperties;
using GenerateProperties.Models;

Console.WriteLine("***** Generate Properties *****");

using (ApplicationContext db = new ApplicationContext())
{
    db.People.AddRange(new Person(), new Person { FirstName = "Henry" });
    db.SaveChanges();

    List<Person> list = db.People.ToList();
    list.ForEach(person => Console.WriteLine(person));
}