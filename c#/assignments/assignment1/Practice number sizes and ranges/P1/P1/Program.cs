// See https://aka.ms/new-console-template for more information
Console.WriteLine("*************** C# Built-in Numeric Types **************/");
string[] types = { "byte", "short", "int", "long", "sbyte", "ushort", "uint", "ulong", "char" };
string[] ranges = { "0 to 255", "-32,768 to 32,767", "-2,147,483,648 to 2,147,483,647", "-9,223,372,036,854,775,808  to 9,223,372,036,854,775,807", "-128 to +127", "0 to 65,535", "0 to 4,294,967,295", "0 to 18,446,744,073,709,551,615", "U+0000 to U+ffff(All Unicode characters)" };
int[] bytes = { 1, 2, 4, 8, 1, 2, 4, 8, 2 };

String data = String.Format("{0,-10} {1,-5} {2,-40}\n",
"Type", "Byte", "Range");
for (int index = 0; index < types.Length; index++)
    data += String.Format("{0,-10} {1,-5} {2,-40}\n",
    types[index], bytes[index], ranges[index]);
Console.WriteLine($"\n{data}");
