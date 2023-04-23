﻿namespace Hotel_EF.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public DateTime DataCadastro { get; set; }

        public override string ToString()
        {
            return "Id: " + Id + "\nNome: " + Nome + "\nTelefone: " + Telefone +
                "\nEndereço: " + Endereco + "\nData de cadastro: " + DataCadastro;
        }
    }
}
