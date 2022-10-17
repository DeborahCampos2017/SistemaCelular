using System;
using SistemaCelular.Models;

{
   Console.WriteLine("Smartphone Samsung:");
Samsung samsung = new Samsung(numero: "999999999", modelo: "Moto G 9", imei: "002345623633", memoria: 32);
    samsung.Ligar();
    samsung.InstalarAplicativo("whatsapp");

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone(numero: "999999999", modelo: "Ouro", imei: "123456123789", memoria: 64);
    iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
}
