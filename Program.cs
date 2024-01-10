using DesafioPOO.Models;
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123156",modelo:"Modelo 1z",imei: "34324253", memoria: 128); 
nokia.Ligar();
nokia.InstalarAplicativo("Outlook");

Console.WriteLine("\n");
Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "578349",modelo:"14",imei: "31233433", memoria: 256); 
iphone.Ligar();
iphone.InstalarAplicativo("Tik tok");
// TODO: Realizar os testes com as classes Nokia e Ipho