using System;

namespace Helper.Entity
{
    public interface IBaseEntity
    {
        Guid Id { get; set; }
        bool Published { get; set; }
        bool Deleted { get; set; }
        DateTime CreatedOn { get; set; }
        DateTime? ModifiedOn { get; set; }
        string CreatedBy { get; set; }
        string ModifiedBy { get; set; }
    }
}
