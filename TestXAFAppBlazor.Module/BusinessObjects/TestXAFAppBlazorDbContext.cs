using DevExpress.ExpressApp.EFCore.Updating;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using DevExpress.Persistent.BaseImpl.EF.PermissionPolicy;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.ExpressApp.Design;
using DevExpress.ExpressApp.EFCore.DesignTime;
using DevExpress.Utils.Serializing;

namespace TestXAFAppBlazor.Module.BusinessObjects;

// This code allows our Model Editor to get relevant EF Core metadata at design time.
// For details, please refer to https://supportcenter.devexpress.com/ticket/details/t933891.
public class TestXAFAppBlazorContextInitializer : DbContextTypesInfoInitializerBase {
	protected override DbContext CreateDbContext() {
		var optionsBuilder = new DbContextOptionsBuilder<TestXAFAppBlazorEFCoreDbContext>()
            .UseSqlServer(";")
            .UseChangeTrackingProxies()
            .UseObjectSpaceLinkProxies();
        return new TestXAFAppBlazorEFCoreDbContext(optionsBuilder.Options);
	}
}
//This factory creates DbContext for design-time services. For example, it is required for database migration.
//public class TestXAFAppBlazorDesignTimeDbContextFactory : IDesignTimeDbContextFactory<TestXAFAppBlazorEFCoreDbContext> {
//	public TestXAFAppBlazorEFCoreDbContext CreateDbContext(string[] args) {
//		throw new InvalidOperationException("Make sure that the database connection string and connection provider are correct. After that, uncomment the code below and remove this exception.");
//		//var optionsBuilder = new DbContextOptionsBuilder<TestXAFAppBlazorEFCoreDbContext>();
//		//optionsBuilder.UseSqlServer("Integrated Security=SSPI;Data Source=(localdb)\\mssqllocaldb;Initial Catalog=TestXAFAppBlazor");
//        //optionsBuilder.UseChangeTrackingProxies();
//        //optionsBuilder.UseObjectSpaceLinkProxies();
//		//return new TestXAFAppBlazorEFCoreDbContext(optionsBuilder.Options);
//	}
//}


//This factory creates DbContext for design-time services.For example, it is required for database migration.
public class TestXAFAppBlazorDesignTimeDbContextFactory : IDesignTimeDbContextFactory<TestXAFAppBlazorEFCoreDbContext>
{
    public TestXAFAppBlazorEFCoreDbContext CreateDbContext(string[] args)
    {

        // Throw new InvalidOperationException("Make sure that the database connection string and connection provider are correct. After that, uncomment the code below and remove this exception.");
        var optionsBuilder = new DbContextOptionsBuilder<TestXAFAppBlazorEFCoreDbContext>();
        optionsBuilder.UseSqlServer("Integrated Security=SSPI;Pooling=false;Data Source=INCGR-X379-G01\\SQLEXPRESS;Initial Catalog=TestXAFApp;TrustServerCertificate=true");
        // Automatically implements the INotifyPropertyChanged interface in the business objects
        optionsBuilder.UseChangeTrackingProxies();
        optionsBuilder.UseObjectSpaceLinkProxies();
        return new TestXAFAppBlazorEFCoreDbContext(optionsBuilder.Options);
    }
}

[TypesInfoInitializer(typeof(TestXAFAppBlazorContextInitializer))]
public class TestXAFAppBlazorEFCoreDbContext : DbContext {
	public TestXAFAppBlazorEFCoreDbContext(DbContextOptions<TestXAFAppBlazorEFCoreDbContext> options) : base(options) {
	}
    //public DbSet<ModuleInfo> ModulesInfo { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<ProjectTask> ProjectTasks { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Setup> Setups { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);
        modelBuilder.HasChangeTrackingStrategy(ChangeTrackingStrategy.ChangingAndChangedNotificationsWithOriginalValues);
        modelBuilder.UsePropertyAccessMode(PropertyAccessMode.PreferFieldDuringConstruction);
    }
}
