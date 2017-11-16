using System;
using System.ComponentModel.DataAnnotations;

namespace DHX.Gantt.Web.Models
{
    public class Task
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string Text { get; set; }
        public DateTime StartDate { get; set; }
        public int Duration { get; set; }
        public int SortOrder { get; set; }
        public decimal Progress { get; set; }
        public int? ParentId { get; set; }

        public string Type { get; set; }
    }
}