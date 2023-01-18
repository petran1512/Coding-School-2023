using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    public class ActionResponse : ActionEntity
    {
        //props
        public Guid ResponseID { get; set; }
        public string Output { get; set; }
        public ActionResponse()
        {
            ResponseID = Guid.NewGuid();
        }

        //consts

        public ActionResponse(Guid requestid)
        {
            RequestID = requestid;
        }
        public ActionResponse(Guid requestid,Guid response)
        {
            RequestID = requestid;
            Response = response;
        }
        public ActionResponse(Guid requestid, Guid response,string output)
        {
            RequestID = requestid;
            Response = response;
            Output = output;
        }

    }
}
