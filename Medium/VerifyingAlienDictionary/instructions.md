# Verificando Dicionário Alienígena

Em uma língua alienígena, eles também usam letras minúsculas inglesas, porém possivelmente em uma ordem diferente. A ordem do alfabeto é uma permutação das letras minúsculas.

Dada uma sequência de palavras escritas nessa língua e a string que descreve a ordem do alfabeto, retorne `true` se e somente se as palavras estiverem ordenadas lexicograficamente segundo essa ordem.

## Entrada
- `words`: array de strings (palavras)
- `order`: string com 26 letras minúsculas representando a ordem do alfabeto na língua alienígena

## Saída
- `true` ou `false`

## Exemplos

**Exemplo 1**  
Entrada: `words = ["hello","leetcode"]`, `order = "hlabcdefgijkmnopqrstuvwxyz"`  
Saída: `true`  
Explicação: Na ordem dada, `h` vem antes de `l`, logo a sequência está ordenada.

**Exemplo 2**  
Entrada: `words = ["word","world","row"]`, `order = "worldabcefghijkmnpqstuvxyz"`  
Saída: `false`  
Explicação: Nessa ordem, `d` vem depois de `l`, então `word` > `world` e a sequência não está ordenada.

## Link
https://leetcode.com/problems/verifying-an-alien-dictionary/description/