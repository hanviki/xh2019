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
    public interface ServiceContract_HEM_B_STAFF_REAL
    {
        BizLogicMsg Save(EntityObject_HEM_B_STAFF_REAL obj);

        BizLogicMsg Save(EntityObject_HEM_B_STAFF_REAL[] itemObj);

        BizLogicMsg Update(EntityObject_HEM_B_STAFF_REAL obj);

        BizLogicMsg Update(EntityObject_HEM_B_STAFF_REAL[] itemObj);

        BizLogicMsg Update(string UserID);

        DisplayObject_HEM_B_STAFF_REAL[] Query(CauseObject_HEM_B_STAFF_REAL cause);

        DisplayObject_HEM_B_STAFF_REAL[] Query(CauseObject_HEM_B_STAFF_REAL cause, PagingParamter paging, OrderByParameter order);

        EntityObject_HEM_B_STAFF_REAL Get(EntityObject_HEM_B_STAFF_REAL entity);

        BizLogicMsg Delete(EntityObject_HEM_B_STAFF_REAL obj);

        BizLogicMsg Delete(EntityObject_HEM_B_STAFF_REAL[] itemObj);
    }
}

