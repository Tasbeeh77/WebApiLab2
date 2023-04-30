using Lab2.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab2.DAL.Data.Context
{
    public class DevContext: DbContext
    {
        public DbSet<Ticket> Ticket => Set<Ticket>();
        public DbSet<Department> Departments => Set<Department>();
        public DbSet<Developer> Developers => Set<Developer>();
        public DevContext(DbContextOptions<DevContext> options)
        : base(options)
        {        
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Tickets
            var tickets = new List<Ticket>
            {
                new Ticket
                {
                    Id = 1,
                    Title = "Printer not working",
                    Description = "The printer in the accounting department is not printing anything.",
                    departmentId = 2
                },
                new Ticket
                {
                    Id = 2,
                    Title = "Can't access email",
                    Description = "I'm unable to access my email account. It keeps saying my password is incorrect.",
                    departmentId = 1
                },
                new Ticket
                {
                    Id = 3,
                    Title = "Networking issue",
                    Description = "The internet connection in the marketing department is very slow and keeps dropping.",
                    departmentId = 3
                },
                new Ticket
                {
                    Id = 4,
                    Title = "Software not working",
                    Description = "The new software we installed in the HR department is not functioning properly.",
                    departmentId = 4
                },
                new Ticket
                {
                    Id = 5,
                    Title = "Can't connect to VPN",
                    Description = "I'm unable to connect to the company VPN. It keeps giving me an error.",
                    departmentId = 5
                },
                new Ticket
                {
                    Id = 6,
                    Title = "Need new laptop",
                    Description = "My laptop is very old and slow. I need a new one to do my work effectively.",
                    departmentId = 1
                },
                new Ticket
                {
                    Id = 7,
                    Title = "Printer jam",
                    Description = "The printer in the sales department is jammed and needs to be fixed.",
                    departmentId = 2
                },
                new Ticket
                {
                    Id = 8,
                    Title = "Website down",
                    Description = "The company website is not loading. I keep getting a 404 error.",
                    departmentId = 3
                },
                new Ticket
                {
                    Id = 9,
                    Title = "Need more storage space",
                    Description = "I'm running out of storage space on my computer. Can I get an external hard drive?",
                    departmentId = 4
                },
                new Ticket
                {
                    Id = 10,
                    Title = "Can't print in color",
                    Description = "I'm trying to print a document in color, but it's only coming out in black and white.",
                    departmentId = 2
                }
            };
            #endregion
            #region Departments
            var departments = new List<Department>
            {
                new Department
                {
                    Id = 1,
                    Name = "IT"
                },
                new Department
                {
                    Id = 2,
                    Name = "Accounting"
                },
                new Department
                {
                    Id = 3,
                    Name = "Marketing"
                },
                new Department
                {
                    Id = 4,
                    Name = "HR"
                },
                new Department
                {
                    Id = 5,
                    Name = "Operations"
                },
                new Department
                {
                    Id = 6,
                    Name = "Legal"
                },
                new Department
                {
                    Id = 7,
                    Name = "Sales"
                },
                new Department
                {
                    Id = 8,
                    Name = "Customer Service"
                },
                new Department
                {
                    Id = 9,
                    Name = "Engineering"
                },
                new Department
                {
                    Id = 10,
                    Name = "Research and Development"
                }
            };
            #endregion
            #region Developer
            var developers = new List<Developer>
            {
                new Developer
                {
                    Id = 1,
                    Name = "John Doe"
                },
                new Developer
                {
                    Id = 2,
                    Name = "Jane Doe"
                },
                new Developer
                {
                    Id = 3,
                    Name = "Bob Smith"
                },
                new Developer
                {
                    Id = 4,
                    Name = "Alice Johnson"
                },
                new Developer
                {
                    Id = 5,
                    Name = "Mike Brown"
                },
                new Developer
                {
                    Id = 6,
                    Name = "Sarah Lee"
                },
                new Developer
                {
                    Id = 7,
                    Name = "David Kim"
                },
                new Developer
                {
                    Id = 8,
                    Name = "Emily Chen"
                },
                new Developer
                {
                    Id = 9,
                    Name = "Alex Rodriguez"
                },
                new Developer
                {
                    Id = 10,
                    Name = "Jessica Lee"
                }
            };
            #endregion
            modelBuilder.Entity<Ticket>().HasData(tickets);
            modelBuilder.Entity<Department>().HasData(departments);
            modelBuilder.Entity<Developer>().HasData(developers);
        }
    }
}
