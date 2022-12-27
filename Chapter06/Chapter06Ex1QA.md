1. What is a delegate?
   ```
   A type that represents references to methods with a particular parameter list and return type.
   ```
2. What is an event?
   ```
   Since delegates are multicast, it is possible to assign method with += sign, and event will only provide this function to add methods.
   ```
3. How are a base class and a derived class related, and how can the derived class access the base class?
   ```
   derived class is a child of base class, derived class will inherits both fields and methods from the base class.
   ```
5. What is the difference between is and as operators?
   ```
   'is' is used to check the type while as operator is for type casting.
   ```
6. Which keyword is used to prevent a class from being derived from or a method from being further overridden?
   ```
   sealed
   ```
7. Which keyword is used to prevent a class from being instantiated with the new keyword?
   ```
   abstract
   ```
8. Which keyword is used to allow a member to be overridden?
   ```
   override
   ```
9.  What’s the difference between a destructor and a deconstruct method?
    ```
    Destructor or Finalizer is for garbage collector to dispose an instantiated object while deconstruct is for assigning variables or tuples.
    ```
10. What are the signatures of the constructors that all exceptions should have?
   ```
   public PersonException() : base() { }
   public PersonException(string message) : base(message) { }
   public PersonException(string message, Exception innerException): base(message, innerException) { }
   ```
11. What is an extension method, and how do you define one?
   ```
   Additional methods that are added to a class object without interfering to the current class.
   ```