public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Accessing a property that is not initialized
        Console.WriteLine(AnotherProperty); 
    }
    public int AnotherProperty { get; set; }
}