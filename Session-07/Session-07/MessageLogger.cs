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

        private int _messageCounter = 0;

        //consts
        public MessageLogger() { 
        }
        public MessageLogger(Message m)
        {
            Messages = new Message[1000];    
        }

        //meths
        public void ReadAll()
        {
            foreach (Message message in Messages)
            {
                if (message != null)
                {
                    Console.WriteLine(message.MessageText);
                }
            }

        }

        public void Clear()
        {
            Messages = new Message[1000];
            _messageCounter= 0;

        }

        public void Write(Message message) {
            Messages[_messageCounter] = message;
            _messageCounter++;
        }

    }
}
