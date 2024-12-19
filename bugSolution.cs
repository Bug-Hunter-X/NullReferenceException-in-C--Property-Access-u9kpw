public class MyClass {
    public int? MyProperty { get; set; } //Nullable Integer

    public void MyMethod() {
        //This handles the case where the MyProperty is null
        Console.WriteLine(MyProperty?.ToString() ?? "MyProperty is null"); 
    }
}