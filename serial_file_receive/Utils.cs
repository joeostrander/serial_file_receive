using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public static class Utils
{
    public static bool IsNumeric(String s)
    {
        return s.All(Char.IsDigit) & !string.IsNullOrEmpty(s);
    }

    public static int Clamp(int value, int min, int max)
    {
        return (value < min) ? min : (value > max) ? max : value;
    }

    public static string getComboBoxText(ComboBox box)
    {
        string text = box.GetItemText(box.SelectedItem);
        if (string.IsNullOrEmpty(text))
        {
            if (!string.IsNullOrEmpty(box.Text))
                text = box.Text;
        }
        return text;
    }


    public static UInt32 SwapEndianness(UInt32 value)
    {
        var b1 = (value >> 0) & 0xff;
        var b2 = (value >> 8) & 0xff;
        var b3 = (value >> 16) & 0xff;
        var b4 = (value >> 24) & 0xff;

        return b1 << 24 | b2 << 16 | b3 << 8 | b4 << 0;
    }

}
