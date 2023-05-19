using HR.RenewalsAndLayoffs.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HR.RenewalsAndLayoffs.Data.Context
{
	public class HRContext : DbContext
	{
		public HRContext()
		{

		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data Source=Employees.db");
		}

		public DbSet<Employee> Employees { get; set; }
	}
}