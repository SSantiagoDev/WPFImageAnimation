using Prism.Commands;
using Prism.Mvvm;

namespace ImageAnimation
{
    public class MainWindowVM: BindableBase
    {
        #region  Properties

        private string _status;
        public string Status
        {
            get { return _status; }
            set { SetProperty(ref _status, value); }
        }

        #endregion

        #region Commands

        private DelegateCommand _startCommand;
        public DelegateCommand StartCommand =>
            _startCommand ?? (_startCommand = new DelegateCommand(Start));

        private DelegateCommand _stopCommand;
        public DelegateCommand StopCommand =>
            _stopCommand ?? (_stopCommand = new DelegateCommand(Stop));

        #endregion

        public MainWindowVM()
        {
            this.Status = "Not started yet";
        }

        private void Start()
        {
            this.Status = "Running";
        }

        private void Stop()
        {
            this.Status = "Stopped";
        }
    }
}
