//������� �������� : ������ ������� ���������. ������ 221�.������������ ������ "�������������� ������ - 4". 04.06.2022.
namespace PaintVS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormPaint());
        }
    }
}