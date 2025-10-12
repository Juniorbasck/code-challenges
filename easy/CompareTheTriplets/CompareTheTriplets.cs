public static List<int> compareTriplets(List<int> a, List<int> b)
{
    int alice = 0;
    int bob = 0;

    for (int i = 0; i < a.Count; i++)
    {

        if (a[i] > b[i])
        {
            alice = alice + 1;
        }

        if (a[i] < b[i])
        {
            bob = bob + 1;
        }
    }

    return [alice, bob];
}
