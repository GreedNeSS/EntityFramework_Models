using EntityConstructor;
using EntityConstructor.Models;

Console.WriteLine("***** Entity Constructor *****");

using (ApplicationContext db = new ApplicationContext())
{
    Address address = new Address("Stvolnaya", 40);
    db.Users.AddRange(new User("GreedNeeSS", 30) { Address = address },
        new User("Kate", 29) { Address = address });
    db.SaveChanges();
}

using (ApplicationContext db = new ApplicationContext())
{
    List<User> users = db.Users.ToList();

    foreach (User user in users)
    {
        Console.WriteLine(user);
    }
}