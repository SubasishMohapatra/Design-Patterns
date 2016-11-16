using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class JavaProfessional : SoftwareProfessional
    {
        JavaDesktopProfessional javaDesktopProfessional = new JavaDesktopProfessional();
        JavaWebProfessional javaWebProfessional = new JavaWebProfessional();

        public override DesktopProfessional GetDesktopProfessional()
        {
            return javaDesktopProfessional;
        }

        public override WebProfessional GetWebProfessional()
        {
            return javaWebProfessional;
        }
    }
}
