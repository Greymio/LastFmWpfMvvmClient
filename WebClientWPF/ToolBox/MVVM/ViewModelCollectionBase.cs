using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox.MVVM
{
    public abstract class ViewModelCollectionBase<T> : ViewModelBase
        where T : class
    {
        private ObservableCollection<T> _items = null;
        private T _selectedItem = null;

        public ObservableCollection<T> Items
        {
            get
            {
                return _items ?? LoadItems();
            }
        }

        public T SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                if (_selectedItem != value)
                {
                    _selectedItem = value;
                    RaisePropertyChanged(nameof(SelectedItem));
                }
            }
        }

        protected abstract ObservableCollection<T> LoadItems();

        protected ViewModelCollectionBase()
        {
            this.PropertyChanged += (sender, args) =>
            {
                if (args.PropertyName == nameof(Items))
                {
                    _items = LoadItems();
                }
            };
        }
    }
}
