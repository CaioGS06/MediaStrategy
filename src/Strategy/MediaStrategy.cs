namespace MediaStrategy
{
  interface IMediaStrategy
  {
    public double CalcularMedia(double p1, double p2);
    public string VerificarSituacao(double media);
  }
}