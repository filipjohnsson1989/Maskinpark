#nullable disable
using Maskinpark.Core;

namespace Maskinpark.Pages;

public partial class DeviceOverview
{
    public ICollection<Device> Devices { get; set; }

    protected override Task OnInitializedAsync()
    {
        InitializeDevice();

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
