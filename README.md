# Codility-CountNonDivisible
 You are given an array A consisting of N integers.</br>
 For each number A[i] such that 0 ≤ i < N,</br> 
 we want to count the number of elements of the array that are not the divisors of A[i].</br> 
 We say that these elements are non-divisors.

 For example, consider integer N = 5 and array A such that:</br>
 A[0] = 3</br>
 A[1] = 1</br>
 A[2] = 2</br>
 A[3] = 3</br>
 A[4] = 6</br>
 For the following elements:</br>
 A[0] = 3, the non-divisors are: 2, 6,</br>
 A[1] = 1, the non-divisors are: 3, 2, 3, 6,</br>
 A[2] = 2, the non-divisors are: 3, 3, 6,</br>
 A[3] = 3, the non-divisors are: 2, 6,</br>
 A[4] = 6, there aren't any non-divisors.

 Write a function:</br>
 class Solution { public int[] solution(int[] A); }</br>
 that, given an array A consisting of N integers,</br>
 returns a sequence of integers representing the amount of non-divisors.</br>
 Result array should be returned as an array of integers.

 For example, given:</br>
 A[0] = 3</br>
 A[1] = 1</br>
 A[2] = 2</br>
 A[3] = 3</br>
 A[4] = 6</br>
 the function should return [2, 4, 3, 2, 0], as explained above.

 Write an efficient algorithm for the following assumptions:</br>
 N is an integer within the range [1..50,000];</br> 
 each element of array A is an integer within the range [1..2 * N].
