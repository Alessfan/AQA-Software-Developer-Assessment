// api_test.cs
using Moq;
using NUnit.Framework;

[TestFixture]
public class ApiTest
{
    [Test]
    public void GetExamPapers_BySubject_ReturnsCorrectPapers()
    {
        // Arrange: Mock data and repository
        var mockRepo = new Mock<IExamPaperRepository>();
        mockRepo.Setup(repo => repo.GetBySubject("Math")).Returns(new List<ExamPaper> { new ExamPaper { Title = "Math Paper" } });

        // Act: Call the GetExamPapers method
        var result = apiClient.Get("/api/exam-papers?subject=Math");

        // Assert: Check the response
        Assert.AreEqual(1, result.Count());
    }
}
