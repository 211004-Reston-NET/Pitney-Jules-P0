using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRUI
{
    public interface IMenu
    {
        /// <summary>
        /// Will display the menu of the menu class and the choices available to the user. 
        /// </summary>
        void Menu();


        /// <summary>
        /// Will record the users choice and change the menu based on their selection. 
        /// </summary>
        void YourChoice(); 
    }
}
