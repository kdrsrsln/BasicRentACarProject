using System;
using System.Collections.Generic;
using System.Text;
using Core.Entity;

namespace Entities.Dtos
{
    public class CarDetailDto : IDto
    {
        public string BrandName { get; set; }
        public string Model { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
