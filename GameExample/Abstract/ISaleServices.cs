using System;
using System.Collections.Generic;
using System.Text;
using GameExample.Entities;

namespace GameExample.Abstract
{
    interface ISaleServices
    {
        void Add(Sale sale);
        void Update(Sale sale);
        void Delete(Sale sale);
    }
}
