namespace MediaStrategy
{
  using System;

  class Disciplina
  {
    private string _nome;
    private double _p1;
    private double _p2;
    private double _media;
    private string _situacao;
    private IMediaStrategy _estrategia;

    public Disciplina(IMediaStrategy estrategia)
    {
      _estrategia = estrategia;
    }

    public void SetNome(string nome)
    {
      if (string.IsNullOrWhiteSpace(nome))
      {
        throw new ArgumentException("O nome da disciplina não pode ser vazio ou nulo.");
      }
      _nome = nome;
    }

    public void SetP1(double p1)
    {
      if (p1 < 0 || p1 > 10)
      {
        throw new ArgumentException("A nota P1 deve estar entre 0 e 10.");
      }
      _p1 = p1;
    }

    public void SetP2(double p2)
    {
      if (p2 < 0 || p2 > 10)
      {
        throw new ArgumentException("A nota P2 deve estar entre 0 e 10.");
      }
      _p2 = p2;
    }

    public void CalcularMedia()
    {
      _media = _estrategia.CalcularMedia(_p1, _p2);
      _situacao = _estrategia.VerificarSituacao(_media);
    }

    public string GetNome()
    {
      return _nome;
    }

    public double GetP1()
    {
      return _p1;
    }

    public double GetP2()
    {
      return _p2;
    }

    public double GetMedia()
    {
      return _media;
    }

    public string GetSituacao()
    {
      return _situacao;
    }
  }
}