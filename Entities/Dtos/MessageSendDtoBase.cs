using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class MessageSendDtoBase
    {
        public long MessageId { get; set; }
        public string SenderName { get; set; }
        public string Message { get; set; }
        public DateTime SendDate { get; set; }
        public int ChatRoomId { get; set; }
    }
}
