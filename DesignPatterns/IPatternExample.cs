namespace DesignPatterns
{
    public interface IPatternExample
    {
        string Category { get; }

        string Name { get; }

        ExampleTypes ExampleType { get; }

        void Main();
    }

    public enum ExampleTypes
    {
        Structural,
        RealWorld
    }
}
