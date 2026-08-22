using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Text;
using UnitConverter.Forms;

namespace UnitConverter.Services
{
    internal class Transformations
    {
        double error = 00.0000;

        public double LengthConverter(MainForm category)
        {
            double[] lengthValues =
            {
                // metre karşılığı 
                1000,
                100,
                10,
                1,
                0.1,
                0.01,
                0.001,
                0.000001,
                0.000000001,
                0.000000000001,
                0.0254,     // inch
                0.3048,     // foot
                0.9144,     // yard
                1609.344    // mile
            };

            if (double.TryParse(category.text_main_value.Text, out double value))
            {
                int from = category.cbox_main_from.SelectedIndex;
                int to = category.cbox_main_to.SelectedIndex;

                double result = value * lengthValues[from] / lengthValues[to];
                return result;
            }
            else
            {
                MessageBox.Show("please enter a number. ", "Warning ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return error;
        }

        public double AreaConverter(MainForm Category)
        {
            double[] areaValues =
            {
                // metre karşılığı 
                1000,
                100,
                10,
                1,
                0.1,
                0.01,
                0.001,
                0.000001,
                0.000000001,
                0.000000000001,
                0.0254,     // inch
                0.3048,     // foot
                0.9144,     // yard
                1609.344    // mile
            };

            int from = Category.cbox_main_from.SelectedIndex;
            int to = Category.cbox_main_to.SelectedIndex;

            if (double.TryParse(Category.text_main_value.Text, out double value))
            {
                double result = value * (Math.Pow(areaValues[from], 2) / Math.Pow(areaValues[to], 2));
                return result;
            }
            else
            {
                MessageBox.Show("please enter a number. ", "Warning ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return error;
        }

        public double VolumeConverter(MainForm Category)
        {
            double[] volumeValues =
            {
                // metre karşılığı 
                1000000000,
                1000000,
                1000,
                1,
                0.001,
                0.000001,
                0.000000001,
                0.001,      // Litre
                0.0001,     // dL
                0.00001,    // cL
                0.000001    // mL
            };

            if (double.TryParse(Category.text_main_value.Text, out double value))
            {
                int from = Category.cbox_main_from.SelectedIndex;
                int to = Category.cbox_main_to.SelectedIndex;

                double result = value * (volumeValues[from] / volumeValues[to]);
                return Math.Round(result,4);
            }
            else
            {
                MessageBox.Show("please enter a number. ", "Warning ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return error;
        }

        public double WeightConverter(MainForm Category)
        {
            double[] weightValues =
            {
                Math.Pow(10,0),
                Math.Pow(10,1),
                Math.Pow(10,2),
                Math.Pow(10,3),
                Math.Pow(10,4),
                Math.Pow(10,5),
                Math.Pow(10,6),
                Math.Pow(10,7),
                Math.Pow(10,8),
                Math.Pow(10,9),
            };

            if (double.TryParse(Category.text_main_value.Text, out double value))
            {
                int from = Category.cbox_main_from.SelectedIndex;
                int to = Category.cbox_main_to.SelectedIndex;
                double result;

                if (Category.cbox_main_from.SelectedIndex == 0)
                {
                    result = 100 * (value * (weightValues[to] / weightValues[from]));
                    return result;
                }
                result = value * (weightValues[to] / weightValues[from]);
                return result;
            }
            else
            {
                MessageBox.Show("please enter a number. ", "Warning ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return error;
        }

        public double TemperatureConverter(MainForm Category)
        {
            int from = Category.cbox_main_from.SelectedIndex;
            int to = Category.cbox_main_to.SelectedIndex;
            double result;
            if (double.TryParse(Category.text_main_value.Text, out double value))
            {
                if (from == 0 && to == 0)
                {
                    return value;
                }
                else if (from == 0 && to == 1)
                {   // celsius => fahrenheit
                    result = (value * 9 / 5) + 32;
                    return result; 
                } 
                else if (from == 0 && to == 2)
                {
                    result = value + 273;
                    return result;
                }
                else if (from == 1 && to == 0)
                {
                    result = (value - 32) * 5 / 9;
                    return result;
                }
                else if (from == 1 && to == 1)
                {
                    return value;
                }
                else if (from == 1 && to == 2)
                {
                    result = ((value - 32 ) * 5/ 9) + 273.15;
                    return result;
                }
                else if (from == 2 && to == 0 )
                {
                    result = value - 273.15;
                    return result;
                }
                else if (from == 2 && to == 1 )
                {
                    result = ((value - 273.15) * 9 / 5) + 32;
                    return result;
                }
                else if (from == 2 && to == 2 )
                {
                    return value;
                }
            }
            else
            {
                MessageBox.Show("please enter a number. ", "Warning ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return error;
        }

        public double SpeedConverter(MainForm Category)
        {
            double[] speedValues =
            {
                1000.0 / 3600.0,  // km/h
                1000.0,            // km/s
                1.0 / 3600.0,      // m/h
                1.0 / 60.0,        // m/min
                1.0,               // m/s
                0.44704,           // mph
                1609.344,          // mi/s
                0.3048,            // ft/s
                0.00508            // ft/min
            };

            if (double.TryParse(Category.text_main_value.Text , out double value))
            {
                int from = Category.cbox_main_from.SelectedIndex; 
                int to = Category.cbox_main_to.SelectedIndex;

                double result = value * (speedValues[from] / speedValues[to]);
                return Math.Round(result, 4);
            }
            else
            {
                MessageBox.Show("please enter a number. ", "Warning ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return error; 
        }

        public double TimeConverter(MainForm Category)
        {
            double[] timeValues =
            {
                             1,       // Second
                60,                   // Minute
                60 * 60,              // Hour
                60 * 60 * 24,         // Day
                60 * 60 * 24 * 7,     // Week
                60 * 60 * 24 * 14,    // Fortnight
                60 * 60 * 24 * 30,    // Month (30 days)
                60 * 60 * 24 * 90,    // Quarter (90 days)
                60 * 60 * 24 * 365,   // Year (365 days)
                60 * 60 * 24 * 3650,  // Decade
                60 * 60 * 24 * 36500d, // Century
                60 * 60 * 24 * 365000d // Millennium
            };

            if (double.TryParse(Category.text_main_value.Text , out double value))
            {
                int from = Category.cbox_main_from.SelectedIndex;
                int to = Category.cbox_main_to.SelectedIndex;

                double result = value * timeValues[from] / timeValues[to];
                return result;
            }
            else
            {
                MessageBox.Show("please enter a number. ", "Warning ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return error;
        }

        public double DataConverter(MainForm Category)
        {
            double[] bitValues =
            {
                1,
                8,
                8 * Math.Pow(1024,1),
                8 * Math.Pow(1024,2),
                8 * Math.Pow(1024,3),
                8 * Math.Pow(1024,4),
                8 * Math.Pow(1024,5),
                8 * Math.Pow(1024,6),
                8 * Math.Pow(1024,7),
                8 * Math.Pow(1024,8)
            };

            if (double.TryParse(Category.text_main_value.Text, out double value))
            {
                int from = Category.cbox_main_from.SelectedIndex;
                int to = Category.cbox_main_to.SelectedIndex;

                double result = value * bitValues[from] / bitValues[to];

                return Math.Round(result, 4);
            }
            else
            {
                MessageBox.Show("Please enter a number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return error;
            }

        }

    }
}
