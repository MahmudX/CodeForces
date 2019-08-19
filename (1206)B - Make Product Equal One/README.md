# B. Make Product Equal One

Time limit per test: 1 second

Memory limit per test: 256 megabytes

Input: Standard Input

Output: Standard Output

You are given n numbers a1,a2,…,an. With a cost of one coin you can perform the following operation:

Choose one of these numbers and add or subtract 1 from it.

In particular, we can apply this operation to the same number several times.

We want to make the product of all these numbers equal to 1, in other words, we want a1⋅a2 … ⋅an=1.

For example, for n=3 and numbers [1,−3,0] we can make product equal to 1 in 3 coins: add 1 to second element, add 1 to second element again, subtract 1 from third element, so that array becomes [1,−1,−1]. And 1⋅(−1)⋅(−1)=1.

What is the minimum cost we will have to pay to do that?

## Input

The first line contains a single integer n (1≤n≤105) — the number of numbers.

The second line contains n integers a1,a2,…,an (−109≤ai≤109) — the numbers.

## Output

Output a single number — the minimal number of coins you need to pay to make the product equal to 1.

## Examples

### Input

2

-1 1

### Output

2

### Input

4

0 0 0 0

### Output

4

### Input

5

-5 -3 5 3 0

### Output

13

## Note

In the first example, you can change 1 to −1 or −1 to 1 in 2 coins.

In the second example, you have to apply at least 4 operations for the product not to be 0.

In the third example, you can change −5 to −1 in 4 coins, −3 to −1 in 2 coins, 5 to 1 in 4 coins, 3 to 1 in 2 coins, 0 to 1 in 1 coin.

#### Original Problem

http://codeforces.com/contest/1206/problem/B
