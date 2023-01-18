using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Session_07
{

        public class ActionEntity
        {
            public Guid RequestID { get; set; }
        }

    public class ActionRequest : ActionEntity
    {

        //props
        public string Input { get; set; }

        public ActionEnum Action { get; set; }

        public ActionRequest() {
            RequestID = Guid.NewGuid();

        }

        //consts
        public ActionRequest()
        {

        }
        public ActionRequest(Guid requestid)
        {
            RequestID = requestid;
        }
        public ActionRequest(Guid requestid, string input)
        {
            RequestID = requestid;
            Input = input;
        }
        public ActionRequest(Guid requestid, string input, ActionEnum action)
        {
            RequestID = requestid;
            Input = input;
            Action = action;
        }

    }

}
