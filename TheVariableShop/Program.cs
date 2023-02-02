
// I declare every type that exist in c#
int iNumber = 1;
uint uiNumber = 2U;
long lNumber = 3L;
ulong ulNumber = 4UL;
short sNumber = 5;
ushort usNumber = 6;
byte bNumber = 7;
sbyte sbNumber = 8;
string sString = "nine";
char cChar = 'T';
float fNumber = 11.11F;
double dNumber = 12.12;
decimal decNumber = 0.000000000000013m;
bool bVariable = true;



Console.WriteLine("int: " + iNumber + "\n" + "uint: " + uiNumber + "\n" + "long: " + lNumber + "\n" + "ulong: " + ulNumber + "\n" + "short: " + sNumber + "\n" + "ushort: " + usNumber );
Console.WriteLine("byte: " + bNumber + "\n" + "sbyte: " + sbNumber + "\n" + "string: " + sString + "\n" + "char: " + cChar + "\n" + "float: " + fNumber + "\n" + "double: " + dNumber );
Console.WriteLine("decimal: " + decNumber+ "\n" + "bool: " + bVariable);

Console.WriteLine("Value updated");
//updates 
iNumber = 2;
uiNumber = 3;
lNumber = 4;
ulNumber = 5;
sNumber = 6;
usNumber = 7;
bNumber = 8;
sbNumber = 9;
sString = "ten";
cChar = 'e';
fNumber = 12.12f;
dNumber = 13.13;
decNumber = 0.00000014m;
bVariable = true;

Console.WriteLine("int: " + iNumber + "\n" + "uint: " + uiNumber + "\n" + "long: " + lNumber + "\n" + "ulong: " + ulNumber + "\n" + "short: " + sNumber + "\n" + "ushort: " + usNumber);
Console.WriteLine("byte: " + bNumber + "\n" + "sbyte: " + sbNumber + "\n" + "string: " + sString + "\n" + "char: " + cChar + "\n" + "float: " + fNumber + "\n" + "double: " + dNumber);
Console.WriteLine("decimal: " + decNumber + "\n" + "bool: " + bVariable);
