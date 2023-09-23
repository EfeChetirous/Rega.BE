using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Rega.DataHandler.Entity
{
    public interface IObjectState
    {
        [NotMapped]
        ObjectState ObjectState { get; set; }
    }
}
