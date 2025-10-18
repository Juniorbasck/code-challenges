public class Solution
{

    public bool CanFinish(int numCourses, int[][] prerequisites)
    {

        var adjList = new Dictionary<int, List<int>>();

        for (int i = 0; i < numCourses; i++)
        {
            adjList[i] = new List<int>();
        }

        foreach (var pre in prerequisites)
        {
            var course = pre[0];
            var prerequisite = pre[1];
            adjList[prerequisite].Add(course);
        }

        var visitedStatus = new int[numCourses];

        for (int i = 0; i < numCourses; i++)
        {
            if (visitedStatus[i] == 0)
            {

                if (HasCicle(i, adjList, visitedStatus))
                {
                    return false;
                }

            }
        }

        return true;
    }

    public bool HasCicle(int currentCourse, Dictionary<int, List<int>> adjList, int[] visitStatus)
    {

        visitStatus[currentCourse] = 1;

        foreach (int neighbor in adjList[currentCourse])
        {

            if (visitStatus[neighbor] == 1)
            {
                return true;
            }

            if (visitStatus[neighbor] == 0)
            {
                if (HasCicle(neighbor, adjList, visitStatus))
                {
                    return true;
                }
            }
        }

        visitStatus[currentCourse] = 2;

        return false;
    }
}