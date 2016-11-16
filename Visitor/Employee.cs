namespace Visitor
{
    public abstract class Employee
    {
        Trainer trainer;

        public Employee(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public void Accept(Trainer trainer)
        {
            this.trainer = trainer;
            this.trainer.Visit(this);
        }
    }
}