using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie1
{
    public partial class Form1 : Form
    {
        private List<Object> createdToys = new List<Object>();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) { }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            switch (listOfToys.GetItemText(listOfToys.SelectedItem))
            {
                case "Car":
                    Car car = new Car();
                    createdToys.Add(car);
                    listOfCreated.Items.Add(car.ToString());
                    break;
                case "Plane":
                    Plane plane = new Plane();
                    createdToys.Add(plane);
                    listOfCreated.Items.Add(plane.ToString());
                    break;
                case "Submarine":
                    Submarine submarine = new Submarine();
                    createdToys.Add(submarine);
                    listOfCreated.Items.Add(submarine.ToString());
                    break;
                case "Computer":
                    Computer computer = new Computer();
                    createdToys.Add(computer);
                    listOfCreated.Items.Add(computer.ToString());
                    break;
                default:
                    break;
            }

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Object toy = findToyObject();
            createdToys.Remove(toy);
            listOfCreated.Items.Remove(listOfCreated.SelectedItem);
        }

        private void listOfCreated_Click(object sender, EventArgs e)
        {

            Object toy = findToyObject();
            heightBox.Hide();
            depthBox.Hide();
            speedBox.Hide();

            if (toy is ISpeed)
            {
                speedBox.Show();
                updateSpeedText();
            }
            if (toy is IDive)
            {
                depthBox.Show();
                updateDepthText();
            }

            if (toy is IRise)
            {
                heightBox.Show();
                updateHeightText();
            }

        }

        private void plusSpeed_Click(object sender, EventArgs e)
        {
            Object toy = findToyObject();
            ((ISpeed)toy).increaseSpeed(1);
            updateSpeedText();
        }

        private void minusSpeed_Click(object sender, EventArgs e)
        {
            Object toy = findToyObject();
            ((ISpeed)toy).decreaseSpeed(1);
            updateSpeedText();
        }

        private void depthPlus_Click(object sender, EventArgs e)
        {
            Object toy = findToyObject();
            ((IDive)toy).increaseDepth(1);
            updateDepthText();
        }

        private void depthMinus_Click(object sender, EventArgs e)
        {
            Object toy = findToyObject();
            ((IDive)toy).decreaseDepth(1);
            updateDepthText();
        }

        private void heightPlus_Click(object sender, EventArgs e)
        {
            Object toy = findToyObject();
            ((IRise)toy).increaseHight(1);
            updateHeightText();
        }


        private void heightMinus_Click(object sender, EventArgs e)
        {
            Object toy = findToyObject();
            ((IRise)toy).decreaseHight(1);
            updateHeightText();
        }

        private void updateSpeedText()
        {
            Object toy = findToyObject();
            textSpeed.Text = ((ISpeed)toy).getSpeed().ToString();
        }

        private void updateDepthText()
        {
            Object toy = findToyObject();
            textDepth.Text = ((IDive)toy).getDepth().ToString();
        }


        private void updateHeightText()
        {
            Object toy = findToyObject();
            textHeight.Text = ((IRise)toy).getHight().ToString();
        }


        private object findToyObject()
        {
            Object toy = null;
            String toyName = listOfCreated.SelectedItem.ToString();

            foreach (var item in createdToys)
            {
                if (item.ToString() == toyName)
                {
                    toy = item;
                    break;
                }
            }
            return toy;
        }

    }
}
