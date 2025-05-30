using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceAndProperty.Interface;

interface IWork
{
    public bool isWork { get; set; }
    void Work();
}
