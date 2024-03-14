using Problem_plecakowy;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Graficzny_Interfejs_Uzytkownika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Number, Seed, Capacity;

        string message = "Enter parameters:" + Environment.NewLine +
                 "Number of items from 1 to 25" + Environment.NewLine +
                 "Seed from 1 to 10" + Environment.NewLine +
                 "Capacity from 1 to 100";

        private void button1_Click(object sender, EventArgs e)
        {
            if (textNumber.Text.Length == 0)
            {
                textInstance.Clear();
                textResult.Clear();
                textNumber.BackColor = Color.White;
                textSeed.BackColor = Color.White;
                textCapacity.BackColor = Color.White;
                textResult.Text = message;
            }
            else if (textSeed.Text.Length == 0)
            {
                textInstance.Clear();
                textResult.Clear();
                textNumber.BackColor = Color.White;
                textSeed.BackColor = Color.White;
                textCapacity.BackColor = Color.White;
                textResult.Text = message;
            }
            else if (textCapacity.Text.Length == 0)
            {
                textInstance.Clear();
                textResult.Clear();
                textNumber.BackColor = Color.White;
                textSeed.BackColor = Color.White;
                textCapacity.BackColor = Color.White;
                textResult.Text = message;
            }
            else
            {
                string number = textNumber.Text.ToString();
                Number = int.Parse(number);
                string seed = textSeed.Text.ToString();
                Seed = int.Parse(seed);
                string capacity = textCapacity.Text.ToString();
                Capacity = int.Parse(capacity);
   
                if (Seed > 10 || Seed < 1)
                {
                    textSeed.BackColor = Color.Red;
                    textInstance.Clear();
                    textResult.Clear();
                    textResult.Text = message;
                }
                else
                    textSeed.BackColor = Color.White;
                if (Number > 25 || Number < 1)
                {
                    textNumber.BackColor = Color.Red;
                    textInstance.Clear();
                    textResult.Clear();
                    textResult.Text = message;
                }
                else
                    textNumber.BackColor = Color.White;
                if (Capacity > 100 || Capacity < 1)
                {
                    textCapacity.BackColor = Color.Red;
                    textInstance.Clear();
                    textResult.Clear();
                    textResult.Text = message;
                }
                else
                    textCapacity.BackColor = Color.White;
                if((Number <= 25 && Number >= 1) && (Capacity <= 100 && Capacity >= 1) && (Seed <= 10 && Seed >= 1))
                {
                    Problem problem = new Problem(Number, Seed);
                    Result result = problem.Solve(Capacity);
                    textInstance.Clear();
                    foreach (var item in problem.Items)
                    {
                        textInstance.AppendText($"Number: {item.Number}, Value: {item.Value}, Weight: {item.Weight}" + Environment.NewLine);
                    }
                    //textResult.Text = $"Items: {string.Join(", ", result.Numbers)}" + Environment.NewLine + $"Total Value: {result.TotalValue}" + Environment.NewLine + $"Total Weight: {result.TotalWeight}";
                    textResult.Text=result.ToString();
                }
            }
        }
        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {   
        }
    }
}
