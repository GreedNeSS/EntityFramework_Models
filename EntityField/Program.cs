using EntityField;
using EntityField.Models;

Console.WriteLine("***** Entity Field *****");

using (ApplicationContext db = new ApplicationContext())
{
    User greed = new User("GreedNeSS", 30);
    User marus = new User("Marcus", 45);
    db.Users.AddRange(greed, marus);
    db.SaveChanges();

    List<User> users = db.Users.ToList();

    foreach (User user in users)
    {
        Console.WriteLine(user);
    }
}