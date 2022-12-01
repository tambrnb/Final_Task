string [] array = {"-2", "Hello World", "GeekBrans", "Show me the meaning of being lonely", "May the force be with you", "with great power comes great responsibility"};
int n = array.Length;
int size = n-3;
string [] newArray = new string [size];
for (int i = 0; i <size; i++)
{
    newArray[i] = array[new Random().Next(n)];
}
Console.Write(String.Join(",", newArray));