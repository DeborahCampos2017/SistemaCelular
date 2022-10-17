using System;

namespace SistemaCelular.Models
{
    class Samsung : Celular
    {
        public Samsung(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
    {
    }

    public override void InstalarAplicativo(string nomeApp)
    {
        Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso!");
    }
}
}
