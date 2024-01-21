using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlateSerials.Dtos
{
    public class ClockingPlateSerialResponseDto
    {
        public ClockingPlateSerialDataResponseDto Data{ get; set; }
    }
    public class ClockingPlateSerialDataResponseDto
    {
        public string Date { get; set; }
        public string PersonFullName { get; set; }
        public string PlateNumber { get; set; }
    }
}
