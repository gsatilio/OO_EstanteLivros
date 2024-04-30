public class Livro
{
    public string titulo;
    public string[] autores = new string[3];
    public DateOnly dtlancamento;
    public string editora;
    public int edicao;
    public int isbn;
    public int paginas;

    public Livro()
    {

    }

    // criado com create construct apertando Ctrl + ponto
    /*public Livro(string titulo, string[] autores, DateOnly dtlancamento, string editora, int edicao, int isbn, int paginas)
    {
        this.titulo = titulo;
        this.autores = autores;
        this.dtlancamento = dtlancamento;
        this.editora = editora;
        this.edicao = edicao;
        this.isbn = isbn;
        this.paginas = paginas;
    }*/

    public void DefinirTitulo(string dados)
    {
        this.titulo = dados;
    }
    public void DefinirAutores(int autores, string dados)
    {
        this.autores[autores] = dados;
    }
    public void DefinirDtLancamento(DateOnly dados)
    {
        this.dtlancamento = dados;
    }
    public void DefinirEditora(string dados)
    {
        this.editora = dados;
    }
    public void DefinirEdicao(int dados)
    {
        this.edicao = dados;
    }
    public void DefinirISBN(int dados)
    {
        this.isbn = dados;
    }
    public void DefinirPaginas(int dados)
    {
        this.paginas = dados;
    }
    public string ImprimirLivro()
    {
        string LivroImpresso = "";
        LivroImpresso += $"Título: {this.titulo}\n";
        LivroImpresso += $"Dt.Lançamento: {this.dtlancamento}\n";
        LivroImpresso += $"Autor(es): ";
        for (int i = 0; i < 3; i++)
        {
            if (this.autores[i] != null)
            {
                LivroImpresso += $"{this.autores[i]}. ";
            }
        }
        LivroImpresso += $"Editora: {this.editora}\n";
        LivroImpresso += $"Edição: {this.edicao}\n";
        LivroImpresso += $"ISBN: {this.isbn}\n";
        LivroImpresso += $"{this.paginas} páginas";

        return LivroImpresso;
    }
}