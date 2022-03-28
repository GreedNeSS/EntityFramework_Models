using DefiningModels;
using DefiningModels.Models;

Console.WriteLine("***** Defining Models *****");

using (ApplicationContext db = new ApplicationContext())
{
    db.Users.Add(new User { Name = "GreedNeSS", Age = 30, Company = new Company { Title = "Microsoft" } 
    });
    db.SaveChanges();
}