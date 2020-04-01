using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        int length;
        char[,] grid;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";
            WriteGrid(grid);
            StartGame(grid);          
        }

        private void BtnInit_Click(object sender, EventArgs e)
        {
            length = int.Parse(txtInput.Text);
            length += 2;
            grid = new char[length, length];
            InitGrid(grid, length);
        }
        private void InitGrid(char[,] grid, int length)
        {

            for (int x = 1; x < length - 1; x++)
            {
                for (int y = 1; y < length - 1; y++)
                {
                    grid[x, y] = ' ';
                }               
            }
            if (btnDefault.Checked)
            {
                length = 12;
                grid[6, 6] = '*';
                grid[7, 7] = '*';
                grid[7, 5] = '*';
                //grid[3, 5] = '*';
                grid[8, 6] = '*';
                grid[8, 8] = '*';
                grid[6, 8] = '*';
                grid[7, 9] = '*';
                grid[9, 7] = '*';
            }
            else if (btnCustom.Checked)
            {
                for (int i = 0; i < int.Parse(txtInput2.Text); i++)
                {
                    int x;
                    int y;
                    using (Prompt prompt = new Prompt("insert X", "values"))
                    {
                        x = Convert.ToInt32(prompt.Result);
                    }
                    using (Prompt prompt = new Prompt("insert Y", "values"))
                    {
                        y = Convert.ToInt32(prompt.Result);
                    }
                    if (x == 0)
                    {
                        x++;
                    }
                    else if (x == length - 1)
                    {
                        x--;
                    }
                    if (y == 0)
                    {
                        y++;
                    }
                    else if (y == length - 1)
                    {
                        y--;
                    }
                    grid[y, x] = '*';
                }
            }
            else if (btnRandom.Checked)
            {
                Random rnd = new Random();
                for (int i = 0; i < int.Parse(txtInput2.Text); i++)
                {
                    int x = rnd.Next(1, length - 1);
                    int y = rnd.Next(1, length - 1);
                    grid[y, x] = '*';
                }
            }
                       
        }
        private void StartGame(char[,] grid)
        {
            int i = 0;
            for (int x = 1; x < length - 1; x++)
            {
                for (int y = 1; y < length - 1; y++)
                {                    
                    for (int x1 = x - 1; x1 < x + 2; x1++)
                    {
                        for (int y1 = y - 1; y1 < y + 2; y1++)
                        {
                            if(grid[x1,y1] == '*' || grid[x1,y1] == 'd')
                            {
                                i++;
                            }                           
                        }
                    }
                    if (i == 3)
                    {
                        if (grid[x, y] == ' ')
                        {
                            grid[x, y] = 'r';
                        }
                    }
                    else if (i < 3 || i > 4)
                    {
                        if (grid[x, y] == '*' || grid[x,y] == 'r')
                        {
                            grid[x, y] = 'd';
                        }
                    }
                    i = 0;
                }
            }
            for(int x = 1; x < length - 1; x++)
            {
                for(int y = 1; y < length - 1; y++)
                {
                    if(grid[x,y] == 'r')
                    {
                        grid[x, y] = '*';
                    }
                    if (grid[x,y] == 'd')
                    {
                        grid[x, y] = ' ';
                    }
                }
            }
        }
        private void WriteGrid(char[,] grid)
        {
            for (int x = 1; x < length - 1; x++)
            {
                for (int y = 1; y < length - 1; y++)
                {
                    lblOutput.Text += grid[x, y] + " ";
                }
                lblOutput.Text += "\r\n";
            }
        }
    }
}
public class Prompt : IDisposable
{
    private Form prompt { get; set; }
    public string Result { get; }

    public Prompt(string text, string caption)
    {
        Result = ShowDialog(text, caption);
    }
    //use a using statement
    private string ShowDialog(string text, string caption)
    {
        prompt = new Form()
        {
            Width = 500,
            Height = 150,
            FormBorderStyle = FormBorderStyle.FixedDialog,
            Text = caption,
            StartPosition = FormStartPosition.CenterScreen,
            TopMost = true
        };
        Label textLabel = new Label() { Left = 50, Top = 20, Text = text, Dock = DockStyle.Top, TextAlign = ContentAlignment.MiddleCenter };
        TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
        Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
        confirmation.Click += (sender, e) => { prompt.Close(); };
        prompt.Controls.Add(textBox);
        prompt.Controls.Add(confirmation);
        prompt.Controls.Add(textLabel);
        prompt.AcceptButton = confirmation;

        return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
    }

    public void Dispose()
    {
        //See Marcus comment
        if (prompt != null)
        {
            prompt.Dispose();
        }
    }
}
