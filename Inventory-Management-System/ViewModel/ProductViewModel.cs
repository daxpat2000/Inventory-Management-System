using InventoryManagementSystem.Common;
using InventoryManagementSystem.Model;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace InventoryManagementSystem.ViewModel
{
    class ProductViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Product> _Inventory;
        private Product _Product;
        private Product _SelectedProduct;
        private RelayCommand _AddCommand;
        private RelayCommand _DeleteCommand;
        private RelayCommand _UpdateCommand;

        public event PropertyChangedEventHandler PropertyChanged;

        public ProductViewModel()
        {
            _Inventory = new ObservableCollection<Product>();
            _AddCommand = new RelayCommand(ExecuteAddProduct, CanAddProduct);
            _DeleteCommand = new RelayCommand(ExecuteDeleteCommand, CanDeleteExecute);
            _UpdateCommand = new RelayCommand(ExecuteUpdateCommand, CanUpdateExecute);
            _Product = new Product("", "", 0, DateTime.Now.ToShortDateString());
            _SelectedProduct = new Product("", "", 0, DateTime.Now.ToShortDateString());
        }

        private void RaisePropertyChangeEvent(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public Product Product
        {
            get { return _Product; }
            set
            {
                _Product = value;
                RaisePropertyChangeEvent("Product");
            }
        }

        public Product SelectedProduct
        {
            get { return _SelectedProduct; }
            set
            {
                _SelectedProduct = value;
                Product = value;
                RaisePropertyChangeEvent("SelectedProduct");
                RaisePropertyChangeEvent("Product");
            }
        }

        public ObservableCollection<Product> Inventory
        {
            get { return _Inventory; }
            set
            {
                _Inventory = value;
                RaisePropertyChangeEvent("Inventory");
            }
        }

        public RelayCommand AddCommand
        {
            get { return _AddCommand; }
            set
            {
                _AddCommand = value;
                RaisePropertyChangeEvent("AddCommand");
            }
        }

        private void ExecuteAddProduct(object sender)
        {
            _Inventory.Add(_Product);
            Product = new Product("", "", 0, DateTime.Now.ToShortDateString());
        }

        private bool CanAddProduct(object sender)
        {
            return !Inventory.Contains(_Product);
        }


        public RelayCommand DeleteCommand
        {
            get { return _DeleteCommand; }
            set
            {
                _DeleteCommand = value;
                RaisePropertyChangeEvent("DeleteProduct");
            }
        }

        private void ExecuteDeleteCommand(object sender)
        {
            _Inventory.Remove(_Product);
            Product = new Product("", "", 0, DateTime.Now.ToShortDateString());
        }

        private bool CanDeleteExecute(object sender)
        {
            return _Inventory.Contains(_Product);
        }

        public RelayCommand UpdateCommand
        {
            get { return _UpdateCommand; }
            set
            {
                _UpdateCommand = value;
            }
        }

        private void ExecuteUpdateCommand(object sender)
        {
            _Inventory[_Inventory.IndexOf(_Product)] = _Product;
            Product = new Product("", "", 0, DateTime.Now.ToShortDateString());
        }

        private bool CanUpdateExecute(object sender)
        {
            return _Inventory.Contains(_Product);
        }

        private void ResetProduct()
        {
            _Product.ID = _Product.Name = "";
            _Product.Quantity = 0;
            _Product.PurchaseDate = DateTime.Now.ToShortDateString();
        }
    }
}
