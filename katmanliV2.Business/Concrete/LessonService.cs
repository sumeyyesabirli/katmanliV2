using katmanliV2.Business.Abstract;
using katmanliV2.Business.Dtos;
using katmanliV2.DataAccess.Schema.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace katmanliV2.Business.Concrete
{
    public class LessonService : ILessonService
    {
        private readonly ILessonRepository _lessonRepository;
        public LessonService(ILessonRepository lessonRepository)
        {
            _lessonRepository = lessonRepository;
        }
        public async Task<LessonDto> GetById(int id)
        {
            var data = await _lessonRepository.GetById(id);

            return new LessonDto
            {
                Id = data.Id, 
                Name = data.Name,
                Degree = data.Degree,
            };
        }
    }
}
