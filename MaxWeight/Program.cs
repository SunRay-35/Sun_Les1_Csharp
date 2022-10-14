// See https://aka.ms/new-console-template for more information
int[] arrWeights = new int[5] {1, 2, 6, 8, 4};
int intMax = arrWeights[0];
for(int i = 1; i < arrWeights.Length; i++)
{
    if (arrWeights[i] > intMax) intMax = arrWeights[i];
}
Console.WriteLine(intMax);