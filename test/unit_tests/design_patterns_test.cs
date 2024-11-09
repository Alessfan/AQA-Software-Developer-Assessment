using NUnit.Framework;

[TestFixture]
public class DesignPatternsTest
{
    [Test]
    public void SingletonPattern_Test()
    {
        // Arrange: Initialize a singleton instance.
        // Act: Retrieve the singleton instance multiple times.
        // Assert: Check that all instances point to the same memory location.
    }

    [Test]
    public void RepositoryPattern_Test()
    {
        // Arrange: Mock the repository and set up test data.
        // Act: Perform repository operations (add, fetch).
        // Assert: Verify that the operations behave as expected.
    }
}
