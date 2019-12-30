using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace HexToASCIITool.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        /// 
        private string notifyMsg;

        public string NotifyMsg
        {
            get { return notifyMsg; }
            set { notifyMsg = value; RaisePropertyChanged(() => NotifyMsg); }
        }

        private string inputStr;

        public string InputStr
        {
            get { return inputStr; }
            set { inputStr = value; RaisePropertyChanged(() => InputStr); }
        }

        private string debugMsg;

        public string DebugMsg
        {
            get { return debugMsg; }
            set { debugMsg = value; RaisePropertyChanged(() => DebugMsg); }
        }

        private RelayCommand clearMsgCmd;

        public RelayCommand ClearMsgCmd
        {
            get { return clearMsgCmd; }
            set { clearMsgCmd = value; RaisePropertyChanged(() => ClearMsgCmd); }
        }
        
        private void ClearMsgFunc()
        {
            DebugMsg = "";
        }

        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
            NotifyMsg = "Example: 0x47 0x4b or 47 4b or 0x47,0x4b or 47,4b\nHex number only.";
            DebugMsg = "";

            InputStr = "";

            ClearMsgCmd = new RelayCommand(ClearMsgFunc);
        }
    }
}