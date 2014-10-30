using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Me.AlohaChina.Data.Identity;

namespace Me.AlohaChina.Data.Content
{
    public abstract class BaseResource
    {
        [Key]
        public string ResourceId
        {
            get;
            set;
        }

        [Column]
        public User Owner
        {
            get;
            set;
        }

        [Column]
        public DateTime CreateDateTime
        {
            get;
            set;
        }

        [Column]
        protected ResourceContent InternalContent
        {
            get;
            set;
        }
    }
}
