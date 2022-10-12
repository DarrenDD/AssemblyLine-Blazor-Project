namespace AssemblyLine_Blazor.Data
{
    public class Device
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public DeviceType DeviceType { get; set; }
    }
    public enum DeviceType
    {
        BarcodeScanner = 0,
        Printer = 1,
        Camera = 2,
        SocketTray = 3
    }
}
