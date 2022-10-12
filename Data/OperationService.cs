using AssemblyLine_Blazor.Pages;
using BootstrapBlazor.Components;



namespace AssemblyLine_Blazor.Data
{
    public class OperationService : IOperationService
    {
        
        public List<Operation> Operations { get; set; } = new List<Operation>();
        public List<Device> Device { get; set ; } = new List<Device>();

        //public List<Device> Devices = new List<Device>()
        //{
        //    new Device
        //    {
        //        Id = Guid.NewGuid(),
        //        Name = "Barcode Scanner",
        //        DeviceType = DeviceType.BarcodeScanner
        //    },
        //    new Device
        //    {
        //        Id = Guid.NewGuid(),
        //        Name = "Printer",
        //        DeviceType = DeviceType.Printer
        //    }
        //};        


        //private readonly List<Operation> operations = new List<Operation>
        //{
        //    new Operation()
        //    {
        //        Id = Guid.NewGuid(),
        //        Name = "TEST 1",
        //        OrderInWhichToPerform = 1,
        //        //DeviceId = 


        //    },
        //    new Operation
        //    {
        //        Id = Guid.NewGuid(),
        //        Name = "Test 2",
        //        OrderInWhichToPerform = 2
        //    }
        //};

        public List<Operation> ListOperations()
        {
            return Operations;
        }

        public Operation GetOperation(Guid Id)
        {
            return Operations.SingleOrDefault(o => o.Id == Id);
        }
        public void UpdateOperation(Operation operation)
        {
            var getOldOpertion = GetOperation(operation.Id);
            getOldOpertion.Name = operation.Name;
            getOldOpertion.OrderInWhichToPerform = operation.OrderInWhichToPerform;
            getOldOpertion.ImageData = operation.ImageData;
            getOldOpertion.Device = operation.Device;
            
        }

        public void AddOperation(Operation operation)
        {
            var id = Guid.NewGuid();

            operation.Id = id;
            operation.Name = operation.Name;
            operation.OrderInWhichToPerform = operation.OrderInWhichToPerform;
            operation.ImageData = operation.ImageData;
            operation.Device = operation.Device;
            Operations.Add(operation);
        }

        public void DeleteOperation(Guid Id)
        {
            var operation = GetOperation(Id);
            Operations.Remove(operation);
        }
        //public Operation GetOperations(Operations Operations)
        //{
        //    return Operations;
        //}

        public void AddDevice(Device device)
        {
            var id = Guid.NewGuid();
            device.Id = id;
            device.Name = device.Name;
            device.DeviceType = device.DeviceType;
            Device.Add(device);
        }

        public void DeleteDevice(Guid Id)
        {
            var device = GetDevice(Id);
            Device.Remove(device);
        }

        public Device GetDevice(Guid Id)
        {
            return Device.SingleOrDefault(o => o.Id == Id);
        }

        public List<Device> ListDevices()
        {
            return Device;
        }

        public void UpdateDevice(Device device)
        {
            var getOldDevice = GetDevice(device.Id);
            getOldDevice.Name = device.Name;
            getOldDevice.DeviceType = device.DeviceType;

        }

        
    }
}
