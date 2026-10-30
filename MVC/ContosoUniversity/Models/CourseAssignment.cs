using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
	[PrimaryKey(nameof(InstructorID), nameof(CourseID))]
	public class CourseAssignment
	{
		//			Composite Primary Key		
		public int InstructorID { get; set; }
		public int CourseID { get; set; }
		//			Composite Primary Key

		//Navigation Properties:
		public Instructor Instructor { get; set; }
		public Course Course { get; set; }
	}
}
