﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Domain.Interfaces
{
    public interface IRepairService
    {
        void CheckVehicle();
        void FixVehicle();
    }
}
