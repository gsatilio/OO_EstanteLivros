int QtdeLivros = 0, contLivro = 0;
Livro[] estante = new Livro[10];

Livro GerarObjetoLivro(int nrolivro)
{
    int autores = 0;
    Livro objLivro = new Livro();

    Console.WriteLine($"Informe o título do seu {contLivro + 1} livro:");
    objLivro.DefinirTitulo(Console.ReadLine());

    while (autores <= 0)
    {
        Console.WriteLine("Quantos autores possui o seu livro?");
        autores = int.Parse(Console.ReadLine());
    }
    for (int i = 0; i < autores; i++)
    {
        Console.WriteLine($"Informe o nome do {i + 1}o Autor:");
        objLivro.DefinirAutores(i, Console.ReadLine());
    }

    Console.WriteLine("Informe a data de lançamento do livro:");
    objLivro.DefinirDtLancamento(DateOnly.Parse(Console.ReadLine()));

    Console.WriteLine("Informe a Editora do seu livro:");
    objLivro.DefinirEditora(Console.ReadLine());

    Console.WriteLine("Informe a edição do seu livro:");
    objLivro.DefinirEdicao(int.Parse(Console.ReadLine()));

    Console.WriteLine("Informe o código ISBN do seu livro:");
    objLivro.DefinirISBN(int.Parse(Console.ReadLine()));

    Console.WriteLine("Informe a quantidade de páginas do seu livro:");
    objLivro.DefinirPaginas(int.Parse(Console.ReadLine()));

    return objLivro;
}
void InserirLivro()
{
    while (QtdeLivros <= 0)
    {
        Console.WriteLine("Informe a quantidade de livros que deseja inserir em sua Estante: ");
        QtdeLivros = int.Parse(Console.ReadLine());
    }
    for (int i = 0; i < QtdeLivros; i++)
    {
        Livro meuLivro = new Livro();
        meuLivro = GerarObjetoLivro(QtdeLivros);
        estante[i] = meuLivro; // meuLivro/meuLivro.ImprimirLivro();
        contLivro++;
    }
}
void ImprimirEstante()
{
    int posicao;
    Console.WriteLine("Escolha o seu livro informando o número de 1 a 10.\nCaso deseja ver todos os livros, digite 0.");
    posicao = int.Parse(Console.ReadLine());
    switch (posicao)
    {
        case 0:
            for (int i = 0; i < 10; i++)
            {
                if (estante[i] != null)
                {
                    Console.WriteLine(estante[i].ImprimirLivro());
                    Console.WriteLine();
                }
            }
            break;
        default:
            while (posicao > 0 && posicao < 10)
            {
                if (estante[posicao - 1] == null)
                {
                    Console.WriteLine("Essa prateleira não possui livros!");
                    posicao = -1;
                }
                else
                {
                    Console.WriteLine(estante[posicao - 1].ImprimirLivro());
                    posicao = -1;
                }
            }
            break;
    }
}
InserirLivro();
while (true)
{
    ImprimirEstante();
}