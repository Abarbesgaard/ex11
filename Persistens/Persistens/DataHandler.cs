using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Persistens
{
	public class DataHandler
	{
		private string dataFileName;

		public string DataFileName
		{
			get 
			{ 
				return this.dataFileName; 
			}

		}

		public DataHandler(string dataFileName) 
		{
			this.dataFileName = dataFileName;
		}

		public void SavePerson(Person person)
		{
			try { 
			StreamWriter sr = new StreamWriter(DataFileName);
			
				sr.Write(person.MakeTitle());
			
				sr.Close();
            }
			catch(Exception e) 
			{
				
				Console.WriteLine(e.Message); 
			}
			finally
			{ 
				Console.WriteLine("executing finally block"); 
			}


        }

		public Person LoadPerson()
		{
			string line;


			try
			{
				//Pass the file path and file name to the StreamReader constructor
				StreamReader sr = new StreamReader(DataFileName);
				//Read the first line of text
				line = sr.ReadLine();
				//Continue to read until you reach end of file
				//while (line != null)
				//{
				//    //write the lie to console window
				//    Console.WriteLine(line);
				//    //Read the next line
				//    line = sr.ReadLine();
				//}
				string[] loadedPerson = line.Split(';');

				if (line != null)
				{
					string[] values = line.Split(';');

					string name = values[0];
					DateTime birthDate = DateTime.Parse(values[1]);
					double height = double.Parse(values[2]);
					bool isMarried = bool.Parse(values[3]);
					int noOfChildren = int.Parse(values[4]);

					return new Person(name, birthDate, height, isMarried, noOfChildren);

				}
			}

             
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

			return null;
        

        }
	}
}
