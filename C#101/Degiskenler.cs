using System;
class Degiskenler {
  static void Main(string[] args) {
    byte b = 5; //1 byte
    sbyte c = 5; //1 byte

    short s = 5; //2 byte
    ushort us = 5; //2 byte
    
    Int16 i16 = 2; //2 byte
    int i = 2;	//4 byte
    Int32 i32 = 2; //4 byte
    Int64 i64 = 2; //8 byte

    uint ui = 2; //4 byte
    long l = 4;	//8 byte
    ulong ul = 4;  //8 byte

    float f = 5;  //4 byte
    double d = 5;  //8 byte
    decimal de = 5; //16 byte

    char ch = '2'; //2 byte
    string str = "Akif"; //sınırsız

    bool b1 = true;
    bool b2 = false;

    DateTime dt = DateTime.Now;

    object o1 = "x";
    object o2 = 'y';
    object o3 = 4;
    object o4 = 4.3;

    //string ifadeler
    string str1 = string.Empty;
    str1 = "Akif"
    
    //integer tanımlama şekilleri
    int integer1 = 5;
    int integer2 = 3;
    int integer3 = integer1 * integer2;

    // boolean
    bool bool1 = 10>2;
    
    //degişken dönüşümleri
    string str20 = "20";
    int int20 = 20;

    string yeniDeger = str20 + int20.ToString();
    
    int int21 = int20 + Convert.ToInt32(str20);

    int 00int22 = int20 + int.Parse(str20);

    // datetime
    string datetime = DateTime.Now.ToString("dd.MM.yyyy");
    string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
    string hour = DateTime.Now.ToString("HH:mm");

  }
}
