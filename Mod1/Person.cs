using System;
using System.Globalization;
using System.IO;

namespace Mod1
{
    class Person : IDisposable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        StreamReader streamReader = null;
        StreamWriter streamWriter = null;
        private bool disposed = false;

        ~Person()
        {
            Dispose(false);
        }
        
        public Person(string fname, string lname)
        {
            this.FirstName = fname;
            this.LastName = lname;
            Console.WriteLine("Creating Person " + this.FirstName + " " + this.LastName);
        }

        public void ReadDetails(string fileName)
        {
            streamReader = new StreamReader(fileName);
            try
            {
                using(streamReader)
                {
                    String line = streamReader.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch(Exception e) 
            {
                Console.WriteLine("The file could not be read: ");
                Console.WriteLine(e.Message);
            }
            finally
            {
                streamReader.Close();
                streamReader = null;
            }
        }

        public bool WriteDetails(string fileName)
        {
            bool result = false;
            streamWriter = new StreamWriter(fileName);
            string[] lines = { this.FirstName.ToString(), this.LastName.ToString() };

            try 
            {
                using(streamWriter)
                {
                    foreach(string line in lines) {
                        streamWriter.WriteLine(line);
                    }
                }
                result = true;
            }
            catch(Exception e)
            {
                Console.WriteLine("This file could not be written.");
                Console.WriteLine(e.Message);
                result = false;
            }
            finally
            {
                streamWriter.Close();
                streamWriter = null;

            }
            return result;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if(!disposed)
            {
                if(disposing)
                {
                    if(streamReader != null) 
                    {
                        streamReader.Close();
                    }

                    if(streamWriter != null) 
                    {
                        streamWriter.Close();
                    }
                }
            }
            disposed = true;
        }

    }
}
