namespace ClasseInterface
{
    public class Produto : IAcao
    {
       public int Id { get; set; } 
       public string Nome { get; set; }
       public string Descricao { get; set; }
       public double Preco { get; set; }

       public Produto()
       {
           
       }
       public Produto(int Id, string Nome, string Descricao, double Preco)
       {
           this.Id = Id;
           this.Nome = Nome;
           this.Descricao = Descricao;
           this.Preco = Preco;

       }

        public string Cadastro
        {
            get
            {
                string composicao = "Id do produto: " + Id +
                                    "\nNome do produto: " + Nome.ToUpper() +
                                    "\nDescrição do produto: " + Descricao +
                                    "\nPreço do produto: " + string.Format("{0:C2}", Preco);

                return "Produto cadastrado com sucesso\n" + composicao;
            }
        }

        public string Consulta()
        {
            throw new System.NotImplementedException();
        }
    }
}