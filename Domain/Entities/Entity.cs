using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Entities
{
    public abstract class Entity
    {
        public List<string> _validationMessage { get; set; }
        private List<string> validationMessage { get { return _validationMessage ?? (_validationMessage = new List<string>()); } }
        public abstract void Validate();
        protected void CleanValidationMessages()
        {
            validationMessage.Clear();
        }
        protected bool isValid { get { return !validationMessage.Any(); } }

        protected void AddCommentary(string message)
        {
            validationMessage.Add(message);
        }
    }
}
