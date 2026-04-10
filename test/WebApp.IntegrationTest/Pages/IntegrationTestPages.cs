using System.Net;

using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;

public class IntegrationTestPages : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;
    public IntegrationTestPages(WebApplicationFactory<Program> factory)
    {
        _factory=factory;
    }
    [Fact]
    public async Task Get_PaginasDeLaApp_RetornanStatusCode200()
    {
        var client =_factory.CreateClient();

        var response =await client.GetAsync("/");
       
       response.EnsureSuccessStatusCode();
       Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }
[Theory]
[InlineData("/Index")] 
[InlineData("/Privacy")] 
[InlineData("/About")] 
public async Task Get_PaginasDeLaApp_RetornanStatusCode200YHtml(string url)

{

var client = _factory.CreateClient();
 
var response = await client.GetAsync(url);

response.EnsureSuccessStatusCode(); 
Assert.Equal(HttpStatusCode.OK, response.StatusCode);
Assert.Equal("text/html; charset=utf-8", response.Content.Headers.ContentType?.ToString());
}
}
