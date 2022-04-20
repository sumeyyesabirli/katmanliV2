using katmanliV2.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace katmanliV2.Entity.Schemas.MAIN
{
    public class Lesson : BaseEntity
    {
        public string Name { get; set; }
        public int Degree { get; set; }
    }
}
