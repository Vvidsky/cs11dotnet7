# Exercise 2.1
1. What statement can you type in a C# file to discover the compiler and language version?
   <br>```Console.Write(typeof(string).Assembly.ImageRuntimeVersion);```
2. What are the two types of comments in C#?
   <br>```inline and multi-line comment```
3. What is the difference between a verbatim string and an interpolated string?
   <br>```interpolated string uses $ as a prefix while verbatim string uses @ as a prefix. In addition, interpolated string allows the developers to specify replacing argument within the string```
4. Why should you be careful when using float and double values?
   <br>```The floating points are calculated with base 2 number. Thus, it will not be the exact number such as 0.1+0.2 = 0.3```
5. How can you determine how many bytes a type like double uses in memory?
   <br>```Console.WriteLine($"double uses {sizeof(double)}```
6. When should you use the var keyword?
   <br>```When the variable type is obvious```
7. What is the newest syntax to create an instance of a class like XmlDocument?
   <br>
8. Why should you be careful when using the dynamic type?
9. How do you right-align a format string?