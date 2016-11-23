using System;

namespace AbstractFactoryRevisited
{
    public class JavaSoftwareProfessionalFactory:SoftwareProfessionalFactory
    {
        public override DesktopProfessional GetDesktopProfessional()
        {
            return new JavaDesktopProfessional();
        }

        public override WebProfessional GetWebProfessional()
        {
            return new JavaWebProfessional();
        }
    }
}