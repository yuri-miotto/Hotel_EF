namespace Hotel_EF.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Complemento { get; set; }
        public Cidade Cidade { get; set; }
        public DateTime DataCadastro { get; set; }

        public override string ToString()
        {
            return "Id: " + Id + "\nLogradouro: " + Logradouro + "\nNumero: " + Numero +
                "\nBairro: " + Bairro + "\nCEP: " + CEP + "\nComplemento: " + Complemento + "\nCidade: " + Cidade + "\nData de cadastro: " + DataCadastro;
        }
    }
}
