using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {

            const double BANKTHREEMONTH = 11.5;
            const double BANKHALFYEAR = 11.75;
            const double BANKYEAR = 12.5;

            double summ = 0, perc = 0, monthPerc;
            int time = 0;

            bool valid = true;

            //Этап ввода данных
            try
            {
                //Ввод суммы вклада
                summ = Convert.ToDouble(TBSum.Text);
                summ = Math.Round(summ, 2);     //Округляем сумму до 2-х знаков

                //Ввод срока вклада
                time = Convert.ToInt32(TBTime.Text);

                switch (time)
                {
                    case 91:
                        perc = BANKTHREEMONTH;
                        break;
                    case 181:
                        perc = BANKHALFYEAR;
                        break;
                    case 365:
                        perc = BANKYEAR;
                        break;
                    default:
                        MessageBox.Show("Введен неподходящий срок!", "Ошибка ввода");
                        valid = false;
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Введены неподоходящие значения!", "Ошибка ввода");
                valid = false;
            }

            if (valid)
            {
                // Получение % в месяц
                monthPerc = Math.Round((perc / 12), 3);

                double addition = 0;
                double allAdditions = 0;
                string output;

                for (int i = 1; i <= time / 30; i++)
                {
                    addition = summ * (monthPerc / 100);
                    summ += addition;
                    summ = Math.Round(summ, 2);
                    output = $"{Convert.ToString(i)}) Сумма на вкладе: {summ.ToString("C", new CultureInfo("ru-RU"))} |{addition.ToString("C", new CultureInfo("ru-RU"))}|";
                    listCalcs.Items.Add(output);
                    allAdditions += addition;
                }

                //Вывод итоговой суммы на вкладе
                textFinish.Text = $"{summ.ToString("C", new CultureInfo("ru-RU"))} |{Math.Round(allAdditions, 2).ToString("C", new CultureInfo("ru-RU"))}|";
            }
           
        }
    }
}
