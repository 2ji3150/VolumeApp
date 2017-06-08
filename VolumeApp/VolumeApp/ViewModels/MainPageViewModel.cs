using Prism.Commands;
using Prism.Mvvm;

namespace VolumeApp.ViewModels {
    public class MainPageViewModel : BindableBase {
        private int count = 0;
        public int Count { get => count; set => SetProperty(ref count, value); }

        // ButtonのCommandにバインドします。
        private DelegateCommand _addCommand, _minusCommand;
        public DelegateCommand AddCommand => _addCommand = _addCommand ?? new DelegateCommand(AddCommandExecute);
        public DelegateCommand MinusCommand => _minusCommand = _minusCommand ?? new DelegateCommand(MinusCommandExecute);
        public void AddCommandExecute() => Count++;
        public void MinusCommandExecute() => Count--;



    }
}
