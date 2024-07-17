using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smarphone Nokia: ");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Nokia01", iMEI: "542187446", memoria: 64);

nokia.Ligar();
Console.WriteLine("\n");

nokia.ReceberLigacao();
Console.WriteLine("\n");

nokia.InstalarAplicativo("Instagram");

Console.WriteLine("--------------------");

Console.WriteLine("Smarphone Iphone: ");
Smartphone iphone = new Iphone(numero: "456323", modelo: "13 ProMax", iMEI: "8764684314", memoria: 128);

iphone.Ligar();
Console.WriteLine("\n");

iphone.ReceberLigacao();
Console.WriteLine("\n");

iphone.InstalarAplicativo("Telegram");

