namespace ClasseInterface
{
    public class PF : Cliente, IAcao
    {
        public string Nome { get; set; }
        public string CPF { get; set; }

        string IAcao.Cadastro => throw new System.NotImplementedException();

        public PF(){}
        
        public PF(int id, string nome, string cpf, string email, string telefone, Endereco endereco)
        {
            this.Id = id;
            this.Nome = nome;
            this.CPF = cpf;
            this.Email = email;
            this.Telefone = telefone;
            this.End = endereco;
        }
        public string Cadastro()
        {
            string composicao = "Id do Cliente: " + Id +
                                "\nNome do cliente: " + Nome +
                                "\nEndereco: " + End.Logradouro + " ," + End.Numero + " -" + End.Bairro +
                                "\nCPF: " + CPF + 
                                "\nTelefone: " + Telefone + 
                                "\nEmail: " + Email;
            return composicao;
        }

        public string Consulta()
        {
            throw new System.NotImplementedException();
        }
    }
}