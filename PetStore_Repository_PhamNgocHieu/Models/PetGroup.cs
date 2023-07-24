using System;
using System.Collections.Generic;

namespace PetStore_Repository_PhamNgocHieu.Models
{
    public partial class PetGroup
    {
        public PetGroup()
        {
            Pets = new HashSet<Pet>();
        }

        public string PetGroupId { get; set; }
        public string PetGroupName { get; set; }
        public string GroupDescription { get; set; }
        public string OriginalSource { get; set; }

        public virtual ICollection<Pet> Pets { get; set; }
    }
}
