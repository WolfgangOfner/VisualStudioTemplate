using System.Collections.Generic;
using $ext_safeprojectname$.Data;

namespace $ext_safeprojectname$.Service
{
    public class $ext_safeprojectname$Service : I$ext_safeprojectname$Service
    {
        private readonly I$ext_safeprojectname$Repository _repository;

        public $ext_safeprojectname$Service(I$ext_safeprojectname$Repository repository)
        {
            _repository = repository;
        }

        public List<string> GetAll()
        {
            return _repository.GetAll();
        }
    }
}