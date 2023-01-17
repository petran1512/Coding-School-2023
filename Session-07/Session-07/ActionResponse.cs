using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    public class ActionResponse : ActionResolver
    {
        //props
        public Guid RequestID { get; set; }
        public Guid Response { get; set; }
        public String Output { get; set; }

        //consts
        public ActionResponse() { 
        }
        public ActionResponse(Guid requestid)
        {
            RequestID = requestid;
        }
        public ActionResponse(Guid requestid,Guid response)
        {
            RequestID = requestid;
            Response = response;
        }
        public ActionResponse(Guid requestid, Guid response,String output)
        {
            RequestID = requestid;
            Response = response;
            Output = output;
        }

    }
}
