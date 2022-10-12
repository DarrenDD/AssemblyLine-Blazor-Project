namespace AssemblyLine_Blazor.Data
{
    public interface IOperationService
    {
        List<Operation> Operations { get; set; }
        List<Operation> ListOperations();   
        List<Device> Device { get; set; }
        //Operation GetOperations();
        Operation GetOperation(Guid Id);        

        void UpdateOperation(Operation operation);

        void AddOperation(Operation operation);

        void DeleteOperation(Guid Id);

        List<Device> ListDevices();
        void AddDevice(Device device);
        void UpdateDevice(Device device);
        Device GetDevice(Guid Id);
        void DeleteDevice(Guid Id);

    }
}
