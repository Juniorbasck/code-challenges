public class Program
{
    public static void Main(string[] args)
    {

        char[][] inputCaseOne = new char[][]
        {   
            new [] {'1', '1', '1', '1', '0'},
            new [] {'1', '1', '0', '1', '0'},
            new [] {'1', '1', '0', '0', '0'},
            new [] {'0', '0', '0', '1', '1'}
        };
        var resultCaseOne = NumIslands(inputCaseOne);
        Console.WriteLine("The number of islands espected is 2, actueal = " + resultCaseOne);
        
        
        char[][] inputCaseTwo = new char[][]
        {   
            new [] {'1', '1', '1', '1', '0'},
            new [] {'1', '1', '0', '1', '0'},
            new [] {'1', '1', '0', '0', '0'},
            new [] {'0', '0', '0', '0', '0'}
        };
        var resultCaseTwo = NumIslands(inputCaseTwo);
        Console.WriteLine("The number of islands espected is 1, actueal = " + resultCaseTwo);
        
    }
    public static int NumIslands(char[][] grid)
    {
        var islands = 0;
        var rows = grid.Length;
        var cols = grid[0].Length;

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                if (grid[r][c] == '1')
                {
                    islands++;
                    MarkAsVisited(grid, r, c, rows, cols);
                }
            }
        }

        return islands;
    }

    public static void MarkAsVisited(char[][] grid, int currentRow, int currentCol, int rows, int cols)
    {
        var cellsToExplore = new Queue<Tuple<int, int>>();

        cellsToExplore.Enqueue(new Tuple<int, int>(currentRow, currentCol));
        
        grid[currentRow][currentCol] = '0';
        
        while (cellsToExplore.Count > 0)
        {
            var island = cellsToExplore.Dequeue();
            
            currentRow = island.Item1;
            currentCol = island.Item2;
            
            if (currentRow - 1 >= 0)
            {
                var up = grid[currentRow - 1][currentCol];
                
                if (up == '1')
                {
                    grid[currentRow - 1][currentCol] = '0';
                    cellsToExplore.Enqueue(new Tuple<int, int>(currentRow - 1, currentCol));
                }
            }

            if (currentCol - 1 >= 0)
            {
                var left = grid[currentRow][currentCol - 1];
                
                if (left == '1')
                {
                    grid[currentRow][currentCol - 1] = '0';
                    cellsToExplore.Enqueue(new Tuple<int, int>(currentRow, currentCol - 1));
                }
            }

            if (currentRow + 1 < rows)
            {
                var down = grid[currentRow + 1][currentCol];

                if (down == '1')
                {
                    grid[currentRow + 1][currentCol] = '0';
                    cellsToExplore.Enqueue(new Tuple<int, int>(currentRow + 1, currentCol));
                }
            }
            
            if( currentCol + 1 < cols)
            {
                var right = grid[currentRow][currentCol + 1];
                
                if (right == '1')
                {
                    grid[currentRow][currentCol + 1] = '0';
                    cellsToExplore.Enqueue(new Tuple<int, int>(currentRow, currentCol + 1));
                }
            }   
        }

    }
}