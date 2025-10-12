# Compare the Triplets

## 📝 Descrição do Problema

Alice e Bob criaram um problema cada um para o HackerRank. Um revisor avalia os dois desafios, atribuindo pontos em uma escala de **1** a **100** para três categorias: **clareza do problema**, **originalidade** e **dificuldade**.

A avaliação para o desafio de Alice é a tripla `a = (a[0], a[1], a[2])`, e a avaliação para o desafio de Bob é a tripla `b = (b[0], b[1], b[2])`.

A tarefa é calcular os "pontos de comparação" comparando as notas de cada categoria.

---

## ⚖️ Regras de Comparação

Para cada categoria `i` (de 0 a 2):
* Se `a[i] > b[i]`, **Alice** recebe **1** ponto.
* Se `a[i] < b[i]`, **Bob** recebe **1** ponto.
* Se `a[i] = b[i]`, ninguém recebe ponto.

Os pontos de comparação são o total de pontos que cada pessoa acumulou.

---

## 💡 Exemplo

Se `a = [1, 2, 3]` e `b = [3, 2, 1]`:

* Para `a[0]` vs `b[0]` (1 vs 3): `a[0] < b[0]`, então Bob recebe 1 ponto.
* Para `a[1]` vs `b[1]` (2 vs 2): `a[1] = b[1]`, então ninguém pontua.
* Para `a[2]` vs `b[2]` (3 vs 1): `a[2] > b[2]`, então Alice recebe 1 ponto.

O resultado final é `[1, 1]`, onde o placar de Alice vem primeiro e o de Bob em segundo.

---

## ⚙️ Descrição da Função

Complete a função `compareTriplets`.

**Parâmetros:**
* `int a[3]`: a avaliação do desafio de Alice.
* `int b[3]`: a avaliação do desafio de Bob.

**Retorno:**
* `int[2]`: um array contendo o placar de Alice na primeira posição e o de Bob na segunda.

---

## 📥 Formato de Entrada

A primeira linha contém 3 inteiros separados por espaço, representando `a[0]`, `a[1]`, e `a[2]`.
A segunda linha contém 3 inteiros separados por espaço, representando `b[0]`, `b[1]`, e `b[2]`.

---

## ⚠️ Restrições

* `1 ≤ a[i] ≤ 100`
* `1 ≤ b[i] ≤ 100`

---

## 🔗 Link do Exercício

Para mais detalhes, acesse o desafio no HackerRank:
[Compare the Triplets](https://www.hackerrank.com/challenges/compare-the-triplets/problem?isFullScreen=true)