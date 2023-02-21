﻿using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel.Station.Blazor.Shared
{
    public class ItemListDto
    {
        public int Id { get; set; }

        public string? Code { get; set; }

        public string? Description { get; set; }

        public ItemType itemType { get; set; }

        public decimal Price { get; set; }

        public decimal Cost { get; set; }
    }
}
