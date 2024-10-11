using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public interface ITovar
{
    string GetName(); // Метод для получения имени товара
    decimal GetPrice();// Метод для получения стоимости товара
    int GetStock(); // Метод для получения остатка на складе
    void Restock(int quantity); // Метод для добавления товара на склад
    void Sell(int quantity); // Метод для продажи товара
}

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private List<ITovar> tovarList = new List<ITovar>();

        public Form1()
        {
            InitializeComponent();
            UpdateProductList();
        }

        private void UpdateProductList()
        {
            listBoxProducts.Items.Clear();
            foreach (var tovar in tovarList)
            {
                listBoxProducts.Items.Add($"{tovar.GetName()} - Цена: {tovar.GetPrice()} руб. Остаток: {tovar.GetStock()}");
            }
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxName.Text;
                decimal price = decimal.Parse(textBoxPrice.Text);
                int stock = int.Parse(textBoxStock.Text);

                if (comboBoxProductType.SelectedItem.ToString() == "Штучный товар")
                {
                    Product product = new Product(name, price, stock);
                    tovarList.Add(product);
                }
                else if (comboBoxProductType.SelectedItem.ToString() == "Весовой товар")
                {
                    WeightedProduct product = new WeightedProduct(name, price, stock / 1000.0m);
                    tovarList.Add(product);
                }

                UpdateProductList();
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении товара: " + ex.Message);
            }
        }

        private void buttonSellProduct_Click(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedIndex != -1)
            {
                var selectedProduct = tovarList[listBoxProducts.SelectedIndex];

                try
                {
                    int quantity = int.Parse(textBoxSellQuantity.Text);
                    selectedProduct.Sell(quantity);
                    UpdateProductList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при продаже товара: " + ex.Message);
                }
            }
        }

        private void ClearInputFields()
        {
            textBoxName.Clear();
            textBoxPrice.Clear();
            textBoxStock.Clear();
            textBoxSellQuantity.Clear();
        }
    }
}