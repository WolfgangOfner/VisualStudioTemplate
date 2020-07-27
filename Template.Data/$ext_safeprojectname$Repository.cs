using System.Collections.Generic;

namespace $ext_safeprojectname$.Data
{
    public class $ext_safeprojectname$Repository : I$ext_safeprojectname$Repository
    {
        public List<string> GetAll()
        {
            return new List<string>{"Data", "Name", "Words"};
        }
    }
}