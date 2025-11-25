class Terminal //  Grupo de funções da classe TERMINAL
{

    public  double ReadDouble(string msg)
    {
        Console.WriteLine(msg);
        double valor = Convert.ToDouble(Console.ReadLine());
        return valor;

    }
    public  void Apresentar()
    {
        Console.WriteLine("== PROGRAMA MÉDIA ==\n");
    }  
        
        public  void ExibirRespostas(double media, string situacao)
    {
        Console.WriteLine($"Média: {media}");
        Console.WriteLine($"Situação: {situacao}");
    }
        
}        