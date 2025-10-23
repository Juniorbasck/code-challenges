# Number of Provinces

## Descrição
Existem n cidades. Algumas estão conectadas diretamente; outras não. Se a cidade A está conectada diretamente à cidade B, e B está conectada diretamente à cidade C, então A está conectada indiretamente à C.

Uma província é um grupo de cidades conectadas direta ou indiretamente, sem incluir cidades fora do grupo.

Você recebe uma matriz n x n `isConnected` onde `isConnected[i][j] = 1` indica que a cidade i e a cidade j estão conectadas diretamente, e `0` caso contrário. Retorne o número total de províncias.

## Entrada / Saída
- Entrada: `isConnected` — matriz binária n x n
- Saída: inteiro — número de províncias

## Exemplo
Input:
```
isConnected = [[1,1,0],
               [1,1,0],
               [0,0,1]]
```
Output:
```
2
```

Link: https://leetcode.com/problems/number-of-provinces/