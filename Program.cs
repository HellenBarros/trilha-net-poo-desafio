using DesafioPOO.Models;

// Teste Iphone
Console.WriteLine("Teste da classe iphone");
Smartphone iphone = new Iphone(numero: "123456", modelo: "Modelo iphone", imei: "111111111", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("whatsapp");


//Teste Nokia
Console.WriteLine("Teste da classe Nokia");
Smartphone nokia = new Nokia(numero: "789012", modelo: "Modelo nokia", imei: "000000000", memoria: 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Youtube");