// See https://aka.ms/new-console-template for more information

//Degiskenler();

//Person yeniVatandas = new Person(); //instance
//yeniVatandas.FirstName = "Umut Batuhan";
//yeniVatandas.LastName = "ALPAN";
//yeniVatandas.DateOfBirthYear = 1998;
//yeniVatandas.NationalIdentity = 1782394376;

//Console.WriteLine(yeniVatandas.FirstName + "\n"+ yeniVatandas.LastName + "\n"+ 
//    yeniVatandas.DateOfBirthYear + "\n"+ yeniVatandas.NationalIdentity);

//string isim = "Ahmet";
//SelamVer("Engin");
//SelamVer(isim);
//SelamVer(yeniVatandas.FirstName);
//SelamVer();

//int sayi = 9, sayi2 = 10
//Topla(sayi, sayi2);

using Business.Concrete;
using Entities.Concrete;

PttManager pttManager = new PttManager(new CitizenManager());

Person citizenPerson = new Person();
citizenPerson.NationalIdentity = 24076556230;
citizenPerson.FirstName = "Umut";
citizenPerson.LastName = "ALPAN";
citizenPerson.DateOfBirthYear = 1998;

pttManager.GiveMask(citizenPerson);

#region Degiskenler
static void Degiskenler()
{
    string mesaj = "Merhaba, Dünya!";
    double krediTutari = 100000;
    double kdvOrani = 1.18;
    bool girisYapildi = false;

    Console.WriteLine(mesaj);
    Console.WriteLine(mesaj);
    Console.WriteLine(mesaj);
    Console.WriteLine(mesaj);

    Console.WriteLine("Kredi Tutarı: " + (krediTutari * kdvOrani).ToString());
    Console.WriteLine("Giriş " + (girisYapildi ? "yapıldı." : "yapılmadı."));
}
#endregion

#region Method / Fonksiyon
    //Bir işi yapacak kodu bir blok içerisine koyuyorsun ve akışta ihtiyaç duyulan noktada çağırıp kullanabiliyorsun.
static void SelamVer(string isim = "isimsiz")   //Default parametre
{
    Console.WriteLine("Merhaba" + isim);
}

static int Topla(int sayi1, int sayi2)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam: " + sonuc);  //("Toplam: " + sonuc.ToString()) normalde bu şekilde yazılır fakat WriteLine() otomatik type casting yapacaktır.
    return sonuc;
}
#endregion

#region Diziler / Arrays

string[] ogrenciler = new string[3];
ogrenciler[0] = "Engin";
ogrenciler[1] = "Kerem";
ogrenciler[2] = "Berkay";

foreach (var ogrenci in ogrenciler)     //Döngüler birbirine benzeyen işleri tekrar tekrar yapmak yerine bir kerede yapmamıza yarar.
{
    Console.WriteLine(ogrenci);
}
#endregion