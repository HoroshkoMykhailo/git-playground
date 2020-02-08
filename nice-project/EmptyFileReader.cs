namespace NiceProject
{
    using System.Collections.Generic;

    internal class EmptyFileReader : IFileReader
    {
        public IEnumerable<int> ReadAllNumbers()
        {
<<<<<<< HEAD:nice-project/EmptyFileReader.cs
            return new int[0];
=======
            return new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
>>>>>>> 85e9acc (Change stub file reader to return more numbers):nice-project/StubFileReader.cs
        }
    }
}