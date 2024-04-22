using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inherit7
{
    public partial class Form1 : Form
    {
        private List<Room> rooms = new List<Room>();

        public Form1()
        {
            InitializeComponent();
            radioButton1.CheckedChanged += radioButton_CheckedChanged;
            radioButton2.CheckedChanged += radioButton_CheckedChanged;
            radioButton3.CheckedChanged += radioButton_CheckedChanged;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double area, price;
            int floorOrNumberOfFloors = 0; // Ініціалізуємо змінну

            if (!double.TryParse(textBox1.Text, out area) || !double.TryParse(textBox2.Text, out price))
            {
                MessageBox.Show("Будь ласка, введіть коректні значення для площі та ціни.");
                return;
            }

            if (radioButton1.Checked) // Вибрано тип "Будинок"
            {
                if (!int.TryParse(textBox3.Text, out floorOrNumberOfFloors))
                {
                    MessageBox.Show("Будь ласка, введіть коректну кількість поверхів.");
                    return;
                }
                rooms.Add(new House(area, price, floorOrNumberOfFloors));
            }
            else if (radioButton2.Checked) // Вибрано тип "Нежитлова будівля"
            {
                if (!int.TryParse(textBox3.Text, out floorOrNumberOfFloors))
                {
                    MessageBox.Show("Будь ласка, введіть коректну висоту.");
                    return;
                }
                rooms.Add(new NonResidentialBuilding(area, price, floorOrNumberOfFloors));
            }
            else if (radioButton3.Checked) // Вибрано тип "Квартира"
            {
                if (!int.TryParse(textBox3.Text, out floorOrNumberOfFloors))
                {
                    MessageBox.Show("Будь ласка, введіть коректний номер поверху.");
                    return;
                }
                rooms.Add(new Apartment(area, price, floorOrNumberOfFloors));
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть тип кімнати.");
            }

            Debug.WriteLine($"Площа: {area}, Ціна: {price}, Поверх/Кількість поверхів: {floorOrNumberOfFloors}");

            List<string> roomInfoList = new List<string>();
            foreach (var room in rooms)
            {
                roomInfoList.Add($"Площа: {room.Area}, Ціна: {room.Price}");
            }

            listBox1.DataSource = roomInfoList;
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton != null)
            {
                if (radioButton.Checked)
                {
                    Debug.WriteLine($"RadioButton {radioButton.Text} checked.");
                }
            }
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

   



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            // Перебираем каждое помещение в списке и вызываем метод Repair
            for (int i = 0; i < rooms.Count; i++)
            {
                var room = rooms[i];
                room.Repair();
                Debug.WriteLine($"Ремонт помещения выполнен. Новая цена: {room.Price}");

                // Обновляем только соответствующий элемент в listBox1
                string roomInfo = $"Площа: {room.Area}, Ціна: {room.Price}";
                listBox1.Items[i] = roomInfo;
            }

            // После обновления всех элементов, восстанавливаем связь с DataSource
            listBox1.DataSource = null;
        }






    }
}