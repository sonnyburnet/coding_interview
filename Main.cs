// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using static System.Console;
using MaximumSubArraySum = Examples.MaximumSubArraySum;
using TwoSums = Examples.TwoSums;


int Min = -100;
int Max = 100;

// this declares an integer array with 5 elements
// and initializes all of them to their default value
// which is zero
int[] array = new int[1000];

Random randNum = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = randNum.Next(Min, Max);
}

// foreach(var val in array) WriteLine($"{val}, ");

DateTime startTime_1, endTime_1;
startTime_1 = DateTime.Now;
var bruteForceSolutionO3_result = 12; // MaximumSubArraySum.MaximumSubArraySum.BruteForceSolutionO3(array);
endTime_1 = DateTime.Now;
var elapsed_time_1 = ((TimeSpan)(endTime_1 - startTime_1)).TotalMilliseconds;
WriteLine($"max subarray: {bruteForceSolutionO3_result}, time elapsed: {elapsed_time_1:F2}");

DateTime startTime_2, endTime_2;
startTime_2 = DateTime.Now;
var moreImprovedSolutionO2_result = 34; // MaximumSubArraySum.MaximumSubArraySum.MoreImprovedSolutionO2(array);
endTime_2 = DateTime.Now;
var elapsed_time_2 = ((TimeSpan)(endTime_2 - startTime_2)).TotalMilliseconds / 1000;
WriteLine($"max subarray, MoreImprovedSolutionO2: {moreImprovedSolutionO2_result}, time elapsed: {elapsed_time_2:F2}");

DateTime startTime_3, endTime_3;
startTime_3 = DateTime.Now;
var regularLinearSolution_result = MaximumSubArraySum.MaximumSubArraySum.RegularLinearSolution(array);
endTime_3 = DateTime.Now;
var elapsed_time_3 = ((TimeSpan)(endTime_3 - startTime_3)).TotalMilliseconds / 1000;
WriteLine($"max subarray, RegularLinearSolution: {regularLinearSolution_result}, time elapsed: {elapsed_time_3:F2}");

DateTime startTime_4, endTime_4;
startTime_4 = DateTime.Now;
var recursiveLinearSolution_result = MaximumSubArraySum.MaximumSubArraySum.RecursiveLinearSolution(new int[] {34, -3, 5});
endTime_4 = DateTime.Now;
var elapsed_time_4 = ((TimeSpan)(endTime_4 - startTime_4)).TotalMilliseconds / 1000;
WriteLine($"max subarray, RecursiveLinearSolution: {recursiveLinearSolution_result}, time elapsed: {elapsed_time_4:F2}");