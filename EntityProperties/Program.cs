using EntityProperties;
using EntityProperties.Models;

Console.WriteLine("***** Entity properties *****");

using (ApplicationContext db = new ApplicationContext())
{
    db.Users.Add(new User { Name = "Marcus", Age = 45, Address = "Rome" });
    db.Users.Add(new User { Name = "August", Age = 65, Address = "Rome" });
    db.SaveChanges();

    List<User> users = db.Users.ToList();

    foreach (User user in users)
    {
        Console.WriteLine(user);
    }
}