using Dax.BlazorServer.Template.Models;

namespace Dax.BlazorServer.Template.Tests.Models;

[TestFixture]
public class RegistrationFormModelTests
{
    [Test]
    public void Clear()
    {
        var sut = GetSut();
        sut.FirstName = "Foo";
        sut.LastName = "Bar";

        sut.Clear();

        Assert.That(sut.FirstName, Is.Empty);
        Assert.That(sut.LastName, Is.Empty);
    }

    private RegistrationFormModel GetSut()
    {
        return new RegistrationFormModel();
    }
}