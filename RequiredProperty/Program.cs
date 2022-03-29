using RequiredProperty;
using RequiredProperty.Models;

Console.WriteLine("***** Required Property *****");

using (ApplicationContext db = new ApplicationContext())
{
    //User greed = new User { Age = 30 };
    User greed = new User { Name = "GreedNeSS", Age = 30 };
    User marus = new User { Name = "Marcus", Age = 45 };
    db.Users.AddRange(greed, marus);
    db.SaveChanges();

    List<User> users = db.Users.ToList();

    foreach (User user in users)
    {
        Console.WriteLine(user);
    }
}