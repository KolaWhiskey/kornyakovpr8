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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kornyakovpr8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void RacchetCircl_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(Radiys.Text, out double rad) &&
                rad > 0)
            {
                Circl circl = new(rad);

                //Вывод периметра круга
                PerimertCircl.Text = circl.Perimetr().ToString();

                //Вывод площади круга
                PloshadiCircl.Text = circl.Square().ToString();
            }
            else
            {
                MessageBox.Show("Некорректный ввод!\n\nВвод должен быть числом, а также быть больше нуля!");
            }
        }
        private void OchistkaCircl_Click(object sender, RoutedEventArgs e)
        {
            Radiys.Clear();
            PloshadiCircl.Clear();
            PerimertCircl.Clear();
        }

        private void RacchetPrym_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(StorA.Text, out double SideA) &&
                double.TryParse(StorB.Text, out double SideB) &&
                SideA > 0 &&
                SideB > 0)
            {
                Pramaygolnik Pram = new(SideA, SideB);

                //Вывод периметра прямоугольника
                PerimertPrym.Text = Pram.Perimetr().ToString();

                //Вывод площади прямоугольника
                PloshadiPrym.Text = Pram.Square().ToString();
            }
            else
            {
                MessageBox.Show("Некорректный ввод!\n\nВвод должен быть числом, а также быть больше нуля!");
            }
        }

        private void OchistkaPrym_Click(object sender, RoutedEventArgs e)
        {
            StorA.Clear();
            StorB.Clear();
            PerimertPrym.Clear();
            PloshadiPrym.Clear();

        }

        private void Sravnenie0_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int squareCompare = Convert.ToDouble(PloshadiPrym.Text).CompareTo(Convert.ToDouble(PloshadiCircl.Text));
                if (squareCompare == 1) MessageBox.Show("Прямоугольник больше круга");
                if (squareCompare == -1) MessageBox.Show("Круг больше прямоугольника");
                if (squareCompare == 0) MessageBox.Show("Прямоугольник и круг равны");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вариант 8. \r\nСоздать интерфейс – фигура (площадь, периметр). \r\nСоздать классы -" +
                "прямоугольник, круг. \r\nКлассы должны включать конструкторы, функцию для" +
                "\r\nформирования строки информации о фигуре. \r\nСравнение производить по площади.",
             "Разработчик: Корняков Д.Д.",
             MessageBoxButton.OK,
             MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


    }
}
