using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Interfaces
{
    public interface ISessionDescriprion
    {
        void DisplayDescription(string filmName,string director, int year, string description);
    }
}
