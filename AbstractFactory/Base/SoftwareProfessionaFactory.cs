namespace AbstractFactory
{
    public class SoftwareProfessionaFactory
    {
        public static SoftwareProfessional GetSoftwareProfessional(string type)
        {
            switch (type)
            {
                case "Java":
                    return new JavaProfessional();
                case "Dotnet":
                    return new DotnetProfessional();
            }
            return null;
        }
    }
}