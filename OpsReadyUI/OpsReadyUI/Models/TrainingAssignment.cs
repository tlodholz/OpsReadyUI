using System;

namespace OpsReadyUI.Models
{
    public class TrainingAssignment
    {
        public int Id { get; set; }
        public int TrainingEventId { get; set; }
        public int UserId { get; set; }
        public int TrainingRecordId { get; set; }
        public DateTime AssignedDate { get; set; }
        public int AssignedByUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedByUserId { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
