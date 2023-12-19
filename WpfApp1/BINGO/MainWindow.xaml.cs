using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BINGO {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private List<int> numbers;
        const int  max= 163;
        public MainWindow() {
            InitializeComponent();
            numbers = new List<int>();
            //ExportToExcel(@"C:\opt\juego.xlsx");
            numbers = new List<int>();
        }

        public void ExportToExcel(string filePath) {
            Random random;
            int number;

            using (var spreadsheetDocument = SpreadsheetDocument.Create(filePath, SpreadsheetDocumentType.Workbook)) {
                var workbookPart = spreadsheetDocument.AddWorkbookPart();
                workbookPart.Workbook = new Workbook();

                var worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                worksheetPart.Worksheet = new Worksheet();

                var sheets = spreadsheetDocument.WorkbookPart.Workbook.AppendChild(new Sheets());
                var sheet = new Sheet { Id = spreadsheetDocument.WorkbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = "Personas" };
                sheets.Append(sheet);

                var sheetData = worksheetPart.Worksheet.AppendChild(new SheetData());

                // Encabezados
                var headerRow = new Row();
                headerRow.AppendChild(new Cell(new CellValue("N1")));
                headerRow.AppendChild(new Cell(new CellValue("N2")));
                headerRow.AppendChild(new Cell(new CellValue("N3")));
                sheetData.AppendChild(headerRow);

                // Datos
                //foreach (var person in people) {
                while (true) {
                    
                    random = new Random();
                    number = random.Next(1, max);

                    if (numbers.Count(s => s == number) == 0) {
                        lblNumber.Content = number.ToString();
                        numbers.Add(number);
                    }

                    if (numbers.Count == (max - 1)) {
                        break;
                    }
                }

                for(int i=0; i< numbers.Count; i++) {
                    var dataRow = new Row();
                    dataRow.AppendChild(new Cell(new CellValue(numbers[i])));
                    dataRow.AppendChild(new Cell(new CellValue(numbers[++i])));
                    dataRow.AppendChild(new Cell(new CellValue(numbers[++i])));
                    sheetData.AppendChild(dataRow);
                }
                
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            Random random;
            int number;

            while (true) {
                random = new Random();
                number = random.Next(1, max);

                if (numbers.Count(s => s == number) == 0) {
                    lblNumber.Content = number.ToString();
                    numbers.Add(number);
                    lblNumbers.Text += number + ", ";
                    break;
                }

                if (numbers.Count == (max - 1)) {
                    MessageBox.Show("El juego termino");
                    break;
                }
            }
        }
    }
}
