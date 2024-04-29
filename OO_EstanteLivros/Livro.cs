internal class Livro
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
    public string InformarLivro()
    {
        string Livro = "";
        Livro += $"Título: {this.titulo}\n";
        Livro += $"Dt.Lançamento: {this.dtlancamento}\n";
        Livro += $"Autor(es): ";
        for (int i = 0; i < 3; i++)
        {
            if (this.autores[i] != null)
            {
                Livro += $"{this.autores[i]}. ";
            }
        }
        Livro += $"Editora: {this.editora}\n";
        Livro += $"Edição: {this.edicao}\n";
        Livro += $"ISBN: {this.isbn}\n";
        Livro += $"{this.paginas} páginas";

        return Livro;
    }
}