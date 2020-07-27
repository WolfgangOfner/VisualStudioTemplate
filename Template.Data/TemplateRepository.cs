using System.Collections.Generic;

namespace Template.Data
{
    public class TemplateRepository : ITemplateRepository
    {
        public List<string> GetAll()
        {
            return new List<string>{"Data", "Name", "Words"};
        }
    }
}