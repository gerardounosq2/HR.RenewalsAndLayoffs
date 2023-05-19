using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HR.RenewalsAndLayoffs.Data.Enums;

namespace HR.RenewalsAndLayoffs.Data.Models
{
	public class Employee
	{
		[Key]
		public int Id { get; set; }

		[StringLength(150)]
		public string EmployeeName { get; set; }

		public EmployeeCategoryType Category { get; set; }

		[StringLength(255)]
		public string JobPosition { get; set; }

		public EmployeeHiringType HiringType { get; set; }

		[Column(TypeName = "datetime")]
		public DateTime? ExpirationDate { get; set; } = null;

		[Column(TypeName = "bit")]
		public bool ContractStatus { get; set; }

		[Column(TypeName = "bit")]
		public bool FingerPrint { get; set; } = false;

		[Column(TypeName = "bit")]
		public bool Identification { get; set; }

		[Column(TypeName = "bit")]
		public bool ProofOfTaxSituation { get; set; } = false;
	}
}