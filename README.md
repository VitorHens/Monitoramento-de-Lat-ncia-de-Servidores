
[Fluxo completp.drawio (1).pdf](https://github.com/user-attachments/files/32147842/Fluxo.completp.drawio.1.pdf)
# Monitoramento de Latência de Servidores

Projeto desenvolvido para a disciplina de **Programação Visual Básica – 2º Bimestre**.

A aplicação simula o monitoramento da latência de um servidor Edge de uma empresa de streaming. O usuário informa tempos de resposta, em milissegundos, com um valor por linha, e o sistema realiza uma análise estatística dos dados.

## Funcionalidades

- Entrada de vários valores de latência em uma única caixa de texto;
- Cálculo da quantidade de requisições analisadas;
- Identificação do menor e do maior tempo de resposta;
- Cálculo da média aritmética;
- Cálculo da variância amostral;
- Cálculo do desvio padrão amostral;
- Exibição dos resultados com duas casas decimais.

## Tecnologias utilizadas

- C#
- WPF
- XAML
- .NET

## Como utilizar

1. Abra o projeto no Visual Studio.
2. Execute a aplicação.
3. Digite ou cole os valores de latência na caixa de texto, colocando um valor por linha.
4. Clique no botão **Calcular Estatísticas**.
5. Os resultados serão mostrados na tela.

## Exemplo de entrada

```text
10
20
30
40
50
