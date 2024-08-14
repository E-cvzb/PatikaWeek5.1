// See https://aka.ms/new-console-template for more information
List<string> guest =new List<string>();//Yeni bir liste tanımlamak 

Console.WriteLine("Kaç davetli geleceğini girermisiniz ");
int guestnumber=Convert.ToInt32(Console.ReadLine());//Davetli sayısı girilerek döngünün kaç kez döneceği belirlenir 

for(int i=0; i<guestnumber; i++)//Davetli girişi 
{
    Console.WriteLine("Lütfen davetli giriniz");
    guest.Add(Console.ReadLine());
    Console.WriteLine("------0----------0--------0------");
}
Console.WriteLine("Davetli sayınızın tam listesi");
 
for (int i=0;i<guestnumber; i++)//Davetlileri okuma işlemi
{
    Console.WriteLine($"{i+1}) {guest[i]}");
}