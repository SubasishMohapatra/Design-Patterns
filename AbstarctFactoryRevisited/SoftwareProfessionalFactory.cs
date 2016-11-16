namespace AbstractFactoryRevisited
{
    public abstract class SoftwareProfessionalFactory
    {
        public abstract DesktopProfessional GetDesktopProfessional();
        public abstract WebProfessional GetWebProfessional();
    }
}