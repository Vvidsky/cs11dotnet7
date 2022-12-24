1. What are the six combinations of access modifier keywords and what do they do?
    ```
    1. internal - Member is accessible inside the type only. (Default)
    2. protected - Member is accessible inside the type and any type in the same assembly.
    3. private - Member is accessible inside the type and any type that inherits from the type.
    4. public - Member is accessible everywhere.
    5. internal proteced - Member is accessible inside the type, 
    any type in the same assembly, and any type that inherits from the type.
    6. private protected - Member is accessible inside the type 
    and any type that inherits from the type and is in the same assembly.
    ```
2. What is the difference between the static, const, and readonly keywords when applied to a type member?
    ```
    static variable is shared and can be accessed from any instance
    const type will not allow the modification
    readonly will not allow the modification, it allows a value to be calculated at run-time and set in the constructor or field initializer.
    ```
3. What does a constructor do?
    ```
    Execute the code at runtime
    ```
4. Why should you apply the [Flags] attribute to an enum type when you want to store combined values?
    ```
    Combine multiple choices into a single value. It can reduces a memory usage from 4 bytes to one bytes, and allow acessing multiple instances
    For example, A = 4 or 0000 0100, B = 8 or 0000 1000. I can get both of them with 12 or 0000 1100. 
    ```
5. Why is the partial keyword useful?
    ```
    Spliting a class definition across multiple files
    ```
6. What is a tuple?
    ```
    A datastructure that can store various types of variables.
    ```
7. What does the record keyword do?
    ```
    Making the whole object immutable (Define record instead of class).
    ```
8. What does overloading mean?
    ```
    Method with the same name but different parameters.
    ```
9. What is the difference between a field and a property?
    ```
    Field is a varaible itself.
    Property is a method (or a pair of methods) that acts and looks like a field when you want to get or set a value, thereby simplifying the syntax.
    ```
10. How do you make a method parameter optional?
    ```
    Initializing the parameter with any value.
    ```