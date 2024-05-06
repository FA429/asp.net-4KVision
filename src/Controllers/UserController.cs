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
    public IEnumerable<UserReadDto> FindAll()
    {
        return _userService.FindAll();
    }

    [HttpGet("{userId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public ActionResult<UserReadDto?> FindOne(Guid userId)
    {
        IEnumerable<UserReadDto>? users = _userService.FindAll();
        UserReadDto? user = users.FirstOrDefault(u => u.Id == userId);
        if (user == null) return NoContent();
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
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult DeleteOne(Guid userId)
    {
        var deleteUser = _userService.FindOne(userId);
        if (deleteUser == null) return NotFound();
        _userService.DeleteOne(userId);
        return NoContent();
    }
    [HttpPatch("{userId}")]
    [ProducesResponseType(StatusCodes.Status202Accepted)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<UserReadDto?> UpdateOne(Guid userId, [FromBody] UserUpdateDto user)
    {
        var isUser = _userService.FindOne(userId);
        if (isUser == null) return NotFound();
        return Accepted(_userService.UpdateOne(userId, user));
    }
}