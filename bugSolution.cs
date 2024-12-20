public class ExampleClass
{
    public int MyProperty { get; set; }
    public int AnotherProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
        AnotherProperty = 0; // Initialize AnotherProperty
    }

    public void MyMethod()
    {
        // Accessing a property that is now initialized
        Console.WriteLine(AnotherProperty); 
    }
}