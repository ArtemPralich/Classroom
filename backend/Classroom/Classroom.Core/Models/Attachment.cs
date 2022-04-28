﻿#nullable disable

namespace Classroom.Entities.Models
{
    public partial class Attachment : BaseEntity
    {
        public override int Id { get; set; }
        public string Path { get; set; }
        public string Name { get; set; }
        public string StudentId { get; set; }
        public int? TaskId { get; set; }
        
        public virtual Task Task { get; set; }
    }
}
