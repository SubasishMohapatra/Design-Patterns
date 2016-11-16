using System;

namespace AbstractFactoryRevisited
{
    public class DotnetSoftwareProfessionalFactory:SoftwareProfessionalFactory
    {
        public override DesktopProfessional GetDesktopProfessional()
        {
            return new DotnetDesktopProfessional();
        }

        public override WebProfessional GetWebProfessional()
        {
            return new DotnetWebProfessional();
        }
    }
}