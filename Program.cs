using System.Security.Cryptography.X509Certificates;

namespace aula2;

class Program
{
    static void Main(string[] args)
    {
        Terminal term = new Terminal();
        Boletim bo = new Boletim();
        Notas notas = new Notas();

        term.Apresentar();
        notas.nota1 = term.ReadDouble("Informe a primeira nota:");
        notas.nota2 = term.ReadDouble("Informe a segunda nota:");
        notas.nota3 = term.ReadDouble("Informe a terceira nota:");
        double media = bo.CalcularMedia(notas);
        string situacao = bo.VerificarSituacao(media);
        term.ExibirRespostas(media, situacao);
    }


}
       

        // string situacao = (media <= 6) // Essa forma substitui o if else de forma INDENTADA
                            // ? "Reprovado!"
                            // : "Aprovado!";
       
