using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;

namespace LoanMelliBank.LoanInfo
{
    public class LoanBaseEntity : Entity<int>, IExtendableObject, ISoftDelete, IHasCreationTime, IAudited, IDeletionAudited
    {
        public string ExtensionData { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
    }
}
