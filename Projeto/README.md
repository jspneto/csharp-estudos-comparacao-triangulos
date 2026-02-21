# Comparação das Áreas de Dois Triângulos

Projeto de estudo em C# com o objetivo de **calcular e comparar a área de dois triângulos** a partir das medidas de seus lados, utilizando a **fórmula de Heron**.

## Detalhes Gerais

- **Versão**: 0.7.1
- **Conceito aplicado:** Validação de Entradas

## Descrição da Tag

Refatoracao da regra de validacao do atributo Nome.

O construtor passa a aplicar fallback automatico para nome generico apenas durante a criacao do objeto, enquanto o setter ignora valores invalidos, preservando o estado atual.

A validacao foi isolada no metodo NomeValido, eliminando efeitos colaterais indesejados.

## Exemplo de Execução

<img src="Img/Screenshot-v0.7.png" alt="Validação de Entradas" width="936">