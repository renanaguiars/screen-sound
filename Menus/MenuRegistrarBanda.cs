using ScreenSound.Modelos;
namespace ScreenSound.Menus;

internal class MenuRegistrarBanda : Menu 
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeBanda))
        {
            Console.WriteLine("Essa banda já está registrada.");
        }
        else
        {
            Banda banda = new(nomeBanda);
            bandasRegistradas.Add(nomeBanda, banda);
            Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
        }

        Thread.Sleep(2000);
        Console.Clear();
    }
}
