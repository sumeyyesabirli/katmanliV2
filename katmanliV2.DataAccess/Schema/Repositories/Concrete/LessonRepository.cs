using katmanliV2.Core.Repositories.Concrete;
using katmanliV2.DataAccess.Schema.Repositories.Abstract;
using katmanliV2.Entity.Schemas.MAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace katmanliV2.DataAccess.Schema.Repositories.Concrete
{
    public class LessonRepository : RepositoryBase<Lesson> , ILessonRepository
    {
    }
}
