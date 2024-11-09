// application_test.cs
using NUnit.Framework;
using System.Threading.Tasks;

[TestFixture]
public class ApplicationTest
{
    [Test]
    public async Task CreateExamPaper_ShouldAddToDatabase()
    {
        // Arrange: Create a mock exam paper object
        var examPaper = new ExamPaper { Title = "Maths", Subject = "Math", Date = DateTime.Now };

        // Act: Call the API endpoint to create a new exam paper
        var response = await apiClient.PostAsync("/api/exam-papers", examPaper);

        // Assert: Check that the exam paper was added successfully
        Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);
    }
}
