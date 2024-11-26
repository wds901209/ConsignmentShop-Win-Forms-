using System;
using System.Windows.Forms;
using ConsignmentShopLibray;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsignmentShopUI
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store();
        private List<Item> shoppingCartData = new List<Item>();
        BindingSource itemsBinding = new BindingSource();   //連結UI與後端
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorsBinding = new BindingSource();
        private decimal storeProfit = 0;

        public ConsignmentShop()
        {
            InitializeComponent();
            SetupData();

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList(); //即只return還沒賣出的
            itemsListBox.DataSource = itemsBinding; //將 BindingSource 繫結到 ListBox(UI)
            itemsListBox.DisplayMember = "Display";
            //itemsListBox.ValueMember = "Display";

            cartBinding.DataSource = shoppingCartData;
            ShoppingCartListBox.DataSource = cartBinding;
            ShoppingCartListBox.DisplayMember = "Display";
            //ShoppingCartListBox.ValueMember = "Display";

            vendorsBinding.DataSource = store.Vendors;
            vendorlistBox.DataSource = vendorsBinding;
            vendorlistBox.DisplayMember = "Display";
        }

        private void SetupData()
        {
            //Vendor vendor = new Vendor();
            //vendor.FirstName = "王";
            //vendor.LastName = "東森";
            //vendor.Commision = 0.5;

            //store.Vendors = new List<Vendor>(); 這個應該在Store.cs實例
            store.Vendors.Add(new Vendor
            {
                FirstName = "Bill",
                LastName = "Smith",
            });
            store.Vendors.Add(new Vendor
            {
                FirstName = "Sue",
                LastName = "Jones",
            });


            store.Items.Add(new Item
            {
                Title = "Moby Dick",
                Description = "A book about a whale",
                Price = 4.50m,
                //Sold = false,
                //PaymentDistributed = false,
                Owner = store.Vendors[0]
            });
            store.Items.Add(new Item
            {
                Title = "A Tale of Two Cities",
                Description = "A book about a revolution",
                Price = 3.80m,
                Owner = store.Vendors[0]
            });
            store.Items.Add(new Item
            {
                Title = "Harry Potter Book 1",
                Description = "A book about a boy",
                Price = 5.20m,
                Owner = store.Vendors[1]
            });
            store.Items.Add(new Item
            {
                Title = "Jane Eyre",
                Description = "A book about a girl",
                Price = 1.50m,
                Owner = store.Vendors[0]
            });


            store.Name = "王呱呱";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            // Figure out what is selected from the items list
            // Copy that item to the shopping cart
            // Do we remove the item from the items list? - no
            // MessageBox.Show("I have been clicked");
            Item selectedItem = (Item)itemsListBox.SelectedItem;
            MessageBox.Show(selectedItem.Title);

            shoppingCartData.Add(selectedItem);
            cartBinding.ResetBindings(false);
        }

        private void ConsignmentShop_Load(object sender, EventArgs e)
        {

        }

        private void make_Purchase_Click(object sender, EventArgs e)
        {
            // Mark each item in the cart as sold
            // Clear the cart

            foreach(Item item in shoppingCartData)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal)item.Owner.Commision * item.Price;
                storeProfit += (1 - (decimal)item.Owner.Commision) * item.Price;
            }

            shoppingCartData.Clear();

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();

            StoreProfitValue.Text = string.Format("${0}", storeProfit);

            cartBinding.ResetBindings(false);         
            itemsBinding.ResetBindings(false);
            vendorsBinding.ResetBindings(false);
        }
    }
}
