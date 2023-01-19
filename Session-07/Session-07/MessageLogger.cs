using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Message(Guid id, DateTime timestamp, string messagetext)
        {
            ID = id;
            TimeStamp = timestamp;
            MessageText = messagetext;
        }
    }

    public class MessageLogger  {
        //props
        public Message[] Messages { get; set; }

        private int _messageCounter = 0;

        //consts
        public MessageLogger() { 
        }
        public MessageLogger(Message message)
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
