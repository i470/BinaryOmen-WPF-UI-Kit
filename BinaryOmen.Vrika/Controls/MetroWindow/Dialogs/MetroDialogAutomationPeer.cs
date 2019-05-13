using System.Windows.Automation.Peers;

namespace BinaryOmen.Vrika.Wpf.Dialogs
{
    public class MetroDialogAutomationPeer : FrameworkElementAutomationPeer
    {
        public MetroDialogAutomationPeer(BaseMetroDialog owner)
            : base(owner)
        {
        }

        protected override string GetClassNameCore()
        {
            return this.Owner.GetType().Name;
        }

        protected override AutomationControlType GetAutomationControlTypeCore()
        {
            return AutomationControlType.Custom;
        }

        protected override string GetNameCore()
        {
            string nameCore = base.GetNameCore();
            if (string.IsNullOrEmpty(nameCore))
            {
                nameCore = ((BaseMetroDialog)this.Owner).Title;
            }

            if (string.IsNullOrEmpty(nameCore))
            {
                nameCore = ((BaseMetroDialog)this.Owner).Name;
            }

            if (string.IsNullOrEmpty(nameCore))
            {
                nameCore = GetClassNameCore();
            }

            return nameCore;
        }
    }
}