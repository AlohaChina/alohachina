
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace Me.AlohaChina.Data.Content
{
    public class BaseLibrary : BaseResource
    {
        [Column]
        public IList<BaseResource> ResourcePool
        {
            get;
            set;
        }
    }
}
