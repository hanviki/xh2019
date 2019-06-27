//-----------------------------------------------------------------------
// <copyright file=" AttendanceRecordD.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: AttendanceRecordD.cs
// * history : Created by T4 06/27/2019 10:49:09 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Data;
using NFine.Domain.Entity.Hrm;
using NFine.Domain.IRepository.Hrm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Repository.Hrm
{
    public class AttendanceRecordDRepository : RepositoryBase<AttendanceRecordDEntity>, IAttendanceRecordDRepository
    {
    }
}