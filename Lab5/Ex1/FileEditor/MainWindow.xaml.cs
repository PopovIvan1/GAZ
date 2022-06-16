using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace FileEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Name of file in use
        /// </summary>
        private string fileName = String.Empty;
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Open the file after the user has been prompted for the file name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            fileName = GetFileName();
            try
            {
                editor.Text = TextFileOperations.ReadTextFileContents(fileName);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
         }

        // Add a GetFileName method
        private string GetFileName()
        {
            // Initialize the file name.
            string fname = "";

            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.InitialDirectory = @"E:\Labfiles\Lab 5\Ex1\Solution";
            openFileDlg.DefaultExt = ".txt";
            openFileDlg.Filter = "Text documents (.txt)|*.txt";

            if (openFileDlg.ShowDialog() == true)
            {
                fname = openFileDlg.FileName;
            }
            return fname;
        }
 

        // Save the data back to the file
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TextFileOperations.WriteTextFileContents(fileName,editor.Text);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }   
}
