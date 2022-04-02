using ModelConfiguration;
using ModelConfiguration.Models;

Console.WriteLine("***** Model Configuration *****");

using (ApplicationContext db = new ApplicationContext())
{
    db.Users.Add(new User { Name = "Marcus", Age = 45 });
    //db.Users.Add(new User { Age = 45 });

    db.Companies.Add(new Company { Title = "Microsoft" });
    db.SaveChanges();

    List<User> users = db.Users.ToList();
    List<Company> companies = db.Companies.ToList();

    foreach (var user in users)
    {
        Console.WriteLine(user.Name);
    }

    foreach (var comp in companies)
    {
        Console.WriteLine(comp.Title);
    }
}