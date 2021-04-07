using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace InventoryManagementSystem.Model
{
    class Product : INotifyPropertyChanged
    {

        private string _ID;
        private string _Name;
        private int _Quantity;
        private string _PurchaseDate;

        public Product(string ID, string Name, int Quantity, string PurchaseDate)
        {
            _ID = ID;
            _Name = Name;
            _Quantity = Quantity;
            _PurchaseDate = PurchaseDate;
        }

        public override string ToString()
        {
            return _Name;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChangeEvent(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public override bool Equals(object other)
        {
            if(!(other is Product product))
            {
                return false;
            }
            return this.ID.Equals(product.ID);
        }

        public override int GetHashCode()
        {
            return this.ID.GetHashCode();
        }

        #region Properties Getters and Setters
        public string ID
        {
            get { return _ID; }
            set
            {
                _ID = value;
                RaisePropertyChangeEvent("ID");
            }
        }

        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                RaisePropertyChangeEvent("Name");
            }
        }

        public int Quantity
        {
            get { return _Quantity; }
            set
            {   
                if(value < 0)
                {
                    throw new ArgumentException("Quantity must be a positive value");
                }
                _Quantity = value;
                RaisePropertyChangeEvent("Quantity");
            }
        }

        public string PurchaseDate
        {
            get { return _PurchaseDate; }
            set
            {
                _PurchaseDate = value;
                RaisePropertyChangeEvent("PurchaseDate");
            }
        }

        #endregion
    }
}