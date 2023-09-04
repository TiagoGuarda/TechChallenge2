namespace Blog.API.Data.Models
{
    public class Noticia
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Conteudo { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string Autor { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
