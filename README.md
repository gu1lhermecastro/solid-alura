# SOLID-Alura
SOLID com C#: Princípios da programação orientada a objetos

* Entender porque você precisa ficar atento à **qualidade de seu código.**
* Conhecer os princípios **S.O.L.I.D.** para ajudar a aumentar sua qualidade (e descobrir porque coloquei ponto entre cada letra).
* Estudar como a **separação de responsabilidades** aumenta a coesão de seus métodos e classes.
* Refletir sobre a **dependência entre suas classes** para diminuir o acoplamento ruim no código.
* Introduzir o hábito de manter a **estabilidade de suas classes** para garantir a flexibilidade de sua aplicação.
* Reforçar que **promessas feitas nas abstrações devem ser cumpridas.**
* Lembrar que **interfaces também podem perder coesão e ter alto acoplamento.**



**Código de Qualidade?**
É um código flexível, pronto para mudanças!

**Dívida técnica**: Quando o sistema vai evoluindo e se deteriorando. Quanto mais o projeto evolui, mais alta fica sua dívida.
**Como encontra-las?** através do Code Smells.
**Code Smells:**
1. Código repetitivo, CTRL + C e CTRL + V. As ocorrências do mesmo código se tornam recorrentes.

**Soluções de dívidas técnicas:**
1. Patterns:
2. Princípios básicos:
3. SOLID:

## Como obter o SRP — Single Responsibility Principle (Princípio da Responsabilidade Única)
1. DRY - Dont Repeat Yourself
2. Métodos devem ter uma única responsabilidade
3. Classes também devem ter uma única responsabilidade
4. Responsabilidade do Método ≠ Responsabilidade da Classe: Um classe pode ter vários métodos, desde que sejam referentes a sua regra.
5. Garantir o Single Source of Truth - Única fonte de informação

* Por que evitar código duplicado?
* O que devo fazer quando encontro código repetido em meu projeto?
* Qual a diferença entre responsabilidade de método e responsabilidade de classes?
* Qual o propósito do padrão DAO?
* Qual o princípio S.O.L.I.D. relacionado à coesão?
* Código repetido é uma forma específica de conhecimento repetido (DRY)
* Repetição de código é ruim porque impacta nos custos de manutenção e aumenta sua dívida técnica
* Repetição de código pode indicar que métodos e classes possuem muitas responsabilidades
* Métodos e classes devem ter 1 única responsabilidade! Só assim serão coesos
* A responsabilidade de um método é executar uma única função
* A responsabilidade de uma classe é responder a mudanças originadas por uma única pessoa, função ou área de negócio (agente de mudança)
* Essas idéias foram sintetizadas no Princípio da Responsabilidade Única (SRP) cunhado por Robert Martin

## Como obter o DIP — Dependency Inversion Principle (Inversão de Dependências)

1. **Evite acoplamento com implementações, faça referências apenas a  abstrações.**

2. Acoplamento bom: É a dependência de uma classe estável, que dificilmente irá mudar.
3. Acoplamento ruim: É a dependência de classes que sofrem modificações com maior frequência, podendo quebrar classes que dependem dela.

4. **Inversão de Dependência**: Melhora a **qualidade da dependência**! Crie abstrações e dependa delas para melhorar a qualidade do acoplamento. Esse hábito é formalizado através do Princípio da Inversão das Dependências (DIP), a letra D na sigla S.O.L.I.D.
5. **Injeção de Dependência**: Melhora a **criação da dependência**! Explicite as dependências de uma classe. Uma das maneiras de fazer isso é usando parâmetros do construtor. Desse jeito aplicamos um conceito chamado Injeção de Dependência (DI)
6. **Inversão de Controle**: Melhora a **direção da dependência**! Quando a classe dependente deixa de resolver as dependências diretamente e cede esse controle para outrém temos o uso do conceito Inversão de Controle (IoC).

7. Na OOP Sempre que há obrigatoriedade na instância do objeto, passamos pelo construtor.
8. Uma forma de aplicar a injeção de dependência, é através do Startup da aplicação.
9. Crie abstrações para melhorar a qualidade, explicite as dependências no construtor para desacoplar.

* Como analiso as dependências de uma classe?
* Qual a diferença entre acoplamento bom e ruim?
* O que são classes instáveis?
* Que estratégias utilizo para minimizar os acoplamentos ruins?
* De que maneira o AspNet Core ajuda a minimizar o acoplamento de nossos controladores e tipos em geral?

## Como obter o OCP — Open-Closed Principle (Princípio do Aberto/Fechado)

1. Código repetido é um risco para o negócio
2. Extrair casos de uso para cada método específico.
3. Separe as funcionalidade da aplicação em uma camada de serviço.

Mais referências:
- Manifesto Ágil - https://agilemanifesto.org/iso/ptbr/manifesto.html
- Princípio DRY - Andrew Hunt e Dave Thomas livro **Pragmatic Programmer**.

Mais sobre Code Smells:
- https://refactoring.guru/refactoring/smells
- https://blog.codinghorror.com/code-smells/
- Livro Refactoring de Martin Fowler
