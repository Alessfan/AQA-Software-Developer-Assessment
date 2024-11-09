// mocking_test.cs
using Moq;
using NUnit.Framework;

[TestFixture]
public class MockingTest
{
    [Test]
    public void MockDatabaseCall_ReturnsCorrectData()
    {
        // Arrange
        var mockDb = new Mock<IExamPaperRepository>();
        mockDb.Setup(db => db.GetById(1)).Returns(new ExamPaper { Title = "Sample Paper" });

        // Act
        var paper = mockDb.Object.GetById(1);

        // Assert
        Assert.AreEqual("Sample Paper", paper.Title);
    }
}
