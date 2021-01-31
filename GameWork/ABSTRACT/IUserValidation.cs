using System;
using System.Collections.Generic;
using System.Text;

namespace GameWork
{
    interface IUserValidation
    {
        bool Validate(Gamer gamer);// oyuncuların doğrulaması için gamer ı paramtre olarak verdik
    }
}
