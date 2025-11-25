class Boletim // Grupo de funções da classe BOLETIM
{
     public  string VerificarSituacao(double media)
        {
            string situacao = string.Empty;
            if (media >= 6)
            {
                situacao = "Passou!";
            }
            else
            {
                situacao = "Reprovou!";
            }
            return situacao;
        }


        public  double CalcularMedia(Notas notas)
        {
            double media = (notas.nota1 + notas.nota2 + notas.nota3) / 3;
            return media;
        }  
}
