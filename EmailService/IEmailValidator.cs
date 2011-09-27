using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace EmailService
{
    [ServiceContract]
    public interface IEmailValidator
    {
        [OperationContract]
        bool ValidateAddress(string emailAddress);
    }
}
