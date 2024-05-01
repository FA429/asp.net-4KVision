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
    public ActionResult<UserReadDto?> FindOne(Guid userId)
    {
        return Ok(_userService.FindOne(userId));
    }
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<UserReadDto> CreateOne([FromBody] UserCreateDto user)
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
    public ActionResult<UserReadDto?> DeleteOne(Guid userId)
    {
        var deleteUser = _userService.FindOne(userId);
        if (deleteUser != null)
        {

            return Ok(_userService.DeleteOne(userId));
        }
        else
        {

            return NoContent();
        }
    }
    [HttpPatch("{userId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<User?> UpdateOne(Guid userId, [FromBody] User user)
    {
        return Ok(_userService.UpdateOne(userId, user));
    }
}