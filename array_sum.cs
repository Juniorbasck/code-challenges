public static int simpleArraySum(List<int> ar)
{
    if (ar == null) return 0;      

    int sum = 0;

    for (int i = 0; i < ar.Count; i++)
        sum = sum + ar[i];

    return sum;
}
