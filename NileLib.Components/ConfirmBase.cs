using Microsoft.AspNetCore.Components;

namespace NileLib.Components
{
    public class ConfirmBase : ComponentBase
    {
        protected bool ShowConfirmation { get; set; }
        public void Show()
        {
            ShowConfirmation = true;
            StateHasChanged();
        }
        [Parameter]
        public EventCallback<bool> ConfirmationChanged { get; set; }
        // 01022483151
        //fiverr @_Maxo.3
    }
}