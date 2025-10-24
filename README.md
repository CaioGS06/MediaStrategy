# MediaStrategy

Este é um projeto em C# que demonstra a implementação do padrão de projeto Strategy para cálculo de médias de notas de disciplinas acadêmicas.

## Sobre o Projeto

O projeto implementa diferentes estratégias para calcular a média de duas notas (P1 e P2) e determinar a situação do aluno (Aprovado/Reprovado). Atualmente, o sistema suporta duas estratégias:

- **Média Aritmética**: Calcula a média simples (P1 + P2) / 2, com aprovação a partir de 5.0
- **Média Geométrica**: Calcula a raiz quadrada do produto (√P1 × P2), com aprovação a partir de 7.0

## Estrutura do Projeto

```
MediaStrategy
├── MediaStrategy
│   ├── Program.cs                  # Ponto de entrada da aplicação com testes
│   ├── Model
│   │   └── Disciplina.cs           # Classe que representa uma disciplina
│   ├── Strategy
│   │   ├── MediaStrategy.cs        # Interface IMediaStrategy
│   │   ├── Aritmetica.cs           # Implementação da média aritmética
│   │   └── Geometrica.cs           # Implementação da média geométrica
│   ├── Properties
│   │   └── launchSettings.json     # Configurações de inicialização
│   └── MediaStrategy.csproj        # Arquivo do projeto
├── MediaStrategy.sln               # Solução do projeto
├── .gitignore                      # Arquivos ignorados pelo Git
└── README.md                       # Documentação do projeto
```

## Como Executar

Para executar esta aplicação, certifique-se de ter o .NET SDK instalado. Em seguida, você pode compilar e executar a aplicação usando os seguintes comandos:

```bash
cd MediaStrategy
dotnet run
```

## Funcionalidades

- ✅ Cálculo de média aritmética e geométrica
- ✅ Verificação automática de situação (Aprovado/Reprovado)
- ✅ Validação de dados de entrada:
  - Nome da disciplina não pode ser vazio ou nulo
  - Notas devem estar entre 0 e 10
- ✅ Padrão Strategy para fácil extensão de novos tipos de média
- ✅ Testes demonstrativos incluídos no Program.cs

## Padrão de Projeto Utilizado

### Strategy Pattern

O padrão Strategy permite definir uma família de algoritmos (estratégias de cálculo de média), encapsulá-los e torná-los intercambiáveis. Isso permite que o algoritmo varie independentemente dos clientes que o utilizam.

**Benefícios:**
- Facilita a adição de novas estratégias de cálculo sem modificar o código existente
- Separa a lógica de negócio do algoritmo de cálculo
- Torna o código mais flexível e manutenível

## Exemplo de Uso

```csharp
// Criando disciplina com média aritmética
Disciplina matematica = new Disciplina(new Aritmetica());
matematica.SetNome("Matemática");
matematica.SetP1(8.0);
matematica.SetP2(6.0);
matematica.CalcularMedia();

Console.WriteLine($"Média: {matematica.GetMedia()}");
Console.WriteLine($"Situação: {matematica.GetSituacao()}");

// Criando disciplina com média geométrica
Disciplina fisica = new Disciplina(new Geometrica());
fisica.SetNome("Física");
fisica.SetP1(9.0);
fisica.SetP2(4.0);
fisica.CalcularMedia();

Console.WriteLine($"Média: {fisica.GetMedia()}");
Console.WriteLine($"Situação: {fisica.GetSituacao()}");
```

## Contribuindo

Sinta-se à vontade para fazer fork do repositório e enviar pull requests para melhorias ou novas funcionalidades que você gostaria de adicionar, como:
- Novas estratégias de cálculo (média ponderada, média harmônica, etc.)
- Interface de usuário interativa
- Persistência de dados
- Testes unitários