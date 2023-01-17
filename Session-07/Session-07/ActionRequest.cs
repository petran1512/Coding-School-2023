using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Session_07
{
    public class ActionRequest : Action
    {
        public enum ActionEnum
        {
            Convert,
            Uppercase,
            Reverse
        }


        //props
        public Guid RequestID { get; set; }
        public String Input { get; set; }

        public ActionEnum Action { get; set; }

        //consts
        public ActionRequest()
        {

        }
        public ActionRequest(Guid requestid)
        {
            RequestID = requestid;
        }
        public ActionRequest(Guid requestid, String input)
        {
            RequestID = requestid;
            Input = input;
        }
        public ActionRequest(Guid requestid, String input, ActionEnum action)
        {
            RequestID = requestid;
            Input = input;
            Action = action;
        }

    }

}
