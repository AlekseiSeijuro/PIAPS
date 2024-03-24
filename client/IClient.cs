using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookComputing.XmlRpc;


[XmlRpcUrl("http://127.0.0.1:8888/")]
public interface IClient : IXmlRpcProxy, IMatrixService
    {
    }
