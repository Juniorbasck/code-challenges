# Two Sum

## 📝 Descrição do Problema

Dado um array de inteiros `nums` e um inteiro `target`, retorne os **índices** dos dois números que somam exatamente `target`.

---

## 📌 Regras e Suposições

* Você pode assumir que cada entrada terá **exatamente uma solução**.
* Você **não pode** usar o mesmo elemento duas vezes.
* A ordem dos índices no array de retorno não importa.

---

## 💡 Exemplo 1

**Entrada:** `nums = [2, 7, 11, 15]`, `target = 9`
**Saída:** `[0, 1]`
**Explicação:** Porque `nums[0] + nums[1] == 9`, nós retornamos `[0, 1]`.

---

## 💡 Exemplo 2

**Entrada:** `nums = [3, 2, 4]`, `target = 6`
**Saída:** `[1, 2]`
**Explicação:** Porque `nums[1] + nums[2] == 6`, nós retornamos `[1, 2]`.

---

## ⚙️ Objetivo da Função

O objetivo é implementar uma função que receba `nums` e `target` e retorne um array com os dois índices correspondentes.

**Parâmetros:**
* `nums`: um array de inteiros.
* `target`: o número alvo da soma.

**Retorno:**
* Um array de inteiros contendo os dois índices.

---

## ⚠️ Restrições

* `2 <= nums.length <= 10^4`
* `-10^9 <= nums[i] <= 10^9`
* `-10^9 <= target <= 10^9`

---

## 🔗 Link do Exercício

Para mais detalhes, acesse o desafio no LeetCode:
[Two Sum](https://leetcode.com/problems/two-sum/description/)