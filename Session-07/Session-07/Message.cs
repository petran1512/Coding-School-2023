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
        //change from class diagram: Message property can't be the same as class name.
        public string MessageText { get; set; }

        //consts
        public Message(string v)
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
        public Message(Guid id, DateTime timestamp,string messagetext)
        {
            ID = id;
            TimeStamp = timestamp;
            MessageText = messagetext;
        }


    }
}



