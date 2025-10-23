public class Solution
{
    public int FindCircleNum(int[][] isConnected)
    {

        int provinces = 0;
        int cities = isConnected.Length;

        bool[] visiteds = new bool[cities];

        for (int i = 0; i < cities; i++)
        {

            if (visiteds[i] == false)
            {
                provinces++;

                DFS(i, isConnected, visiteds);
            }

        }

        return provinces;
    }

    public void DFS(int cidadeAtual, int[][] isConnected, bool[] visiteds)
    {

        visiteds[cidadeAtual] = true;

        for (int neighbor = 0; neighbor < isConnected.Length; neighbor++)
        {

            if (isConnected[cidadeAtual][neighbor] == 1 && visiteds[neighbor] == false)
            {
                DFS(neighbor, isConnected, visiteds);
            }
        }
    }
}