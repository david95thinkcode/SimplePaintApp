using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esgis_Paint.Models
{
    class Journal
    {
        public static StreamWriter flux = null;

        String _separator;
        String _filePath;
        StreamReader _reader;
        StreamWriter _writer;
        
        public Journal()
        {
            _separator = " --> ";
            _filePath = @"log.txt";

            //When the file does not exists, we create it and write inside it the head
            if (!File.Exists(_filePath)) 
                writeHead();
        }

        public void writeConnectionAction()
        {
            String data;
            data = "Esgis_Paint started.";
            
            writeIntoLogFile(data);
        }

        public void writePrintAction(string picturePath)
        {
            String data;
            data = "Picture " + picturePath + " printed ";

            writeIntoLogFile(data);
        }

        /// <summary>
        /// Write into log file save action
        /// </summary>
        /// <param name="picturePath">Path of saved Picture</param>
        public void writeSaveAction(string picturePath)
        {
            String data;
            data = "Picture " + picturePath + " saved ";

            writeIntoLogFile(data);
        }

        public void writeDisconnectionAction()
        {
            String data;
            data = "Esgis_Paint closed.";

            writeIntoLogFile(data);
        }

        /// <summary>
        /// Write the title of columns on the head of log file
        /// </summary>
        public void writeHead()
        {
            String head = "DATE      " + " HOUR         " + " ACTION";
            String underline = "----      " + " ----         " + " ------";
            try
            {
                using (_writer = new StreamWriter(_filePath, true))
                {
                    _writer.WriteLine(underline);
                    _writer.WriteLine(head);
                    _writer.WriteLine(underline);
                }
            }
            catch (Exception e)
            {
                String error_message = "Failed to write in the log file. Details : " + e;
                System.Windows.Forms.MessageBox.Show(error_message);
            }
        }

        private void writeIntoLogFile(String line)
        {
            /*
             * On écrit la première partie de la ligne
             * C'est à dire la date et l'heure
             * Puis on y ajoute une chaine recu en paramètre 
            */
            DateTime currentTime = DateTime.Now;
            
            try
            {
                using (_writer = new StreamWriter(_filePath, true))
                {
                    _writer.Write(currentTime.ToString() + _separator);
                    _writer.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                String error_message = "Failed to write in the log file. Details : " + e;
                System.Windows.Forms.MessageBox.Show(error_message);
            }
        }
    }
}
