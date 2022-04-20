using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace katmanliV2.Business.Dtos
{
    public class TeacherDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Title { get; set; }
        public bool Sex { get; set; }
    }
}
