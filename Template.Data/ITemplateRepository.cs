using System.Collections.Generic;

namespace Template.Data
{
    public interface ITemplateRepository
    {
        List<string> GetAll();
    }
}