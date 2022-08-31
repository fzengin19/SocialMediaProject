using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class PrivateMessageSendDto : MessageSendDtoBase
    {
        public int RecipientId { get; set; }
    }
}
