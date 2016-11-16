using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class DotnetProfessional:SoftwareProfessional
    {
        DotNetWebProfessional dotNetWebProfessional = new DotNetWebProfessional();
        DotNetDesktopProfessional dotNetDesktopProfessional = new DotNetDesktopProfessional();

        public override DesktopProfessional GetDesktopProfessional()
        {
            return dotNetDesktopProfessional;
        }

        public override WebProfessional GetWebProfessional()
        {
            return dotNetWebProfessional;
        }        
    }
}
