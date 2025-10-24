namespace MediaStrategy
{
  class Aritmetica : IMediaStrategy
  {
    public double CalcularMedia(double p1, double p2)
    {
      return (p1 + p2) / 2.0;
    }

    public string VerificarSituacao(double media)
    {
      return media >= 5.0 ? "Aprovado" : "Reprovado";
    }
  }
}