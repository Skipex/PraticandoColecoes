

void DecifraCodigo()
{
    int[] numeros = { 5, 42, 8, 11, 23, 1, 14, 30, 19, 27, 36, 2, 50, 7, 18, 9 };

    int[] indices = new int[3];

    indices[0] = Array.IndexOf(numeros, 19);
    indices[1] = Array.IndexOf(numeros, 42);
    indices[2] = Array.IndexOf(numeros, 7);

    foreach (int indice in indices)
    {
        System.Console.WriteLine($"Índice: {indice}");
    }

}

void OrdenaArray()
{
    string[] nomes = { "Fernanda", "Eduardo", "Gustavo", "Carolina", "Alice", "Bruno", "Daniel" };

    Array.Sort(nomes);

    System.Console.WriteLine($"O terceiro nome da lista é: {nomes[2]}");    
}

void SomaDoacoes()
{
    double[] doacoes = { 103.54, 259.72, 82.16, 154.87, 364.45, 14.49 };

    double total = 0;
    foreach (double doacao in doacoes)
    {
        total += doacao;
    }

    System.Console.WriteLine($"Valor total das doações: {total}");
}

void TrabalhandoComArrays()
{
    string[] funcionarios = { "João", "Maria", "Oscar", "Claudia" };

    string[] funcionarioss = new string[] { "João", "Maria" };

    string[] funcionarios2 = new string[4]; // 0, 1, 2, 3


    System.Console.WriteLine(funcionarios[0]);

    //posição do Oscar
    int indiceOscar = Array.IndexOf(funcionarios, "Oscar");

    System.Console.WriteLine($"Índice do Oscar: {indiceOscar}");

    Array.Sort(funcionarios);
    foreach (var funcionario in funcionarios)
    {
        System.Console.WriteLine(funcionario);
    }

    //Copiando arrays
    string[] novosFuncionarios = new string[5];
    Array.Copy(funcionarios, novosFuncionarios, funcionarios.Length);

    System.Console.WriteLine("\n\nNovos funcionarios\n\n");
    foreach (var funcionario in novosFuncionarios)
    {
        System.Console.WriteLine(funcionario);
    }

    novosFuncionarios[4] = "Ana";

    System.Console.WriteLine("\n\nNovos funcionarios\n\n");
    foreach (var funcionario in novosFuncionarios)
    {
        System.Console.WriteLine(funcionario);
    }
}
