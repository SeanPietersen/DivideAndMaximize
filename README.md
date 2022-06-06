Your friend has a list of k numbers : [a1, a2, a3, ... ak].

He is allowed to do the operation which consists of three steps:

    select two numbers: ai and aj (ai % 2 = 0)
    replace ai with ai / 2
    replace aj with aj * 2

Help him to find the maximum sum of list elements that is possible to achieve by using this operation(maybe multiple times). Return this sum modulo 1 000 000 007, because it can be quite big.

Input:

List of k elements: [a1, a2, a3, ..., ak]; k < 10**4
All numbers are positive and smaller than 10**9

Output:

Maximum sum after some operations(modulo 1 000 000 007)

