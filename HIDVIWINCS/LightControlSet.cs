namespace HIDVIWINCS
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public class LightControlSet
    {
        private readonly Button _onButton;
        private readonly Button _offButton;
        private readonly Button _flashButton;

        private readonly TextBox _onDutyValue;
        private readonly TextBox _offDutyValue;
        private readonly TextBox _offsetValue;
        private readonly TextBox _powerValue;
        private readonly Button _applyButton;

        public LightControlSet(Button onButton, Button offButton, Button flashButton, TextBox onDutyValue, TextBox offDutyValue, TextBox offsetValue, TextBox powerValue, Button applyButton)
        {
            _onButton = onButton;
            _offButton = offButton;
            _flashButton = flashButton;
            _onDutyValue = onDutyValue;
            _offDutyValue = offDutyValue;
            _offsetValue = offsetValue;
            _powerValue = powerValue;
            _applyButton = applyButton;
        }

        public Button OnButton
        {
            get { return _onButton; }
        }

        public Button OffButton
        {
            get { return _offButton; }
        }

        public Button FlashButton
        {
            get { return _flashButton; }
        }

        public TextBox OnDutyValue
        {
            get { return _onDutyValue; }
        }

        public TextBox OffDutyValue
        {
            get { return _offDutyValue; }
        }

        public TextBox OffsetValue
        {
            get { return _offsetValue; }
        }

        public TextBox PowerValue
        {
            get { return _powerValue; }
        }

        public Button ApplyButton
        {
            get { return _applyButton; }
        }

        public void SetState(LightState state)
        {
            OnButton.Invoke((Action) (() =>
            {
                OnButton.Font = new Font(OnButton.Font, FontStyle.Regular);
                OffButton.Font = new Font(OffButton.Font, FontStyle.Regular);
                FlashButton.Font = new Font(FlashButton.Font, FontStyle.Regular);
                switch (state)
                {
                    case LightState.Off:
                        OffButton.Font = new Font(OffButton.Font, FontStyle.Bold);
                        OffButton.PerformClick();
                        break;
                    case LightState.On:
                        OnButton.Font = new Font(OnButton.Font, FontStyle.Bold);
                        OnButton.PerformClick();
                        break;
                    case LightState.Flash:
                        FlashButton.Font = new Font(FlashButton.Font, FontStyle.Bold);
                        FlashButton.PerformClick();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("state");
                }
            }));
        }

        public LightState GetState()
        {
            if (OnButton.Font.Bold)
            {
                return LightState.On;
            }

            if (OffButton.Font.Bold)
            {
                return LightState.Off;
            }

            if (FlashButton.Font.Bold)
            {
                return LightState.Flash;
            }

            OffButton.Invoke((Action) (() =>
            {
                OffButton.Font = new Font(OffButton.Font, FontStyle.Bold);
            }));
            return LightState.Off;
        }
    }
}