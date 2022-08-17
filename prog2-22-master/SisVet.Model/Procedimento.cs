namespace SisVet.Model
{
    public class Procedimento
    {
        public int Id{ get; set; }
        public string TipoProcedimento { get; set; }
        public string Descricao{ get; set; }

        public Procedimento()
        {
        }

        public Procedimento(int id)
        {
            Id = id;
        }
    }
}
