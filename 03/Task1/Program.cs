double[] nums = new double[5];
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = Math.Round(Random.Shared.NextDouble()*10 - 5, 2);
}
Console.WriteLine(string.Join(" ; ", nums));
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] > 0 && nums[i] < 3.2) Console.WriteLine(i);
}