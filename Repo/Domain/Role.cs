using Helper.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repo.Domain
{
    public class Role : IBaseEntity
    {
        public Guid Id { get; set; }
        public bool Published { get; set; }
        public bool Deleted { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime? ModifiedOn { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string Name { get; set; }
    }
}
