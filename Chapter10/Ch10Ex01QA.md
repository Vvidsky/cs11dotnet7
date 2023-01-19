1. What type would you use for the property that represents a table, for example, the Products property of a database context?
   ```
   DbSet<T>
   ```
2. What type would you use for the property that represents a one-to-many relationship, for example, the Products property of a Category entity?
   ```
   ICollection<T>
   ```
3. What is the EF Core convention for primary keys?
   ```
   The primary key is assumed to be a property that is named Id or ID, 
   or when the entity model class is named Product, 
   then the property can be named ProductId or ProductID. 
   If this property is an integer type or the Guid type, 
   then it is also assumed to be an IDENTITY column 
   (a column type that automatically assigns a value when inserting)
   ```
4. When might you use an annotation attribute in an entity class?
    ```
    Map classes to the database objects.
    ```
5. Why might you choose the Fluent API in preference to annotation attributes?
    ```
    1. Making model class easy cleaner and easier to read.
    2. Specifying a complex type or to map a property to a column with a different name
    ```
6. What does a transaction isolation level of Serializable mean?
    ```
    Applying key-range locks to prevent any action that would affect the results, 
    including inserts and deletes.
    ```
7. What does the DbContext.SaveChanges() method return?
    ```

    ```
8. What is the difference between eager loading and explicit loading?
    ```

    ```
9. How should you define an EF Core entity class to match the following table?
   ```sql
   CREATE TABLE Employees(
   EmpId INT IDENTITY,
   FirstName NVARCHAR(40) NOT NULL,
   Salary MONEY
   )
   ```
   ```c#
    public partial class Employees
    {
    [Key]
    public int EmpId { get; set; }

    [Column(TypeName = "nvarchar (40)")]
    public string FirstName { get; set; } = null!;

    [Column(TypeName = "MONEY")]
    public long? Salary { get; set; }
    }
   ```
10. What benefit do you get from declaring entity navigation properties as virtual?
