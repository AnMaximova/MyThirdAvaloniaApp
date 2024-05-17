using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyThirdAvaloniaApp.Models;
public class News
{
    public string Date { get; set; }
    public string Text{ get; set; }
    public News(string date, string text)
    {
        Date = date;
        Text = text;
    }
}
