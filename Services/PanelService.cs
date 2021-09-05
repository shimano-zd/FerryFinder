using System;
using System.Collections.Generic;


namespace FerryFinder.Services
{
    public class PanelService
    {
        private bool PanelOpened { get; set; }

        public Action<Type, Dictionary<string, object>> OnPanelOpened;
        public Action OnPanelClosed;
        public void ShowPanel(Type componentType, Dictionary<string, object> activationParameters)
        {
            if (PanelOpened)
                return;

            PanelOpened = true;
            OnPanelOpened.Invoke(componentType, activationParameters);
        }

        public void ClosePanel()
        {
            if (!PanelOpened)
                return;

            PanelOpened = false;
            OnPanelClosed.Invoke();
        }
    }
}
