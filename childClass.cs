using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class characteristics : life
    {

      public void addReligion()
      {
          string religion = "";
          Console.Write("-GOD:...And becuase I want to put it into the humans society you must provide\n\tthis baby dinosaur with a human religion, so please type one: ");
          religion = Console.ReadLine();
          this.welcomeMessage += " AND I AM " + religion.ToUpper();
      }

    }
}
