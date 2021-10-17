using ClassLibrary;
using System.Collections.Generic;
using System.Windows;

namespace WE02_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<Account> accounts;
        private Account activeAccount;
        private List<Client> clients;

        public MainWindow()
        {
            InitializeComponent();
            clients = new List<Client> {
                new Client("Bart", "Tassignon"),
                new Client("Liesbet", "Merens")
            };
            accounts = new List<Account>();
            accounts.Add(new RegularAccount("BE12 3456 7898 7456", 0, new System.DateTime(2000, 3, 11), 0.2m, clients[0]));

            activeAccount = accounts[0];


        }

        private void UpdateGUI()
        {
            LblAccountType.Content = activeAccount.AccountType;
            LblBalance.Content = activeAccount.Balance.ToString("C");
            LblCreationDate.Content = activeAccount.CreationDate.ToString("dd MMM yyyy");
            LblIban.Content = activeAccount.IBAN;
            LblInterest.Content = activeAccount.Interest;
        }

        private void BtnDeposit_Click(object sender, RoutedEventArgs e)
        {
            string value = TxtAmount.Text;
            decimal resultaat;

            if (decimal.TryParse(value, out resultaat))
            {
                activeAccount.Deposit(resultaat);
            }
            else
            {
                MessageBox.Show("Please input a valid number!");
            }
            UpdateGUI();
        }

        private void BtnWithdraw_Click(object sender, RoutedEventArgs e)
        {
            string value = TxtAmount.Text;
            decimal resultaat;

            if (decimal.TryParse(value, out resultaat))
            {
                activeAccount.Withdraw(resultaat);
            }
            else
            {
                MessageBox.Show("Please input a valid number!");
            }
            UpdateGUI();
        }
    }
}
