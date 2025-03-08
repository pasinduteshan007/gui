using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AutoCarePro
{
    
    public partial class AvilabletimeSlotes : Window
    {
        public AvilabletimeSlotes(List<TimeSlot> availableSlots)
        {
            InitializeComponent();
           LoadData();
        }

        private ProductDbContext _db = new ProductDbContext();

        private void LoadData()
        {
            ProductGrid.ItemsSource = _db.Products.ToList();
        }

        private void Add_Product(object sender, RoutedEventArgs e)
        {
            if (ProductGrid.SelectedItem is Product selectedBook)
            {
                DialogBox dialog = new DialogBox(selectedBook);
                if (dialog.ShowDialog() == true)
                {
                   
                    selectedBook.IssueType = dialog.IssueType;
                    selectedBook.vehicalbrand = dialog.vehicalbrand;
                    selectedBook.branch = dialog.branch;

                    _db.SaveChanges();
                    LoadData();
                }
            }
            else
            {
                
                DialogBox dialog = new DialogBox();
                if (dialog.ShowDialog() == true)
                {
                    Product newBook = new Product
                    {
                        IssueType = dialog.IssueType,
                        vehicalbrand = dialog.vehicalbrand,
                        branch = dialog.branch
                    };

                    _db.Products.Add(newBook);
                    _db.SaveChanges();
                    LoadData();
                }
            }
        }

        private void Delete_Product(object sender, RoutedEventArgs e)
        {
            if (ProductGrid.SelectedItem is Product p)
            {
                _db.Products.Remove(p);
                _db.SaveChanges();
                LoadData();
            }
        }
    }
}
