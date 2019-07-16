﻿using System;
using System.Data;
using System.Collections;
using System.ServiceModel;
using Ipedf.Hrp.Hem.Sap.Entity;
using Ipedf.Hrp.Hem.Sap.DataAccess;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using Ipedf.Hrp.Hem.Sap.BizLogic;

namespace Ipedf.Hrp.Hem.Sap.ServiceContract
{
    public interface ServiceContract_V_HEM_B_STAFF_EXT
    {
        DisplayObject_V_HEM_B_STAFF_EXT[] Query(CauseObject_V_HEM_B_STAFF_EXT cause, PagingParamter paging, OrderByParameter order);

        DisplayObject_V_HEM_B_STAFF_EXT[] Query(CauseObject_V_HEM_B_STAFF_EXT cause);
    }
}

