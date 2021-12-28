// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");

await CafeDaManhaSincrono();
await CafeDaManhaAsincrono();

async Task CafeDaManhaSincrono()
{
    var st = new Stopwatch();
    st.Start();
    Console.WriteLine("Cafe da manhã sincrono");

    await AssaPaoDeQueijo();

    await EsquentarAgua();

    await BateVitamina();

    Console.WriteLine("arrumar a garrafa");

    Console.WriteLine("Coloca pó de café");

    Console.WriteLine("despeja a água na garrafa");

    Thread.Sleep(1000);

    Console.WriteLine("Café pronto");

    st.Stop();
    Console.WriteLine($"tempo gasto: {st.ElapsedMilliseconds}");
}

async Task CafeDaManhaAsincrono()
{
    var st = new Stopwatch();
    st.Start();
    Console.WriteLine("Cafe da manhã Asincrono");
    
    var paoDeQueijo = AssaPaoDeQueijo();

    var esquenta =EsquentarAgua();

    var vitamina = BateVitamina();

    Console.WriteLine("arrumar a garrafa");

    Console.WriteLine("Coloca pó de café");

    await esquenta;

    Console.WriteLine("despeja a água na garrafa");

    Thread.Sleep(1000);

    Console.WriteLine("Café pronto");

    await paoDeQueijo;

    await vitamina;

    st.Stop();
    Console.WriteLine($"tempo gasto: {st.ElapsedMilliseconds}");
}

async Task EsquentarAgua() {
    Console.WriteLine("esquenta água");

    await Task.Delay(10000);

    Console.WriteLine("água quente");
}

async Task AssaPaoDeQueijo()
{
    Console.WriteLine("coloca pão de quijo no fogo");

    await Task.Delay(10000);

    Console.WriteLine("Pao de quijo pronto");
}

async Task BateVitamina()
{
    Console.WriteLine("bate vitamina");

    await Task.Delay(1000);

    Console.WriteLine("vitamina pronta");
}
