#nullable disable
using Maskinpark.Core;
using Microsoft.AspNetCore.Components;

namespace Maskinpark.Pages;

public partial class DeviceDetail
{
    [Parameter]
    public string DeviceId { get; set; }
    public Device Device { get; set; }
    private ICollection<Device> Devices { get; set; }

    protected override Task OnInitializedAsync()
    {
        InitializeDevice();
        Device = Devices.FirstOrDefault(device => device.Id == int.Parse(DeviceId));
        return base.OnInitializedAsync();
    }

    private void InitializeDevice()
    {
        this.Devices = new List<Device>();
        for (int i = 1; i <= 10; i++)
        {
            Devices.Add(new Device()
            {
                Id = i,
                Status = Status.Offline,
                UpdateDateTime = DateTime.Now,
            });
        }
    }

}
