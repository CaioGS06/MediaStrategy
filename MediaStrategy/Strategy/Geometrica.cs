using System;

namespace MediaStrategy
{
  class Geometrica : IMediaStrategy
  {
    public double CalcularMedia(double p1, double p2)
    {
      return Math.Sqrt(p1 * p2);
    }

    public string VerificarSituacao(double media)
    {
      return media >= 7.0 ? "Aprovado" : "Reprovado";
    }
  }
}