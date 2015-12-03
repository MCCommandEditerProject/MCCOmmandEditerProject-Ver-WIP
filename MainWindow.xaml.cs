using SilverNBTLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Command_Editer
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        NBTTagInt minecraft_noai = new NBTTagInt("NoAI");
        NBTTagDouble minecraft_fire = new NBTTagDouble("Fire");
        NBTFile Summon_base = new NBTFile();
        public static NBTTagCompound s_base = new NBTTagCompound();
        public static bool max_toggle = true;
        public MainWindow()
        {
            InitializeComponent();
            setComboBoxitem_to_summon();
            setComboBoxitem_to_give();
        }

        private void button_max_Click(object sender, RoutedEventArgs e)
        {
            if (max_toggle)
            {
                SystemCommands.MaximizeWindow(this);
                button_max.Content = 2;
                max_toggle = false;
                return;
            }
            if (!max_toggle)
            {
                SystemCommands.RestoreWindow(this);
                button_max.Content = 1;
                max_toggle = true;
                return;
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            SystemCommands.CloseWindow(this);
        }

        private void button_min_Click(object sender, RoutedEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);
        }

        private void tag_noai_Checked(object sender, RoutedEventArgs e)
        {
            //デバッグ表示
            label3.Content = "Tagの作成";
            loadbar.IsIndeterminate = true;
            label3.Content = "完了";
            label3.Content = "minecraft_noai.Value = 1;";
            minecraft_noai.Value = 1;
            label3.Content = "完了";
            loadbar.IsIndeterminate = false;
            s_base.Remove("NoAI");
            s_base.Add("NoAI", minecraft_noai);
            label3.Content = "準備完了[" + minecraft_noai.ToString() + ":" + s_base + "]";
        }

        private void tag_noai_Unchecked(object sender, RoutedEventArgs e)
        {
            //デバッグ表示
            label3.Content = "minecraft_noai.Value = 1;";
            minecraft_noai.Value = 0;
            label3.Content = "完了";
            loadbar.IsIndeterminate = false;
            s_base.Remove("NoAI");
            label3.Content = "準備完了[" + minecraft_noai.ToString() + ":" + s_base + "]";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Chenged_time_button_Unloaded(object sender, RoutedEventArgs e)
        {
            label4.Content = "Time : " + slider.Value + "/127 tick";
        }

        private void Chenged_time_button_Unchecked(object sender, RoutedEventArgs e)
        {
            label4.Content = "Time : " + slider.Value + "/127 tick";
            minecraft_fire.Value = slider.Value;
            s_base.Remove("Fire");
            s_base.Add("Fire", minecraft_fire);
            label3.Content = "準備完了[" + minecraft_fire.ToString() + ":" + s_base + "]";
        }

        private void tag_fire_Checked(object sender, RoutedEventArgs e)
        {
            Chenged_time_button.IsEnabled = true;
            label3.Content = "Tagの作成";
            loadbar.IsIndeterminate = true;
            label3.Content = "完了";
            label3.Content = "minecraft_fire.Value = " + slider.Value + ";";
            minecraft_fire.Value = slider.Value;
            label3.Content = "完了";
            loadbar.IsIndeterminate = false;
            s_base.Remove("Fire");
            s_base.Add("Fire", minecraft_fire);
            label3.Content = "準備完了[" + minecraft_fire.ToString() + ":" + s_base + "]";
        }

        private void tag_fire_Unchecked(object sender, RoutedEventArgs e)
        {
            Chenged_time_button.IsEnabled = false;
            label3.Content = "minecraft_fire.Value = 0;";
            minecraft_fire.Value = 0;
            label3.Content = "完了";
            loadbar.IsIndeterminate = false;
            s_base.Remove("Fire");
            label3.Content = "準備完了[" + minecraft_fire.ToString() + ":" + s_base + "]";
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                //TODO:ここのif文をどうにかしたい
                var linesplit = comboBox.Text.Split(',');
                if ((bool)!x_relative.IsChecked && (bool)y_relative.IsChecked && (bool)z_relative.IsChecked)
                {
                    resultBox.Text = "/summon " + linesplit[1] + " "
                                    + x_text.Text + " ~" + y_text.Text + " ~" + z_text.Text + " "
                                    + s_base;
                }
                else if ((bool)x_relative.IsChecked && (bool)!y_relative.IsChecked && (bool)!z_relative.IsChecked)
                {
                    resultBox.Text = "/summon " + linesplit[1] + " ~"
                               + x_text.Text + " " + y_text.Text + " " + z_text.Text + " "
                               + s_base;
                }
                else if ((bool)!x_relative.IsChecked && (bool)y_relative.IsChecked && (bool)!z_relative.IsChecked)
                {
                    resultBox.Text = "/summon " + linesplit[1] + " "
                               + x_text.Text + " ~" + y_text.Text + " " + z_text.Text + " "
                               + s_base;
                }
                else if ((bool)x_relative.IsChecked && (bool)!y_relative.IsChecked && (bool)z_relative.IsChecked)
                {
                    resultBox.Text = "/summon " + linesplit[1] + " ~"
                               + x_text.Text + " " + y_text.Text + " ~" + z_text.Text + " "
                               + s_base;
                }
                else if ((bool)x_relative.IsChecked && (bool)y_relative.IsChecked && (bool)z_relative.IsChecked)
                {
                    resultBox.Text = "/summon " + linesplit[1] + " ~"
                               + x_text.Text + " ~" + y_text.Text + " ~" + z_text.Text + " "
                               + s_base;
                }
                else if ((bool)!x_relative.IsChecked && (bool)!y_relative.IsChecked && (bool)!z_relative.IsChecked)
                {
                    resultBox.Text = "/summon " + linesplit[1] + " "
                               + x_text.Text + " " + y_text.Text + " " + z_text.Text + " "
                               + s_base;
                }
                else if ((bool)x_relative.IsChecked && (bool)!y_relative.IsChecked && (bool)!z_relative.IsChecked)
                {
                    resultBox.Text = "/summon " + linesplit[1] + " ~"
                               + x_text.Text + " " + y_text.Text + " " + z_text.Text + " "
                               + s_base;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("エンティティタイプを選択してください。\n"
                                + "エラーメッセージ : \n" 
                                + ex);
            }

            if(resultBox.Text.Length > 100)
            {
                label5_Copy.Content = "現在" + resultBox.Text.Length + "文字 : チャットで入力できません。";
            }
            if (resultBox.Text.Length <= 100)
            {
                label5_Copy.Content = "現在" + resultBox.Text.Length + "文字 : チャットで入力できます。";
            }
        }

        public void setComboBoxitem_to_summon()
        {
            using (var sr = new StreamReader(@"SystemFile\Data\EntityIDs.csv"))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    comboBox.Items.Add(line);
                }
            }
        }

        public void setComboBoxitem_to_give()
        {
            using (var sr = new StreamReader(@"SystemFile\Data\ItemIDs.csv"))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    comboBox_item.Items.Add(line);
                }
            }
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            label4.Content = "Time : " + slider.Value + "/127 tick";
        }

        private void Summon_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void tabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 1: resultBox.Text = "/give"; break;
                case 0: resultBox.Text = "/summon"; break;
            }
        }

        private void resultBox_TextInput(object sender, TextCompositionEventArgs e)
        {
            if (resultBox.Text.Length > 100)
            {
                label5_Copy.Content = "現在" + resultBox.Text.Length + "文字 : チャットで入力できません。";
            }
            if (resultBox.Text.Length <= 100)
            {
                label5_Copy.Content = "現在" + resultBox.Text.Length + "文字 : チャットで入力できます。";
            }
        }

        private void r_up_Click(object sender, RoutedEventArgs e)
        {
            int tointtext = int.Parse(r_val.Text);
            tointtext++;
            if(tointtext > 255)
            {
                r_up.IsEnabled = false;
            }
            r_val.Text = tointtext.ToString();
        }

        private void r_val_TextChanged(object sender, TextChangedEventArgs e)
        {
            int result;
            bool resultto
            = int.TryParse(r_val.Text, out result);
            if (resultto)
            {
                result = int.Parse(r_val.Text);
            }
            else if (!resultto)
            {
                result = 0;
            }
            r_val.Text = result.ToString();
            if (result > 255)
            {
                r_up.IsEnabled = false;
                r_val.Text = "255";
            }
            else if (result < 255)
            {
                r_up.IsEnabled = true;
            }
            if (result <= 0)
            {
                r_down.IsEnabled = false;
                r_val.Text = "0";
            }
            else if (result > 0)
            {
                r_down.IsEnabled = true;
            }
        }

        private void r_down_Click(object sender, RoutedEventArgs e)
        {
            int tointtext = int.Parse(r_val.Text);
            tointtext--;
            if (tointtext <= 0)
            {
                r_down.IsEnabled = false;
            }
            if(tointtext > 0)
            {
                r_down.IsEnabled = true;
            }
            r_val.Text = tointtext.ToString();
        }

        private void r_upg_Click(object sender, RoutedEventArgs e)
        {
            int tointtext = int.Parse(r_val_g.Text);
            tointtext++;
            if (tointtext > 255)
            {
                r_up_g.IsEnabled = false;
            }
            r_val_g.Text = tointtext.ToString();
        }

        private void r_downg_Click(object sender, RoutedEventArgs e)
        {
            int tointtext = int.Parse(r_val_g.Text);
            tointtext--;
            if (tointtext <= 0)
            {
                r_down_g.IsEnabled = false;
            }
            if (tointtext > 0)
            {
                r_down_g.IsEnabled = true;
            }
            r_val_g.Text = tointtext.ToString();
        }

        private void r_valg_TextChanged(object sender, TextChangedEventArgs e)
        {
            int result;
            bool resultto
            = int.TryParse(r_val_g.Text, out result);
            if (resultto)
            {
                result = int.Parse(r_val_g.Text);
            }
            else if (!resultto)
            {
                result = 0;
            }
            r_val_g.Text = result.ToString();
            if (result > 255)
            {
                r_up_g.IsEnabled = false;
                r_val_g.Text = "255";
            }
            else if (result < 255)
            {
                r_up_g.IsEnabled = true;
            }
            if (result <= 0)
            {
                r_down_g.IsEnabled = false;
                r_val_g.Text = "0";
            }
            else if (result > 0)
            {
                r_down_g.IsEnabled = true;
            }
        }
    }

    public class StartUp
    {

    }
}
