namespace AbstractFactory
{
    public abstract class SoftwareProfessional
    {
        public abstract DesktopProfessional GetDesktopProfessional();
        public abstract WebProfessional GetWebProfessional();
    }
}