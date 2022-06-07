using DZDFreeTim.Data.Entity;

namespace DZDFreeTim.Data
{
    public class SeedHelper
    {
        public static void Seed()
        {
            using (var context = new AppDbContext())
            {
                if (!context.Employees.Any())
                {
                    var admin = new Employee
                    {
                        Name = "cem",
                        Email = "cem@site.com",
                        Password = "123",
                        EmployeeType = "Admin"
                    };
                    context.Employees.Add(admin);

                    var user1 = new Employee()
                    {
                        Name = "cem",
                        Email = "cem@site.com",
                        Password = "123",
                        EmployeeType = "Analist"

                    };
                    context.Employees.Add(user1);

                    var user2 = new Employee()
                    {
                        Name = "ali",
                        Password = "123",
                        Email = "jerfi_ali@site.com",
                        EmployeeType = "Yazılımcı"
                    };
                    context.Employees.Add(user2);

                    context.SaveChanges();
                }


            }

        }
    }
}
