using System.Runtime.InteropServices;
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("324577", "Modelo 1", "1111111111", 8);
nokia.Ligar();
nokia.InstalarAplicativo("Jogo da Cobrinha");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("153442", "Modelo 2", "2222222222", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
// TODO: Realizar os testes com as classes Nokia e Iphone