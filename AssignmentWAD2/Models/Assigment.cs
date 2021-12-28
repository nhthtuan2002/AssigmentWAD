using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AssignmentWAD2.Models
{
    public class Assigment
    {
        [Key]
        public int Id { get; set; }
        public string ExamSubject { get; set; }
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ExamDate { get; set; }
        public int ExamDuration { get; set; }
        public string ClassRoom { get; set; }
        public string Faculty { get; set; }
        public string Status { get; set; }
    }
}