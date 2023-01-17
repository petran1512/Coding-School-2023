using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    public class MessageLogger {
        //props
        public Message[] Messages { get; set; }

        //consts
        public MessageLogger() { 
        }
        public MessageLogger(Message[] messages)
        {
            Messages = messages;    
        }

        //meths
        public void ReadAll()
        {

        }

        public void Clear()
        {

        }

        public void Write(Message message) { 
        }

    }
}
