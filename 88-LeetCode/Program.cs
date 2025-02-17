// See https://aka.ms/new-console-template for more information

void Merge(int[] nums1, int m, int[] nums2, int n)
{
    int last = nums1.Length - 1;
    int p1 = m - 1;
    int p2 = n - 1;
    
    if (n == 0) return;

    while (p1 >= 0 && p2 >= 0)
    {
        if (nums1[p1] > nums2[p2])
        {
            nums1[last] = nums1[p1];
            p1--;
        }
        else
        {
            nums1[last] = nums2[p2];
            p2--;
        }
        last--;
    }

    while (p2 >= 0)
    {
        nums1[last] = nums2[p2];
        p2--;
        last--;
    }

}
//int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
//int[] nums2 = new int[] { 2, 5, 6 };
int[] nums1 = new int[] { 1 };
int[] nums2 = new int[] { };
//int[] nums1 = new int[] { 0 };
//int[] nums2 = new int[] { 1 };

Merge(nums1, 1, nums2, 0);
Console.WriteLine(String.Join(" ", nums1));
