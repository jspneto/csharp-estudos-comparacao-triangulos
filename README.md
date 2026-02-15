# Comparação das Áreas de Dois Triângulos

Projeto de estudo em C# com o objetivo de **calcular e comparar a área de dois triângulos** a partir das medidas de seus lados, utilizando a **fórmula de Heron**.

Este projeto foi desenvolvido de forma incremental, registrando a evolução do código em uma abordagem **orientada a objetos**.

## Conceitos Trabalhados

- Implementação procedural (quando viável)
- Classes, métodos e sobrescrita (Override)
- Métodos e classes estáticas (quando aplicável)
- Construtores e sobrecarcaga (Overload)
- Encapsulamento, Properties e Auto-Properties (quando aplicável)

## Enunciado do Projeto

Ler as medidas dos lados de dois triângulos (X e Y), considerando medidas válidas.

Em seguida:
- Calcular a área de cada triângulo
- Exibir os valores das áreas
- Informar qual triângulo possui a maior área

A área de um triângulo com lados `a`, `b` e `c` é calculada pela **fórmula de Heron**:

```bash
p = (a + b + c) / 2
area = RaizQ(p * (p - a) * (p - b) * (p - c))
```

## Estrutura do Projeto

```bash
|- Projeto/
   |- Img/
   |- Src/
      |- Triangulo.cs
   |- Projeto.csproj
   |- Projeto.sln
   |- Program.cs
   |- README.md
```

*(A estrutura pode evoluir conforme o aprendizado avança.)*

## Evolução do Projeto (Tags)

- **Conceitual:**
  - [**v0.1**][1] — Solução procedural
  - [**v0.2**][2] — Introdução da classe Triangulo

- **Estrutural:**
  - [**v0.2.1**][3] — Refatoração de Program com métodos auxiliares

## Objetivo Educacional

Este projeto **não tem como foco a solução final perfeita**, mas sim o processo de aprendizado e a comparação entre abordagens diferentes para o mesmo problema.

[1]: https://github.com/jspneto/csharp-estudos-comparacao-triangulos/tree/v0.1/Projeto "v0.1"
[2]: https://github.com/jspneto/csharp-estudos-comparacao-triangulos/tree/v0.2/Projeto "v0.2"
[3]: https://github.com/jspneto/csharp-estudos-comparacao-triangulos/tree/v0.2.1/Projeto "v0.2.1"
