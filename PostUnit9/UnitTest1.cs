using Microsoft.AspNetCore.Mvc;
using session9git.Controllers;
using session9git.Model;
using session9git.Repository;

namespace PostUnit9
{
    public class UnitTest1
    { 

    private readonly UserController _controller;
    private readonly UserRepository _repository;

    public UnitTest1()
    {

        _repository = new UserRepository();
        _controller = new UserController(_repository);
    }

    [Fact]
    public void TestForList()
    {
        var okResult = _controller.GetAllUsers();
        // Assert
        Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
    }

    [Fact]
    public void TestForCount()
    {
        // Act
        var okResult = _controller.GetAllUsers() as OkObjectResult;
        // Assert
        var items = Assert.IsType<List<User>>(okResult.Value);
        Assert.Equal(2, items.Count);
    }
}
}