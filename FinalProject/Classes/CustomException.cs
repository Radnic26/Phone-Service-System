using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    class CustomException : Exception
    {
        public CustomException()
        {
            MessageBox.Show("Client list is empty.");
        }
    }
}
