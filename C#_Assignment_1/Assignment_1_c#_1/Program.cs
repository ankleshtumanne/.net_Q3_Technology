﻿// int x = 10;
// if (x = 5)
// Console.WriteLine("True");
// else
// Console.WriteLine("False");

// output = error warning cs0029 cannot implicitly convert type "int" to "bool"

// int a = 10,b = 20,c = 30;
// if (a > b && a > c)
// Console.WriteLine("A is largest");
// else if (b > a && b > c)
// Console.WriteLine("B is largest");
// else
// Console.WriteLine("C is largest");
// output= c is largest 

// int a = 10;
// int b = 20;
// int c = 30;
// if (a > b && a > c)
// Console.WriteLine("A is largest");
// else if (b > a && b > c)
// Console.WriteLine("B is largest");
// else
// Console.WriteLine("C is largest");

// output= semicolumn is must important 

// int num = 2;
// switch (num + 1) {
// case 1: Console.Write("One");
// break;
// case 2: Console.Write("Two");
// break;
// case 3: Console.Write("Three");
// break;
// case 4: Console.Write("Four");
// break;
// default: Console.Write("Default");

// }
// output = it is showing error bcz in c# if you declare deafault so you want to throw or break andreturn the condition ;

// int x = 0;
// if(x)
//    Console.WriteLine("Hello");
// else
// Console.WriteLine("World");

// output = error CS0029: Cannot implicitly convert type 'int' to 'bool'

// 5

// bool isTrue = false;
// if (isTrue = true)
// Console.WriteLine("Yes");
// else
// Console.WriteLine("No");

// output = yes but getting an warning warning CS0219: The variable 'isTrue' is assigned but  
// its value is never used

// 6

// int x = 5, y = 10;
// if (x > 0)
// if (y < 10)
// Console.WriteLine("A");
// else
// Console.WriteLine("B");
// else
// Console.WriteLine("C");

// output= B

// 7
// int a = 5;
// if (a > 0)
// if (a < 10)
// Console.WriteLine("X");
// else if (a > 2)
// Console.WriteLine("Y");
// else
// Console.WriteLine("Z");
// output= X

// 8
// int x = 5, y = 10;
// if (x++ > 5 && y++ < 10)
// Console.WriteLine(x,y);
// else
// Console.WriteLine(x,y); // writeLine does not suport multiple argument
// output= Argument 1: cannot convert from 'int' to 'string'

// 9
// double x = 0.1 + 0.2;
// if (x == 0.3)
// Console.WriteLine("Equal");
// else
// Console.WriteLine("Not Equal");
// anser= Not Equal 

// 10
// decimal x = 0.1m + 0.2m;
// if (x == 0.3m)
// Console.WriteLine("Equal");
// answer=Equal

// 11

// for (int i = 1; i <= 5; i++)
// {
// Console.Write(i + " ");
// }
// answerr=1 2 3 4 5 

// 12 
// for (int i = 5; i >= 1; i--)
// {
// Console.Write(i + " ");
// }
//output = 5 4 3 2 1

//13
// (int i = 1; i <= 5; i++)
// {
// if (i == 3)
// continue;
// Console.Write(i + " ");
// }
// output = error CS1026: )
//  this is the right answer
// for (int i = 1; i <= 5; i++)
// {
//     if (i == 3)
//         continue;
//     Console.Write(i + " ");
// }
//14
// for (int i = 1; i <= 5; i++)
// {
// if (i == 3)
// break;
// Console.Write(i + " ");
// }
// answerr=1 2
//15
// int i = 1;
// while (i <= 3)
// {
// Console.Write(i + " ");
// i++;
// }
// answerr=1 2 3 

//16
// int i = 1;
// while (i > 0)
// {
// Console.Write(i + " ");
// if (i == 3) break;
// i++;
// }
// answerr=1 2 3

//17
// int i = 5;
// do
// {
// Console.Write(i + " ");
// } while (i < 3);
// answerr=5

//18
// for (int i = 1; i <= 3; i++)
// {
// for (int j = 1; j <= 2; j++)
// {
// Console.Write(i + "" + j + " ");
// }
// }
// aswerr=11 12  21 22 31 33

//19
// for (int i = 2; i <= 10; i += 2)
// {
// Console.Write(i + " ");
// }
// answerr=2 4 6 8 10

// 20
// int i = 1;
// while (i <= 10)
// {
// Console.Write(i + " ");
// i += 2;
// }
// output=1 3 5 7 9

// 21

// int sum = 0;
// for (int i = 1; i <= 5; i++)
// {
// sum += i;
// }
// Console.Write(sum);
// answerr=15

// 22
// int fact = 1;
// for (int i = 1; i <= 4; i++)
// {
// fact *= i;
// }
// Console.Write(fact);
// answerr=24

// 23
// int num = 1234, count = 0;
// while (num > 0)
// {
// count++;
// num /= 10;
// }
// Console.Write(count);
// answerr=4

// 24
// int num = 123, rev = 0;
// while (num > 0)
// {
// rev = rev * 10 + num % 10;
// num /= 10;
// }
// Console.Write(rev);
// answerr=321

//25
// for (int i = 1; i <= 5; i++)
// {
// Console.Write(3 * i + " ");
// }
// answerr=3 6 9 12 15

//26
// int a = 0, b = 1, c;
// Console.Write(a + " " + b + " ");
// for (int i = 2; i < 5; i++)
// {
// c = a + b;
// Console.Write(c + " ");
// a = b;
// b = c;
// }
// answerr=0 1 1 2 3

// // 27
// for (int i = 1; i <= 5; i++)
// {
// if (i % 2 == 0) continue;
// Console.Write(i + " ");
// }
// answerr=1 3 5

// 28
// int i = 1;
// while (i <= 3)
// Console.Write(i++ + " ");
// answer= 1 2 3 

// 29
// int num = 123, sum = 0;
// while (num > 0)
// {
// sum += num % 10;
// num /= 10;
// }
// Console.Write(sum);
// answerr=6

// 30
// int num = 7, flag = 1;
// for (int i = 2; i < num; i++)
// {
// if (num % i == 0)
// {
// flag = 0;
// break;
// }
// }
// Console.Write(flag == 1 ? "Prime" : "Not Prime");
// answeer=Prime