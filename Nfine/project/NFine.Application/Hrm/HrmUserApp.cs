//-----------------------------------------------------------------------
// <copyright file=" HrmUser.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: HrmUser.cs
// * history : Created by T4 06/13/2019 11:15:41 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Code;
using NFine.Domain.Entity.Hrm;
using NFine.Domain.IRepository.Hrm;
using NFine.Repository.Hrm;
using System;
using System.Collections.Generic;
using System.Linq;
namespace NFine.Application.Hrm
{
    public class HrmUserApp
    {
		private IHrmUserRepository service = new HrmUserRepository();

		public List<HrmUserEntity> GetList(Pagination pagination, System.Linq.Expressions.Expression<Func<HrmUserEntity,bool>> expression)
        {

		    //var expression = ExtLinq.True<HrmUserEntity>();
           
           
            return service.FindList(expression, pagination);
        }

	    public HrmUserEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        public void Delete(HrmUserEntity entity)
        {
            service.Delete(entity);
        }

		public void SubmitForm(HrmUserEntity entity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                entity.Modify(keyValue);
                service.Update(entity);
            }
            else
            {
                entity.Create();
                service.Insert(entity);
            }
        }
    }
}