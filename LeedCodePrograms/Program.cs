namespace LeedCodePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 2, 7, 11, 15 };
            int target1 = 9;

            var resultIndexes2 = TwoSumCode.TwoSumOptimizedApproach(nums1, target1);

            Console.WriteLine("Indexes are: " + resultIndexes2[0] + " and " + resultIndexes2[1]);


        }
    }
}
