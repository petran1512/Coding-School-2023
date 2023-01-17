using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Session_07
{
    public class Message
    {
        //props
        public Guid ID { get; set; }
        public DateTime TimeStamp { get; set; }
        public string? MessagE { get; set; }

        //consts
        public Message()
        {
        }

        public Message(Guid id)
        {
            ID = id;
        }

        public Message(Guid id, DateTime timestamp)
        {
            ID = id;
            TimeStamp = timestamp;
        }
        public Message(Guid id, DateTime timestamp,String message)
        {
            ID = id;
            TimeStamp = timestamp;
            MessagE = message;
        }


    }
}



