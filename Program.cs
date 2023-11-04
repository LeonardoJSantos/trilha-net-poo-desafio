using DesafioPOO;
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "991537154",modelo: "N900",imei:"245855",memoria: 256);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine();

Console.WriteLine("SmartPhone Iphone");
Smartphone iphone = new Iphone(numero: "991537784", modelo: "13", imei: "24554855", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Clash of Clans");