﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>

    {
        private List<global::Entities.Concrete.Product> maintenanceTime;
        private List<global::Entities.DTOs.ProductDetailDto> maintenanceTime1;

        public ErrorDataResult(T data, string message) : base(data, false, message)
        {


        }
        public ErrorDataResult(T data) : base(data, false)
        {


        }

        public ErrorDataResult(string message) : base(default, false, message)
        {


        }
        public ErrorDataResult() : base(default, false)
        {


        }

        public ErrorDataResult(List<global::Entities.Concrete.Product> maintenanceTime)
        {
            this.maintenanceTime = maintenanceTime;
        }

        public ErrorDataResult(List<global::Entities.DTOs.ProductDetailDto> maintenanceTime1)
        {
            this.maintenanceTime1 = maintenanceTime1;
        }
    }



}
