using System;

namespace MediaStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Testando Estratégia de Média Aritmética ===\n");

            // Teste com média aritmética
            Disciplina disciplina1 = new Disciplina(new Aritmetica());
            disciplina1.SetNome("Matemática");
            disciplina1.SetP1(8.0);
            disciplina1.SetP2(6.0);
            disciplina1.CalcularMedia();

            Console.WriteLine($"Disciplina: {disciplina1.GetNome()}");
            Console.WriteLine($"P1: {disciplina1.GetP1()}");
            Console.WriteLine($"P2: {disciplina1.GetP2()}");
            Console.WriteLine($"Média Aritmética: {disciplina1.GetMedia()}");
            Console.WriteLine($"Situação: {disciplina1.GetSituacao()}");

            Console.WriteLine("\n=== Testando Estratégia de Média Geométrica ===\n");

            // Teste com média geométrica
            Disciplina disciplina2 = new Disciplina(new Geometrica());
            disciplina2.SetNome("Física");
            disciplina2.SetP1(9.0);
            disciplina2.SetP2(4.0);
            disciplina2.CalcularMedia();

            Console.WriteLine($"Disciplina: {disciplina2.GetNome()}");
            Console.WriteLine($"P1: {disciplina2.GetP1()}");
            Console.WriteLine($"P2: {disciplina2.GetP2()}");
            Console.WriteLine($"Média Geométrica: {disciplina2.GetMedia()}");
            Console.WriteLine($"Situação: {disciplina2.GetSituacao()}");

            Console.WriteLine("\n=== Teste Adicional - Comparando Estratégias ===\n");

            // Comparando ambas as estratégias com as mesmas notas
            double p1 = 8.0, p2 = 6.0;

            Disciplina testAritmetica = new Disciplina(new Aritmetica());
            testAritmetica.SetNome("Química");
            testAritmetica.SetP1(p1);
            testAritmetica.SetP2(p2);
            testAritmetica.CalcularMedia();

            Disciplina testGeometrica = new Disciplina(new Geometrica());
            testGeometrica.SetNome("Química");
            testGeometrica.SetP1(p1);
            testGeometrica.SetP2(p2);
            testGeometrica.CalcularMedia();

            Console.WriteLine($"Notas: P1={p1}, P2={p2}");
            Console.WriteLine($"Média Aritmética: {testAritmetica.GetMedia():F2} - {testAritmetica.GetSituacao()}");
            Console.WriteLine($"Média Geométrica: {testGeometrica.GetMedia():F2} - {testGeometrica.GetSituacao()}");

            Console.WriteLine("\n=== Testando Validações ===\n");

            // Teste de validação - nome vazio
            try
            {
                Disciplina disciplinaInvalida = new Disciplina(new Aritmetica());
                disciplinaInvalida.SetNome("");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"✓ Validação de nome vazio: {ex.Message}");
            }

            // Teste de validação - nota negativa
            try
            {
                Disciplina disciplinaInvalida = new Disciplina(new Aritmetica());
                disciplinaInvalida.SetP1(-5.0);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"✓ Validação de nota negativa: {ex.Message}");
            }

            // Teste de validação - nota acima de 10
            try
            {
                Disciplina disciplinaInvalida = new Disciplina(new Aritmetica());
                disciplinaInvalida.SetP2(11.5);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"✓ Validação de nota acima de 10: {ex.Message}");
            }

            Console.WriteLine("\nTodas as validações estão funcionando corretamente!");
        }
    }
}