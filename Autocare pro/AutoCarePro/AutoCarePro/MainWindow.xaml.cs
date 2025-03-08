
using System.Windows;
using System.Windows.Controls;


namespace AutoCarePro
{
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void NavigationButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                switch (button.Tag?.ToString())
                {
                    case "login":
                        var loginPage = new LoginPage();
                        loginPage.Show();
                        this.Close();
                        break;

                    case "register":
                        var signUpPage = new signuppage();
                        signUpPage.Show();
                        this.Close();
                        break;

                    case "about":
                        var aboutPage = new about();
                        aboutPage.Show();
                        break;

                    default:
                        MessageBox.Show($"Navigation to {button.Tag} is not implemented.", "Navigation", MessageBoxButton.OK, MessageBoxImage.Information);
                        break;
                }
            }
            else
            {
                MessageBox.Show("The clicked element is not a button.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CheckGarageAvailabilityButton_Click(object sender, RoutedEventArgs e)
        {
            var checkInDate = GarageCheckInDatePicker.SelectedDate;
            var selectedVehicleType = (GarageVehicleTypeComboBox.SelectedItem as ComboBoxItem)?.Content?.ToString();

            if (checkInDate == null || string.IsNullOrEmpty(selectedVehicleType))
            {
                MessageBox.Show("Please fill in all fields before checking availability.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            string date = checkInDate.Value.ToString("yyyy-MM-dd");

            
            List<TimeSlot> availableSlots = GetAvailableSlots("Garage", selectedVehicleType, date);

           
            var availableTimeSlotsWindow = new AvilabletimeSlotes(availableSlots);
            availableTimeSlotsWindow.Show();  
        }

        private void CheckCarWashAvailabilityButton_Click(object sender, RoutedEventArgs e)
        {
            var checkInDate = CarWashCheckInDatePicker.SelectedDate;
            var selectedVehicleType = (CarWashVehicleTypeComboBox.SelectedItem as ComboBoxItem)?.Content?.ToString();

            if (checkInDate == null || string.IsNullOrEmpty(selectedVehicleType))
            {
                MessageBox.Show("Please fill in all fields before checking availability.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            string date = checkInDate.Value.ToString("yyyy-MM-dd");

           
            List<TimeSlot> availableSlots = GetAvailableSlots("CarWash", selectedVehicleType, date);

            
            var availableTimeSlotsWindow = new AvilabletimeSlotes(availableSlots);
            availableTimeSlotsWindow.Show();  
        }



        private List<TimeSlot> GetAvailableSlots(string serviceType, string vehicleType, string date)
        {
            
            var slots = new List<TimeSlot>
            {
                new TimeSlot
                {
                    SlotId = "1",
                    Date = date,
                    StartTime = "09:00",
                    EndTime = "10:00",
                    Availability = "Available"
                },
                new TimeSlot
                {
                    SlotId = "2",
                    Date = date,
                    StartTime = "10:00",
                    EndTime = "11:00",
                    Availability = "Available"
                }
            };

            return slots;

        }
    }
 

   
    public class TimeSlot
    {
        public string? SlotId { get; set; }
        public string? Date { get; set; }
        public string? StartTime { get; set; }
        public string? EndTime { get; set; }
        public string? Availability { get; set; }
    }
}
