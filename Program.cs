
// DICIONÁRIOS
// Guardam uma estrutura de chave => valor

//TrabalhandoComDictionary();
//NotasAlunos();
//InventarioJogo();
TarefasSprint();

void TarefasSprint()
{
    // Inicialize um dicionário com algumas tarefas
    // Remova todas as tarefas do dicionário
    // Adicione novas tarefas
    // Liste as novas tarefas

    Dictionary<string, string> tarefas = new Dictionary<string, string>()  
    {  
        { "Refatorar módulo de login", "Ana" },  
        { "Testar API de pagamentos", "Pedro" }  
    };

    System.Console.WriteLine("Lista de tarefas da sprint 1: \n");

    foreach(var tarefa in tarefas)
    {
        System.Console.WriteLine($"Tarefa: {tarefa.Key} ({tarefa.Value})");
    }

    tarefas.Clear();

    tarefas.Add("Implementar autenticação OAuth", "João");  
    tarefas.Add("Otimizar consultas SQL", "Maria");  
    tarefas.Add("Atualizar documentação", "Carlos");

    System.Console.WriteLine("Lista de tarefas da sprint 2: \n");

    foreach(var tarefa in tarefas)
    {
        System.Console.WriteLine($"Tarefa: {tarefa.Key} ({tarefa.Value})");
    }
}


void InventarioJogo()
{
    // Inicialize um dicionário com itens.
    // Remova um item específico do inventário.
    // Adicione um novo item ao inventário.
    // Exiba a lista atualizada de itens.

    Dictionary<int, string> inventario = new Dictionary<int, string>()
        {
            { 1, "Espada Longa" },
            { 2, "Arco Curto" },
            { 3, "Escudo de Ferro" }
        };

    System.Console.WriteLine("Itens do inventário: \n");

    foreach (var item in inventario)
    {
        System.Console.WriteLine($"ID: {item.Key} - {item.Value} \n");
    }

    inventario.Remove(2);

    System.Console.WriteLine("Itens do inventário: \n");

    foreach (var item in inventario)
    {
        System.Console.WriteLine($"ID: {item.Key} - {item.Value} \n");
    }

    inventario.Add(4, "Poção de Vida");

    System.Console.WriteLine("Itens do inventário: \n");

    foreach (var item in inventario)
    {
        System.Console.WriteLine($"ID: {item.Key} - {item.Value} \n");
    }



}

void NotasAlunos()
{
    // Declare um dicionário com as informações de nome e nota de cada aluno
    // Use um loop para iterar sobre essas notas
    // Exiba as notas na tela

    Dictionary<string, double> alunosNotas = new Dictionary<string, double>
    {
      { "Gustavo", 8.75 },
      { "Amanda", 10 },
      { "Evelyn", 11.5 },
      { "Miguel", 15 }
    };

    foreach(KeyValuePair<string, double> alunoNota in alunosNotas)
    {
        System.Console.WriteLine($"O aluno {alunoNota.Key} tem nota: {alunoNota.Value}");
    }



}

void TrabalhandoComDictionary()
{
    Dictionary<int, string> produtos = new Dictionary<int, string>
    {
        { 4587963, "Teclado" },
        { 3374561, "Cadeira gamer" },
        { 2456987, "Notebook" },
        { 6356984, "Teclado" },
        { 8647921, "Mouse" }
    };
    produtos.Add(789456, "Placa de Vídeo");
    System.Console.WriteLine(produtos[2456987]);
    Dictionary<string, string> palavras = new Dictionary<string, string>
    {
        { "Olá", "Hello" },
        { "Mundo", "World" }
    };
    System.Console.WriteLine($"A tradução de olá é: {palavras["Olá"]}");
}





//HASHSET - CONJUNTO
// Dados que não tem repetição de elementos
// Não é possível pegar pelo Índice, apenas pelo valor

//TrabalhandoComHashSet();
//GamesScore();
//MensagemSecretaLista();
//SorteioLista();
//ListaInventario();

void ListaInventario()
{
    // Declare duas listas distintas de produtos.
    // Adicione todos os elementos da lista secundária na lista principal.
    // Exiba a lista principal com todos os produtos.

    List<string> produtosPrincipal = new List<string> { "Mouse", "Teclado", "Monitor", "Joystick"};  
    List<string> produtosSecundaria = new List<string> { "Headset", "Webcam", "Smartphone", "Mousepad" };

    produtosPrincipal.AddRange(produtosSecundaria);

    System.Console.WriteLine(string.Join(", ", produtosPrincipal));

}

