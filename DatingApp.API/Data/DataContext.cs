using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    //Derived data from DbContext
    public class DataContext : DbContext
    {
        //Constructor. Add DbContextOptions then type/class using for out data context
        // and specify options. Also need to do call into the class are deriving from and its options.
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        // tell data context class about our entities. Value is Class of Modelas, particular DB set
        // Values is table name that gets created what we scaffold our database
        // To inform our app about data context Class, make this available as Service [to Startup.cs in ConfiguredServices method]
        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }


    }
}