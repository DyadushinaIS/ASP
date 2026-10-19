using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
    [PrimaryKey(nameof(teacher),nameof(discipline))]
    public class TeachersDisciplinesRelation
    {
        //[Key]
        [Column(TypeName ="SMALLINT")]
        [ForeignKey(nameof(teacher))]
        public int teacher {  get; set; }
        //[Key]
        [Column(TypeName ="SMALLINT")]
        [ForeignKey(nameof(discipline))]
        public int discipline { get; set; }

        //Navigation Properties

        public Teacher Teacher { get; set; }
        public Discipline Discipline { get; set; }
    }
}
