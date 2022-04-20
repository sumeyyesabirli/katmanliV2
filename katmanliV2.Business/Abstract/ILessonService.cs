using katmanliV2.Business.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace katmanliV2.Business.Abstract
{
    public interface ILessonService
    {
        Task<LessonDto> GetById(int id);
    }
}
