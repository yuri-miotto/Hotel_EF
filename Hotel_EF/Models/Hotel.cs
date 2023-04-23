namespace Hotel_EF.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public DateTime DataCadastro { get; set; }
        public decimal Valor { get; set; }

        public override string ToString()
        {
            return "Id: " + Id + "\nNome: " + Nome + "\nEndereço: " + Endereco +
                "\nData de cadastro: " + DataCadastro + "\nValor: " + Valor;
        }
    }
}
