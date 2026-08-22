using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using UnitConverter.Services;
using static System.Resources.ResXFileRef;

namespace UnitConverter.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbox_main_category.Items.Add("Select...");
            cbox_main_category.Items.Add("1-Length");
            cbox_main_category.Items.Add("2-Area");
            cbox_main_category.Items.Add("3-Volume");
            cbox_main_category.Items.Add("4-Weight");
            cbox_main_category.Items.Add("5-Temperature");
            cbox_main_category.Items.Add("6-Speed");
            cbox_main_category.Items.Add("7-Time");
            cbox_main_category.Items.Add("8-Data");
            cbox_main_category.SelectedIndex = 0;
        }

        private readonly string[][] units = {
            Array.Empty<string>(),

            new[] { "km", "hm", "dam", "m", "dm", "cm", "mm", "µm", "nm", "pm", "in", "ft", "yd", "mi" },

            new[] { "km²", "hm²", "dam²", "m²", "dm²", "cm²", "mm²", "µm²", "nm²", "pm²", "in²", "ft²", "yd²", "mi²" },

            new[] { "km³", "hm³", "dam³", "m³", "dm³", "cm³", "mm³", "L", "dL", "cL", "mL" },

            new[] { "t", "kg", "hg", "dag", "g", "dg", "cg", "mg", "µg", "ng" },

            new[] { "°C", "°F", "K" },

            new[] { "km/h", "km/s", "m/h", "m/min", "m/s", "mph", "mi/s", "ft/s", "ft/min" },

            new[] { "s", "min", "h", "d", "wk", "fn", "mo", "qtr", "yr", "dec", "c", "millennium/kyr" },

            new[] { "bit(b)", "B", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" }
        };

        private void cbox_main_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbox_main_category.SelectedIndex;

            cbox_main_from.Items.Clear();
            cbox_main_to.Items.Clear();
            text_main_value.Clear();
            text_main_result.Clear();

            bool enabled = index != 0;

            cbox_main_from.Enabled = enabled;
            cbox_main_to.Enabled = enabled;
            text_main_value.Enabled = enabled;

            if (!enabled)
                return;

            cbox_main_from.Items.AddRange(units[index]);
            cbox_main_to.Items.AddRange(units[index]);
        } 
        public void button_main_convert_Click(object args, EventArgs e)
        {
            Transformations converter = new Transformations();
            if (cbox_main_category.SelectedIndex == 1)
            {
                text_main_result.Text = converter.LengthConverter(this).ToString();
            }

            else if (cbox_main_category.SelectedIndex == 2 )
            {
                text_main_result.Text = converter.AreaConverter(this).ToString();
            }

            else if (cbox_main_category.SelectedIndex == 3)
            {
                text_main_result.Text = converter.VolumeConverter(this).ToString();
            }
            
            else if (cbox_main_category.SelectedIndex == 4)
            {
                text_main_result.Text = converter.WeightConverter(this).ToString();
            }

            else if (cbox_main_category.SelectedIndex == 5)
            {
                text_main_result.Text = converter.TemperatureConverter(this).ToString();
            }

            else if (cbox_main_category.SelectedIndex == 6)
            {
                text_main_result.Text = converter.SpeedConverter(this).ToString();
            }

            else if (cbox_main_category.SelectedIndex == 7)
            {
                text_main_result.Text = converter.TimeConverter(this).ToString();
            }

            else if (cbox_main_category.SelectedIndex == 8 )
            {               
                text_main_result.Text = converter.DataConverter(this).ToString();
            }
        }

    }
}