void SorteioLista()
{
    // Declare uma lista de nomes.
    // Organize a lista em ordem alfabética.
    // Inverta a ordem da lista.
    // Remova o primeiro elemento e o adicione novamente na lista.
    // Agora verifique quem está no índice 3 da lista e exiba o nome no console.
    
    List<string> nomes = new List<string> { "Ana", "Carlos", "Mariana", "João", "Lúcia" };

    System.Console.WriteLine("\nLista original: \n");

    /*
    foreach( string nome in nomes)
    {
        System.Console.Write($"{nome}, ");
    }
    System.Console.Write("\n");*/
    System.Console.WriteLine(string.Join(", ", nomes));

    nomes.Sort();

    System.Console.WriteLine("\nLista ordenada: \n");

    /*
    foreach( string nome in nomes)
    {
        System.Console.Write($"{nome}, ");
    }
    System.Console.Write("\n");
    */
    System.Console.WriteLine(string.Join(", ", nomes));

    nomes.Reverse();

    System.Console.WriteLine("\nLista reversa: \n");

    /*
    foreach( string nome in nomes)
    {
        System.Console.Write($"{nome}, ");
    }
    System.Console.Write("\n");
    */
    System.Console.WriteLine(string.Join(", ", nomes));

    var nomeRemovido = nomes[0];
    nomes.RemoveAt(0);
    nomes.Add(nomeRemovido);

    System.Console.WriteLine("\nLista após remover o primeiro e adicioná-lo ao fim: \n");

    /*
    foreach( string nome in nomes)
    {
        System.Console.Write($"{nome}, ");
    }
    System.Console.Write("\n");
    */
    System.Console.WriteLine(string.Join(", ", nomes));

    System.Console.WriteLine($"\nO nome sorteado é: {nomes[3]}");




}

void MensagemSecretaLista()
{
    List<char> mensagem = new List<char>
    {
        'o', 'd', 'n', 'u', 'm', ' ', 'á', 'l', 'o'
    };

    mensagem.Reverse();

    foreach (char letra in mensagem)
    {
        System.Console.WriteLine(letra);
    }
}

void GamesScore()
{

    HashSet<int> scores = new HashSet<int>();

    scores.Add(150);
    scores.Add(90);
    scores.Add(200);
    scores.Add(120);
    scores.Add(150);
    scores.Add(80);
    scores.Add(180);
    scores.Add(200);

    List<int> scoresOrdenados = new List<int>(scores);

    scoresOrdenados.Sort();

    foreach (int score in scoresOrdenados)
    {
        System.Console.WriteLine(score);
    }
}

void TrabalhandoComHashSet()
{
    HashSet<string> setFuncionarios = new HashSet<string>
    {
        "Ana", "Paula", "Marcos", "José"
    };

    setFuncionarios.Remove("Marcos");

    setFuncionarios.Add("João");
    setFuncionarios.Add("Ana");

    foreach (string funcionario in setFuncionarios)
    {
        System.Console.WriteLine(funcionario);
    }


}







/****************** FUNÇÕES DE LISTAS ********************/

void TrabalhandoComListas()
{
    // LISTAS
    List<string> nomes = new List<string>
    {
        "Ana", "Paula", "Marcos", "José"
    };

    List<string> listaFuncionariosExp2 = new List<string>();

    listaFuncionariosExp2.Add("Ana");
    listaFuncionariosExp2.Add("Paula");
    listaFuncionariosExp2.Add("João");
    listaFuncionariosExp2.Add("Marcelo");
    listaFuncionariosExp2.Add("Thaís");

    System.Console.WriteLine("LISTAS\n\n");

    System.Console.WriteLine(listaFuncionariosExp2[2]);

    int indice = listaFuncionariosExp2.IndexOf("Marcelo");

    System.Console.WriteLine($"Índice do Marcelo: {indice}");

    System.Console.WriteLine("\nOrdenação\n");

    listaFuncionariosExp2.Sort();

    foreach (string funcionario in listaFuncionariosExp2)
    {
        System.Console.WriteLine(funcionario);
    }

    listaFuncionariosExp2.Add("Iasmin");
    listaFuncionariosExp2.Add("Joana");
    listaFuncionariosExp2.Remove("João");


    listaFuncionariosExp2.Sort();

    System.Console.WriteLine("\nLista com outros nomes:\n");

    foreach (string funcionario in listaFuncionariosExp2)
    {
        System.Console.WriteLine(funcionario);
    }
}

/****************** FUNÇÕES DE ARRAYS ********************/

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
