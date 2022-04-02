using InitializeFirstData;
using InitializeFirstData.Models;

Console.WriteLine("***** Initialize First Data *****");

using (ApplicationContext db = new ApplicationContext())
{
    List<Company> companies = db.Companies.ToList();
    List<User> users = db.Users.ToList();

    ShowTables(companies, users);

    db.Companies.Add(new Company { Title = "JetBrains" });
    db.Users.Add(new User { Age = 12, Name = "Bob", CompanyId = 3 });
    db.SaveChanges();

    Console.WriteLine("\nAdded new items:\n");

    companies = db.Companies.ToList();
    users = db.Users.ToList();

    ShowTables(companies, users);
}

void ShowTables(List<Company> companies, List<User> users)
{
    Console.WriteLine("\n*** Company ***");

    foreach (var company in companies)
    {
        Console.WriteLine($"\n{company}:");
        company.Users.ForEach(u => Console.WriteLine("=> " + u.Name));
    }

    Console.WriteLine("\n*** Users ***");

    foreach (var user in users)
    {
        Console.WriteLine(user);
        Console.WriteLine("=> " + user?.Company?.Title);
        Console.WriteLine();
    }
}