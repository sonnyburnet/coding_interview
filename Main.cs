// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using static System.Console;
using MaximumSubArraySum = Examples.MaximumSubArraySum;
using TwoSums = Algorithms.TwoSums;
using OOP = Study.OOP;
using SortingAndSearching = Examples.SortingAndSearching;
using Peek = Algorithms.PeekFinding;
using Stock = Algorithms.BestTimeToBuyAndSellStock;
using Palindrome = Algorithms.ValidPalindrome;
// using Tree = Algorithms.InvertBinaryTree;
using Tree = Algorithms.DiameterOfBinaryTree;
using DataStructures = Examples.DataStructures;
using DynamicProgramming = Algorithms.DynamicProgramming;

int Min = -10000;
int Max = 10000;

// this declares an integer array with 5 elements
// and initializes all of them to their default value
// which is zero
int[] array = new int[(int)Math.Pow(10, 5)];

Random randNum = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = randNum.Next(Min, Max);
}

// foreach(var val in array) WriteLine($"{val}, ");

// DateTime startTime_1, endTime_1;
// startTime_1 = DateTime.Now;
// var bruteForceSolutionO3_result = 12; // MaximumSubArraySum.MaximumSubArraySum.BruteForceSolutionO3(array);
// endTime_1 = DateTime.Now;
// var elapsed_time_1 = ((TimeSpan)(endTime_1 - startTime_1)).TotalMilliseconds;
// WriteLine($"max subarray: {bruteForceSolutionO3_result}, time elapsed: {elapsed_time_1:F2}");

// DateTime startTime_2, endTime_2;
// startTime_2 = DateTime.Now;
// var moreImprovedSolutionO2_result = MaximumSubArraySum.MaximumSubArraySum.MoreImprovedSolutionO2(array);
// endTime_2 = DateTime.Now;
// var elapsed_time_2 = ((TimeSpan)(endTime_2 - startTime_2)).TotalMilliseconds / 1000;
// WriteLine($"max subarray, MoreImprovedSolutionO2: {moreImprovedSolutionO2_result}, time elapsed: {elapsed_time_2:F2}");

// DateTime startTime_3, endTime_3;
// startTime_3 = DateTime.Now;
// var regularLinearSolution_result = MaximumSubArraySum.MaximumSubArraySum.RegularLinearSolution(array);
// endTime_3 = DateTime.Now;
// var elapsed_time_3 = ((TimeSpan)(endTime_3 - startTime_3)).TotalMilliseconds / 1000;
// WriteLine($"max subarray, RegularLinearSolution: {regularLinearSolution_result}, time elapsed: {elapsed_time_3:F2}");

// DateTime startTime_4, endTime_4;
// startTime_4 = DateTime.Now;
// var recursiveLinearSolution_result = MaximumSubArraySum.MaximumSubArraySum.RecursiveLinearSolution(array);
// endTime_4 = DateTime.Now;
// var elapsed_time_4 = ((TimeSpan)(endTime_4 - startTime_4)).TotalMilliseconds / 1000;
// WriteLine($"max subarray, RecursiveLinearSolution: {recursiveLinearSolution_result}, time elapsed: {elapsed_time_4:F2}");


// Ch3.Chapter3.ExceptionHandler();

// int[] unsorted_array = new int[] { 1, 3, 8, 2, 9, 2, 5, 5 };
// 1 step { 8, 9, 7, 6, 5, 4, 3, 2, 1 };
// 2 step pointer to 7 { 9, 7, , 6, 5, 4, 3, 2, 1 };
int[] unsorted_array = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
// var arr1 = new int[] {1, 3, 5};
// var arr2 = new int[] {2, 6};
// DateTime startTime, endTime;
// startTime = DateTime.Now;
// var sorted_one = SortingAndSearching.SortingAndSearching.MergeAlgorithm(unsorted_array);
// endTime = DateTime.Now;
// var elapsed_time = ((TimeSpan)(endTime - startTime)).TotalMilliseconds / 1000;
// WriteLine($"array: {string.Join(", ", sorted_one)}, time elapsed: {elapsed_time:F2}");

// var r = Peek.Solution.Find(unsorted_array, 0, unsorted_array.Length - 1);
// WriteLine(r);

// WriteLine(Stock.Solution.getCmp(unsorted_array, 0, int.MinValue, (int x, int y) => { return x > y ? x : y; }));

// var tree = new Tree.TreeNode(2);
// var tree_l = new Tree.TreeNode(3);
// var tree_l_1 = new Tree.TreeNode(1);
// tree.left = tree_l;
// tree_l.left = tree_l_1;

// var tree_l_2 = new Tree.TreeNode(1);
// var tree_r_2 = new Tree.TreeNode(3);
// tree_l.left = tree_l_2;
// tree_l.right = tree_r_2;

// var tree_l_7 = new Tree.TreeNode(6);
// var tree_r_7 = new Tree.TreeNode(9);

// tree_r.left = tree_l_7;
// tree_r.right = tree_r_7;



// Tree.TreeNode.print2D(tree);

// var t = Tree.Solution.InvertTree(tree);

// Tree.TreeNode.print2D(t);

var sergey = new OOP.Person
{
    Name = "Sergey Yakovlev",
    DateOfBirth = new DateTime(1981, 4, 9),
    FavoriteAncientWonder = OOP.WondersOfTheAncientWorld.GreatPyramidOfGiza | OOP.WondersOfTheAncientWorld.ColossusOfRhodes
};

// WriteLine(
//     format: "{0}, was born on {1:dddd, d MMMM yyyy}. He's a favorite wonder is {2}",
//     arg0: sergey.Name,
//     arg1: sergey.DateOfBirth,
//     sergey.FavoriteAncientWonder
// );

var tree =
  new Tree.TreeNode
  {
      val = 2,
      left = new Tree.TreeNode { val = 3 }
  };


// WriteLine(Tree.Solution.DiameterOfBinaryTree(tree));

// SortingAndSearching.SortingAndSearching.Swap(unsorted_array);

// foreach(var x in unsorted_array) WriteLine(x);

// var data_struture = new DataStructures.DataStructures();
// data_struture.vector = new List<int>(unsorted_array);

// WriteLine(data_struture.vector.First());



DateTime startTime, endTime;
startTime = DateTime.Now;
var coins = new int[200];
var t = DynamicProgramming.Solution.RecursiveApproach(new int[] { 1, 3, 4 }, 5, new bool[200], new int[200], coins);
endTime = DateTime.Now;

// var elapsed_time = ((TimeSpan)(endTime - startTime)).TotalMilliseconds / 1000;
// WriteLine($"min coins: {t}, time elapsed: {elapsed_time:F2}");

// var n = 5;
// while (n > 0)
// {
//     WriteLine(coins[n]);
//     n -= coins[n];
// }


// var seq_array = new int[] { 6, 2, 5, 1, 7, 4, 8, 3 };
// var res = DynamicProgramming.Solution.LongestIncreasingSubSeq(seq_array);
// foreach(var i in res) WriteLine(i);


var grid = new int[,] {{3, 7, 9, 2, 7}, {9, 8, 3, 5, 5}, {1, 7, 9, 8, 5}, {3, 8, 6, 4, 10}, {6, 3, 9, 7, 8}};
var res = DynamicProgramming.Solution.PathsInGrid(grid);
WriteLine(res);
