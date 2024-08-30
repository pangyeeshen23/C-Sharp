// implicit conversion

int myInt = 13;
double myDouble = myInt;
long myLong = 132345098312389013;


// explicit conversion (casting)
int myInt2 = (int)myLong;

double myDouble2 = 13.5;
int myInt3 = (int)myDouble2;
Console.WriteLine(myInt2);
Console.WriteLine(myInt3);

float myFloat = 123.123f;
myDouble = 13.2123123123;

myFloat = (float)myDouble;
Console.WriteLine(myFloat);
