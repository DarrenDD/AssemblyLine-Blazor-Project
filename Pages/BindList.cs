using AssemblyLine_Blazor.Data;
using Microsoft.AspNetCore.Components;

namespace AssemblyLine_Blazor.Pages
{
    public class BindList : ComponentBase
    {
        public List<Device> Devices { get; set; }
        public string Id = string.Empty;

        protected override Task OnInitializedAsync()
        {
            
            return base.OnInitializedAsync();
        }
    }
}
