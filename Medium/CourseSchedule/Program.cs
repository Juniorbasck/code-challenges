public class Solution
{
    
    public static void Main()
    {
        var numCourses1 = 2;
        var prerequisites1 = new int[][]
        {
          new []{1,0},  
        };
        var result = CanFinish(numCourses1, prerequisites1);
        Console.WriteLine("Expetec True but actual: " + result);

        var numCourses2 = 2;
        var prerequisites2 = new int[][]
        {
            [1,0],
            [0, 1],
        };
        var result2 = CanFinish(numCourses2, prerequisites2);
        Console.WriteLine("Expected false but actual: " + result2);
    }
    
    public static bool CanFinish(int numCourses, int[][] prerequisites)
    {
        var adjacency = new Dictionary<int, List<int>>();

        for (int i = 0; i < numCourses; i++)
        {
            adjacency[i] = new List<int>();
        }

        foreach (var pre in prerequisites)
        {
            var course = pre[0];
            var prerequisite = pre[1];
            adjacency[prerequisite].Add(course);
        }

        var visited = new int[numCourses];

        for (int i = 0; i < numCourses; i++)
        {
            if (visited[i] == 0)
            {
                var hasCicle = HasCicle(i, adjacency, visited);

                if (hasCicle)
                    return false;
            }
        }

     
        return true;
    }

    public static bool HasCicle(int currentCourse, Dictionary<int, List<int>> adjacency, int[] visitStatus)
    {
        if (visitStatus[currentCourse] == 1)
            return true;
        
        if (visitStatus[currentCourse] == 2)
            return false;
        
        visitStatus[currentCourse] = 1;

        foreach (var neighbor in adjacency[currentCourse])
        {
            bool hasCicle = HasCicle(neighbor, adjacency, visitStatus);

            if (hasCicle)
                return true;
        }
        
        visitStatus[currentCourse] = 2;
        
        return false;
    }
}