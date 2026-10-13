///параметры позволяют передать в метод некоторые входные данные\\\

void PrintMessage(string message)
{
    Console.WriteLine(message);
}

PrintMessage("Hello Bogdan");           // Hello Bogdan
PrintMessage("Hello Programa");    // Hello Programa
PrintMessage("Hello Code");             // Hello Code

///формальные параметры и фактические параметры\\\


void Sum(int x, int y) => Console.WriteLine($"{x} + {y} = {x + y}");

int a = 67, b = 42, c = 52;
Sum(a, b);                  // 67 + 42 = 109
Sum(3, c);                  // 3 + 52 = 55
Sum(14, +c);             // 14 + 52 = 66

///Соответствие параметов и аргументов по типу данных\\\

void PrintPerson(string name, int age)
{
    Console.WriteLine($"Name: {name}  Age: {age}");
}

byte b = 14;
PrintPerson("Bogdan", b); // Name: Tom  Age: 37

///Необязательные параметры\\\

void PrintPerson(string name, int age = 36, string company = "Gucci")
{
    Console.WriteLine($"Name: {name}  Age: {age}  Company: {company}");
}

PrintPerson("Bogdan", company: "Minecraft", age: 14);  // Name: Bogdan  Age: 14  Company: Minecraft
PrintPerson(age: 38, name: "Timyr");          // Name: Timyr  Age: 38 Company: Gucci
PrintPerson(company: "Dolce & Gabbana", name: "Ariana"); // Name: Ariana  Age: 36   Company: Dolce & Gabbana





