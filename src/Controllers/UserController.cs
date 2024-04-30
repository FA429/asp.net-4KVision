using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controllers;
public class UserController : CustomBaseController
{
    private IUserService _userService;
    public UserController(IUserService userService)
    {
        _userService = userService;
    }
    [HttpGet]
    public List<UserReadDto> FindAll()
    {
        return _userService.FindAll();
    }
    [HttpGet("{userId}")]
    public ActionResult<UserReadDto?> FindOne(string userId)
    {
        return Ok(_userService.FindOne(userId));
    }
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<User> CreateOne([FromBody] User user)
    {
        if (user != null)
        {

            var createdUser = _userService.CreateOne(user);
            return CreatedAtAction(nameof(CreateOne),createdUser);
        }
        return BadRequest();
    }
    [HttpDelete("{userId}")]
    public ActionResult<User?> DeleteOne(string userId)
    {
        NoContent();
        return _userService.DeleteOne(userId);
    }
    [HttpPatch("{userId}")]
    public User? UpdateOne(string userId, [FromBody] User user)
    {
        return _userService.UpdateOne(userId, user);
    }
}