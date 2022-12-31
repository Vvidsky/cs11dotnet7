1. What is the maximum number of characters that can be stored in a string variable?
    
2. When and why should you use a SecureString type?
3. When is it appropriate to use a StringBuilder class?
4. When should you use a LinkedList<T> class?
5. When should you use a SortedDictionary<T> class rather than a SortedList<T> class?
6. In a regular expression, what does $ mean?
7. In a regular expression, how can you represent digits?
8. Why should you not use the official standard for email addresses to create a regular expression 
to validate a user’s email address?
9. What characters are output when the following code runs?
    ```c#
    string city = "Aberdeen";
    ReadOnlySpan<char> citySpan = city.AsSpan()[^5..^0];
    WriteLine(citySpan.ToString());
    ```
10. How could you check that a web service is available before calling it?