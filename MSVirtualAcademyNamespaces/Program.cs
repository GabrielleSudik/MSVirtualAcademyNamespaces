using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

//those things that load automatically are classes
//they contain some of the most commonly used methods for the console
//you can also add more if you need more methods

namespace MSVirtualAcademyNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");
            System.Console.ReadLine();
            //technically, the full path of "Console" is "System.Console"
            //MS VS already knows this because you started the program with
            //"using System"
            //so it's unnecessary to write it here, and is greyed out

            //"site: microsoft.com" in web searches will limit results to that site

            //here's an example of using a new class not already attached to this program:
            string text = "blah";
            System.IO.File.WriteAllText("blah blah ", text);

            //the System.IO is needed to let MSVS
            //know what to do with File.WriteAllText
            //but another solution is to cut/copy it from the body
            //and add "using System.IO" to the top

            File.WriteAllText("second try ", text);
            Console.ReadLine();

            //fyi, that writes the info to file, not console.
            //so it won't show on the screen

            System.Net.WebClient client = new System.Net.WebClient();

            //HEY! when you get a red squiggly, ctrl-period will pull up a menu

            //as before, you can cut the System.Net from the body
            //and add it to the list of classes at the top

            WebClient client2 = new WebClient();
            string reply = client2.DownloadString("http://msdn.mirosoft.com");

            //HEY. looks like what you did there was capture the html on that page
            //when you print it to Console, you'll see all the code

            text = reply;

            Console.WriteLine(text);
            Console.ReadLine();

            //short version: when you try to use a (microsoft-created) method that won't work
            //make sure you've loaded its associated library
        }
    }
}
