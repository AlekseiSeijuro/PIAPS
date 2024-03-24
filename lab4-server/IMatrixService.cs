﻿using CookComputing.XmlRpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public interface IMatrixService
{
        [XmlRpcMethod("matrixHandle")]
        int[][] matrixHandle(int[][] m);
}

