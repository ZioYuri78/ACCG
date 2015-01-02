using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ACCG
{
   

    public class ACCGLogManager
    {
        private static ACCGLogManager instance = null;

        
        

        private ACCGLogManager() { }

        public static ACCGLogManager GetInstance()
        {
            if (instance == null)
            {
                instance = new ACCGLogManager();
            }

            return instance;
        }

        public void WriteLog(string _channel, string _message)
        {
            try
            {
                if (Directory.Exists(Directory.GetCurrentDirectory()))
                {
                    switch (_channel)
                    {
                        case "ERROR":                            
                            File.AppendAllText(Directory.GetCurrentDirectory() + @"\log\errors.log", _message + Environment.NewLine);
                            break;

                        case "SYSTEM":                      
                            File.AppendAllText(Directory.GetCurrentDirectory() + @"\log\system.log", _message + Environment.NewLine);
                            break;

                        case "SYNC":
                            ACCGMainForm.sync_form.SetText(_message + Environment.NewLine);                            
                            break;
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ops " + exc.ToString());
            }
        }

        

        public void DeleteLogFiles()
        {
            try
            {
                /*
                if (File.Exists(Directory.GetCurrentDirectory() + @"\log\errors.log"))
                {
                    File.Delete(Directory.GetCurrentDirectory() + @"\log\errors.log");
                }
                */
                if (File.Exists(Directory.GetCurrentDirectory() + @"\log\system.log"))
                {
                    File.Delete(Directory.GetCurrentDirectory() + @"\log\system.log");
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ops " + exc.ToString());
            }
        }

        
       
        
    }
}
