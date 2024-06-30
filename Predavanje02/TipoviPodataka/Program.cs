// Cjelobrojni tipovi
// 8-bitni
byte bVarijabla1 = 255;
sbyte sVarijabla2 = 127; // signed
// 16-bitni
short shVarijabla3 = -32745;
ushort usVarijabla4 = 65535; // unsigned
// 32-bitni
int iVarijabla = 2121211215;
uint uiVarijabla = 4254564542;
// 64-bitni
long lVarijabla = 143564651357432132;
ulong ulVarijabla = 143564651357432134;

// Decimalni tipovi
float fVarijabla = 3.545571852555f; // sufix f - explicitno da nije double!
double dVarijabla = 3.5455718526465432135434444; // default bez sufixa
decimal deVarijabla = 3.5455718526465432654352135876m;

// Znakovni tipovi
char chVarijabla = 'a';
string stVarijabla = "abc";


// Logički tipovi
bool boVarijabla = true;
object obVarijabla = null;
DateTime dtVarijabla = new DateTime(2024, 3, 4);

// Defaultne vrijednosti
// Za sve brojevne vrijednosti = 0
// Za logičke = false
// Za znakovne char '\0' ; string null