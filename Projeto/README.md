# Comparação das Áreas de Dois Triângulos

Projeto de estudo em C# com o objetivo de **calcular e comparar a área de dois triângulos** a partir das medidas de seus lados, utilizando a **fórmula de Heron**.

## Detalhes Gerais

- **Versão**: 0.2.2
- **Conceito aplicado:** Refatoração de código

## Descrição da Tag

Refatoracao estrutural para melhorar a organizacao do codigo.

Metodos de entrada e saida foram movidos para classes dedicadas (TrianguloInputs e TrianguloOutputs) dentro de Src/IO, e a comparacao de areas foi centralizada em TrianguloHelpers, deixando o programa principal mais enxuto e didatico.

O Program passa a conter apenas o metodo Main, delegando a execucao dos exemplos para a classe ProgramExamples, facilitando a expansao do projeto com novos cenarios e mantendo o entrypoint simples.

## Exemplo de Execução

<img src="Img/Screenshot-v0.2.1.png" alt="Versão Padrão" width="936">