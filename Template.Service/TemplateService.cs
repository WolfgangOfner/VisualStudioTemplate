using System.Collections.Generic;
using Template.Data;

namespace Template.Service
{
    public class TemplateService : ITemplateService
    {
        private readonly ITemplateRepository _repository;

        public TemplateService(ITemplateRepository repository)
        {
            _repository = repository;
        }

        public List<string> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
