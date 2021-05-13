using System;
using static CheckBox.Program;

namespace CheckBox.Views
{
    public static class Program
    {
        [STAThread]
        public static void Main() =>
         CheckBox.Program.main(new MainWindow(), () => new Window1(), () => new Window2());
    }
}
