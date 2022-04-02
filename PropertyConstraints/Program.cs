using PropertyConstraints;
using PropertyConstraints.Models;

Console.WriteLine("***** Property Constraints *****");

using (ApplicationContext db = new ApplicationContext())
{
    db.Employee.Add(new User { Name = "GreedNeSS", Age = 30, });
    db.Employee.Add(new User { Name = "vaerjkbhkernbjkernlb jnerjvnkERNBJK.AENB/KRENnjvberahkvnqjekbrvhjkqn34ulvqe.lkvbltrebvtrjvlke rhbkaj jkBKernlbhK/WBMREJBvl;bwnblJRWBKRJEwvnbrejBVwnrkvbeKNK/L", Age = 30, });
    //db.Users.Add(new User { Name = "Terry", Age = 130, });
    db.SaveChanges();

    List<User> users = db.Employee.ToList();

    foreach (var user in users)
    {
        Console.WriteLine(user);
    }
}