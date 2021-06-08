using System;
using Flunt.Notifications;

namespace PaymentContext.Shared.Entities
{
    public abstract class Entity : Notifiable // pacote flunt
    {
        public Guid Id { get; private set; }

        protected Entity()
        {
            Id = Guid.NewGuid(); // gera o id no .net ao invés de gerar no banco
        }
    }
}