using System;
using System.ComponentModel.DataAnnotations.Schema;
using Me.AlohaChina.Data.Identity;

namespace Me.AlohaChina.Data.Content
{
    public abstract class BaseResourceHistory
    {
        [Column]
        public User LastModifier
        {
            get;
            set;
        }

        [Column]
        public DateTime ModifyDateTime
        {
            get;
            set;
        }

        [Column]
        protected ResourceContent InternalOriginalContent
        {
            get;
            set;
        }
    }
}
