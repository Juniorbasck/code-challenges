class Result
{

    public static int diagonalDifference(List<List<int>> arr)
    {
        int principalDiagonals = 0;
        int secondDiagonals = 0;

        int numberOfElements = arr.Count;

        for (int i = 0; i < numberOfElements; i++)
        {

            principalDiagonals += arr[i][i];

            secondDiagonals += arr[i][numberOfElements - 1 - i];
        }

        return Math.Abs(principalDiagonals - secondDiagonals);
    }

}