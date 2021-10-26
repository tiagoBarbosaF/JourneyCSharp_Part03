# Entendendo herança e interface

## Objetivos ao completar os estudos

- Reuse código com Herança e Composição
- Entenda o que é Polimorfismo na prática
- Implemente Interface e métodos abstratos
- Aprenda sobrescrita de métodos
- Use os modificadores virtual, abstract e override
- Conheça o modificador de visibilidade protected

## Ementas:

### Analisando requisitos
- Atalhos no VisualStudio e classe Funcionario
- Relembrando Namespaces
- Classe Diretor e Sobrecargas
- Métodos com o mesmo nome?
- Para saber mais: Sobrecargas
- Para saber mais: Mais usos de sobrecargas
- Mão na massa
- O que aprendi?
  - Podemos criar diretórios na raiz de nosso projeto para organizar melhor o código!
  - O recurso de possíveis soluções do Visual Studio, acessível pelo atalho `CTRL+PONTO`;
  - Podemos ter vários métodos com o mesmo nome, desde que possuam lista de argumentos diferentes! Estas são as **sobrecargas**.

### Herança
- Projeto da aula anterior
- Nossa primeira herança
- Sintaxe de herança
- Sobrepondo comportamentos com override e virtual
- Propriedades podem ser virtuais?
- A palavra reservada base
- Herança no C#
- Repetição de membros
- Métodos virtuais?
- Mão na massa
- O que aprendi?
  - **Herança**: Aprendemos herança e vimos que, com sua sintaxe bastante simples, ela é importantíssima em qualquer projeto.
  - **Polimorfismo**: Com isso, foi possível tratar objetos do tipo `Diretor` como `Funcionario` e evitar repetição de código e várias sobrecargas iguais.
  - **Modificadores** `virtual` e `override`: Alguns comportamentos possuem implementações diferentes nas classes derivadas, para resolver este problema basta usarmos métodos virtuais e a sobrescrita.
  - `base`: A classe filha pode fazer referência aos membros da classe base com uso desta palavra reservada.

### Construtores e modificador de visibilidade `protected`
- Projeto da aula anterior
- Construtor na classe base
- Ordem de chamada dos construtores?
- Modificador de visibilidade protected
- Visibilidade
- Criando classes abstratas
- Criando métodos abstratos
- Chamando o construtor da classe base
- Para saber mais: sobrecarga em construtores
- Mão na massa
- O que aprendi?
  - O modificador de acesso `protected`;
  - Preenchendo construtores da classe base a partir da classe derivada, com a sintaxe `public Diretor(string cpf) : base(5000, cpf)`;
  - Classes e métodos abstratos!

### Mais sobre herança e herança múltipla
- Projeto da aula anterior
- O sistema interno do ByteBank
- Sobre Classes Abstratas
- Sobre métodos abstratos
- Classe autenticável
- Mão na massa
- O que aprendi?
  - Trabalhamos mais a fundo com herança;
  - Trabalhamos mais a fundo com abstrações.

### Interfaces
- Problema da herança múltipla
- Herdando de várias classes
- Usando interfaces
- Conceitos de Interfaces
- Classes abstratas e interfaces
- Mão na massa
- Projeto final do curso