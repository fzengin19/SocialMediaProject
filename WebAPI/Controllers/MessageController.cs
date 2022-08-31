using Business.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        IGroupMessageService _groupMessageService;

        public MessageController(IGroupMessageService groupMessageService)
        {
            _groupMessageService = groupMessageService;
        }

        [HttpPost("login")]
        public ActionResult SendGroupMessage(GroupMessageSendDto messageSendDtoBase)
        {
            GroupMessage groupMessage = new GroupMessage();
            groupMessage.MessageId = messageSendDtoBase.MessageId;
            //groupMessage.SenderId = messageSendDtoBase.SenderName;
            groupMessage.ChatRoomId = messageSendDtoBase.ChatRoomId;

            var result = _groupMessageService.Add(groupMessage);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Message);
        }
    }
}
