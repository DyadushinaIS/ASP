using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
	public class Instructor
	{
		public int ID { get; set; }

		[Required]
		[DisplayName("Фамилия")]
		[StringLength(50)]
		public string LastName { get; set; }

		[Required]
		[DisplayName("Фамилия")]
		[StringLength(50)]
		public string FirstName { get; set; }

		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy.MM.dd}", ApplyFormatInEditMode = true)]
		[DisplayName("Дата трудоустройства")]

		public DateTime HireDate { get; set; }

		//Calculated Properties
		[Display(Name ="Преподаватель")]
		public string FullName
		{
			get=>$"{FirstName} {LastName}";
		}

		//Navigation Properties
	}
}
