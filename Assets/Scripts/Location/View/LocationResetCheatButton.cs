using Core;

namespace Location.View
{
    public class LocationResetCheatButton : CheatButton
    {
        protected override void OnButtonClicked()
        {
            LocationManager.Instance.Reset();
        }
    }
}