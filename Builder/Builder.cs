namespace Builder
{
    public class Builder
    {
        private string name;

        public Builder(string name)
        {
            this.name = name;
        }

        public void Build(string part)
        {
            System.Console.WriteLine(string.Format("{0}=> {1}", part, name));
        }
    }
}