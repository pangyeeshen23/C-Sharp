// A example of a void method
void MyFirstMethod()
{
    Console.WriteLine("My First Method Was Called");
    Console.WriteLine("Some super complicated code");
}
MyFirstMethod();

//Method Declaration
void WriteSomethingStupid(string myString)
{
    Console.WriteLine("You pass this argument to me " + myString);
}

string username = "Frank";
//Calling the method using an Argument called username
WriteSomethingStupid(username);

Console.WriteLine("This is outside of the method");
Console.ReadKey();