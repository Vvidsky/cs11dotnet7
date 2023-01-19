1. What is the difference between using the File class and the FileInfo class?
    ```
    File class is a static class while FileInfo class is an instance type class, which is required to be instantiated
    ```
2. What is the difference between the ReadByte method and the Read method of a stream?
    ```
    ReadByte reads the next byte from the stream and advances the position.
    Read and ReadAsync read a specified number of bytes from the stream into a byte array and advance the position.
    ```
3. When would you use the StringReader, TextReader, and StreamReader classes?
    ```
    TextReader is the abstract base class of StringReader and StreamReader.
    StreamReader will be used when reading characters from a byte stream in a particular encoding.
    StringReader will be used when reading text from the string.
    ```
4. What does the DeflateStream type do?
    ```
    Compress and Decompress Stream
    ```
5. How many bytes per character does UTF-8 encoding use?
    ```
    4 Bytes
    ```
6. What is an object graph?
    ```

    ```
7. What is the best serialization format to choose for minimizing space requirements?
    ```

    ```
8. What is the best serialization format to choose for cross-platform compatibility?
9. Why is it bad to use a string value like "\Code\Chapter01" to represent a path, and what should you do instead?
10. Where can you find information about NuGet packages and their dependencies?
