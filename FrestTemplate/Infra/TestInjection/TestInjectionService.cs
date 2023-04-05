namespace FrestTemplate.Infra.TestInjection;
public class TestInjectionService:ITestInjectionService
{
    private readonly string _message;
    public TestInjectionService()
    {
        var random = new Random().Next(1000,1999);
        _message = random.ToString();
    }
    public Task<string> GetMessage()
    {
        return Task.FromResult(_message);
    }
}

