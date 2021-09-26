using Tennis.Entities;
using Tennis.Exceptions;
using Tennis.Interfaces;

namespace Tennis.Common
{
    public abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;

            return handler;
        }

        public virtual string Handle(Player player1, Player player2)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(player1, player2);
            }
            else
            {
                throw new NotFoundHandleException("There is no Handle configured for this score.");
            }
        }
    }
}