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
    // Add mapper to Get Users
    [HttpGet]
    public List<UserReadDto> FindAll()
    {
        return _userService.FindAll();
    }
    
    // Add mapper to Get User by Id
    [HttpGet("{userId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
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
            return CreatedAtAction(nameof(CreateOne), createdUser);
        }
        return BadRequest();
    }
    [HttpDelete("{userId}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public ActionResult<User?> DeleteOne(string userId)
    {
        NoContent();
        return _userService.DeleteOne(userId);
    }
    [HttpPatch("{userId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<User?> UpdateOne(string userId, [FromBody] User user)
    {
        return Ok(_userService.UpdateOne(userId, user));
    }
}