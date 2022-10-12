using System.ComponentModel.DataAnnotations;

namespace AssemblyLine_Blazor.Data
{
    public class Operation
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        [Range(0, 1000,
            ErrorMessage = "Value For {0} must be netween {1} and {2}")]
        public int OrderInWhichToPerform { get; set; }        
        public byte[] ImageData { get; set; }
        public Device Device { get; set; }
        public Guid ? DeviceId { get; set; }
    }
}
