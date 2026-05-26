# 207. Course Schedule

## 📝 Descrição do Problema

Existem um total de `numCourses` cursos que você precisa fazer, rotulados de `0` a `numCourses - 1`.

Você recebe um array `prerequisites` onde cada elemento `prerequisites[i] = [a, b]` indica que você **obrigatoriamente** deve fazer o curso `b` antes de poder fazer o curso `a`.

Por exemplo, o par `[0, 1]` significa que para fazer o curso `0`, você precisa ter concluído o curso `1` primeiro.

A tarefa é retornar `true` se for possível concluir todos os cursos. Caso contrário, retorne `false`.

---

## 💡 Exemplo 1

**Entrada:** `numCourses = 2`, `prerequisites = [[1, 0]]`
**Saída:** `true`
**Explicação:** Existe um total de 2 cursos. Para fazer o curso 1, você precisa ter terminado o curso 0. Isso é perfeitamente possível.

---

## 💡 Exemplo 2

**Entrada:** `numCourses = 2`, `prerequisites = [[1, 0], [0, 1]]`
**Saída:** `false`
**Explicação:** Para fazer o curso 1, você precisa do curso 0, e para fazer o curso 0, você precisa do curso 1. Isso forma uma dependência circular, tornando impossível concluir os cursos.

---

## ⚙️ Objetivo da Função

Implementar uma função que determine se é possível finalizar todos os cursos dadas as dependências.

**Parâmetros:**
* `numCourses`: um inteiro representando o número total de cursos.
* `prerequisites`: um array de arrays, onde cada subarray representa uma dependência `[curso, pre-requisito]`.

**Retorno:**
* `boolean`: `true` se for possível completar todos os cursos, `false` caso contrário.

---

## ⚠️ Restrições

* `1 <= numCourses <= 2000`
* `0 <= prerequisites.length <= 5000`
* `prerequisites[i].length == 2`
* `0 <= a_i, b_i < numCourses`
* Todos os pares em `prerequisites` são distintos.

---

## 🔗 Link do Exercício

Para mais detalhes e para submeter sua solução, acesse o desafio no LeetCode:
[Course Schedule](https://leetcode.com/problems/course-schedule/)