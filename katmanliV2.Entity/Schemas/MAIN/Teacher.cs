using katmanliV2.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace katmanliV2.Entity.Schemas.MAIN
{
    public class Teacher : BaseEntity
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Title { get; set; }
        public bool Sex { get; set; }
    }
}
