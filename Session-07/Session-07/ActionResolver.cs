using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    public class ActionResolver
    {
        //props
        public MessageLogger Logger { get; set; }

        //consts
        public ActionResolver()
        {

        }
        public ActionResolver(MessageLogger logger)
        {
            Logger = logger;    

        }

        //meths
        public ActionResponse Execute(ActionRequest request)
        {
            return null;
        }

    }
}
